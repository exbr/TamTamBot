using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ExLib.TamTam.Bot.Client
{
    public interface ITamTamTransportClient
    {
        Task<ClientResponse> Get(string url, CancellationToken cancellationToken = default);

        Task<ClientResponse> Post(string url, byte[] body, CancellationToken cancellationToken = default);

        Task<ClientResponse> Post(string url, string body, CancellationToken cancellationToken = default);

        Task<ClientResponse> Post(string url, string filename, Stream inputStream, CancellationToken cancellationToken = default);
        
        Task<ClientResponse> Post(string url, FileInfo file, CancellationToken cancellationToken = default);

        Task<ClientResponse> Put(string url, byte[] requestBody, CancellationToken cancellationToken = default);

        Task<ClientResponse> Put(string url, string requestBody, CancellationToken cancellationToken = default);

        Task<ClientResponse> Delete(string url, CancellationToken cancellationToken = default);

        Task<ClientResponse> Patch(string url, byte[] requestBody, CancellationToken cancellationToken = default);

        Task<ClientResponse> Patch(string url, string requestBody, CancellationToken cancellationToken = default);

        void StartWebHook(string url, Action<ClientResponse> callback, CancellationToken cancellationToken = default);
    }
}
