using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Exceptions;

namespace ExLib.TamTam.Bot.Queries.Upload
{
    public abstract class TamTamUploadQuery<T> : TamTamQuery<T> where T : class
    {
        private readonly TamTamClient _tamTamClient;
        private readonly string _url;
        private readonly IUploadExec _uploadExec;

        protected TamTamUploadQuery(TamTamClient tamTamClient, string url, FileInfo file)
            : base(tamTamClient, url)
        {
            _tamTamClient = tamTamClient;
            _url = url;
            _uploadExec = new FileUploadExec(file, this);
        }

        protected TamTamUploadQuery(TamTamClient tamTamClient, string url, string fileName, Stream input)
            : base(tamTamClient, url)
        {
            _tamTamClient = tamTamClient;
            _url = url;
            _uploadExec = new StreamUploadExec(fileName, input, this);
        }

        public override async Task<T> Execute(CancellationToken cancellationToken = default)
        {
            var response = await _uploadExec.Call(cancellationToken);
            return Deserialize(response);
        }

        private interface IUploadExec
        {
            Task<ClientResponse> Call(CancellationToken cancellationToken);
        }

        private class FileUploadExec : IUploadExec
        {
            private readonly FileInfo _file;
            private readonly TamTamUploadQuery<T> _query;

            public FileUploadExec(FileInfo file, TamTamUploadQuery<T> query)
            {
                _file = file;
                _query = query;
            }

            public Task<ClientResponse> Call(CancellationToken cancellationToken)
            {
                try
                {
                    return _query._tamTamClient.Transport.Post(_query._url, _file, cancellationToken);
                }
                catch (TransportClientException e)
                {
                    throw new ClientException("FileUploadExec", e);
                }
            }
        }

        private class StreamUploadExec : IUploadExec
        {
            private readonly string _fileName;
            private readonly Stream _input;
            private readonly TamTamUploadQuery<T> _query;

            public StreamUploadExec(String fileName, Stream input, TamTamUploadQuery<T> query)
            {
                _fileName = fileName;
                _input = input;
                _query = query;
            }

            public Task<ClientResponse> Call(CancellationToken cancellationToken)
            {
                try
                {
                    return _query._tamTamClient.Transport.Post(_query._url, _fileName, _input, cancellationToken);
                }
                catch (TransportClientException e)
                {
                    throw new ClientException("StreamUploadExec", e);
                }
            }
        }
    }
}
