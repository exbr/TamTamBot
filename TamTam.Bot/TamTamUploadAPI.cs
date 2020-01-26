using System.IO;
using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Queries.Upload;

namespace ExLib.TamTam.Bot
{
    public class TamTamUploadAPI
    {
        private readonly TamTamClient _client;

        public TamTamUploadAPI(TamTamClient client)
        {
            this._client = client;
        }

        public TamTamUploadFileQuery UploadFile(string url, FileInfo file)
        {
            return new TamTamUploadFileQuery(_client, url, file);
        }

        public TamTamUploadFileQuery UploadFile(string url, string fileName, Stream inputStream)
        {
            return new TamTamUploadFileQuery(_client, url, fileName, inputStream);
        }

        public TamTamUploadImageQuery UploadImage(string url, FileInfo file)
        {
            return new TamTamUploadImageQuery(_client, url, file.Name, file.OpenRead());
        }

        public TamTamUploadImageQuery UploadImage(string url, string fileName, Stream inputStream)
        {
            return new TamTamUploadImageQuery(_client, url, fileName, inputStream);
        }

        public TamTamUploadAVQuery UploadAV(string url, FileInfo file)
        {
            return new TamTamUploadAVQuery(_client, url, file);
        }

        public TamTamUploadAVQuery UploadAV(string url, string fileName, Stream inputStream)
        {
            return new TamTamUploadAVQuery(_client, url, fileName, inputStream);
        }
    }
}
