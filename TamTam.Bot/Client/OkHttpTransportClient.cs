using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExLib.TamTam.Bot.Exceptions;

namespace ExLib.TamTam.Bot.Client
{
    public class OkHttpTransportClient : ITamTamTransportClient
    {
        private readonly HttpClient _httpClient;
        private HttpListener _httpListener;

        private const string UserAgent = "TamTam C# Client/0.0.1";

        public OkHttpTransportClient()
        {
            _httpClient = new HttpClient();

            _httpClient.DefaultRequestHeaders.Add("User-Agent", UserAgent);
            //{
            //    Encoding = Encoding.UTF8,
            //    Headers = { ["User-Agent"] = UserAgent }
            //};
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ClientResponse> Get(string url, CancellationToken cancellationToken = default)
        {
            try
            {
                var response = await _httpClient.GetAsync(url, cancellationToken);

                return new ClientResponse(response.StatusCode, await response.Content.ReadAsByteArrayAsync(), response.Headers);
            }
            catch (HttpRequestException e)
            {
                throw new TransportClientException("Failed to execute GET request", e);
            }
        }

        public Task<ClientResponse> Post(string url, byte[] body, CancellationToken cancellationToken = default)
        {
            var content = new ByteArrayContent(body);
            {
                return Post(url, content, cancellationToken);
            }
        }

        public Task<ClientResponse> Post(string url, string body, CancellationToken cancellationToken = default)
        {
            var content = new StringContent(body, Encoding.UTF8);
            {
                return Post(url, content, cancellationToken);
            }
        }

        public Task<ClientResponse> Post(string url, string filename, Stream inputStream, CancellationToken cancellationToken = default)
        {
            var httpContent = new MultipartFormDataContent();
            {
                httpContent.Add(new StreamContent(inputStream), "data", filename);

                return Post(url, httpContent, cancellationToken);
            }
        }

        public Task<ClientResponse> Post(string url, FileInfo file, CancellationToken cancellationToken = default)
        {
            var filename = file.FullName;
            return Post(url, filename, file.OpenRead(), cancellationToken);
        }

        private async Task<ClientResponse> Post(string url, HttpContent httpContent, CancellationToken cancellationToken = default)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, httpContent, cancellationToken);

                return new ClientResponse(response.StatusCode, await response.Content.ReadAsByteArrayAsync(), response.Headers);
            }
            catch (HttpRequestException e)
            {
                throw new TransportClientException("Failed to execute POST request", e);
            }
        }

        public Task<ClientResponse> Put(string url, byte[] requestBody, CancellationToken cancellationToken = default)
        {
            using (var content = new ByteArrayContent(requestBody))
                return Put(url, content, cancellationToken);
        }

        public Task<ClientResponse> Put(string url, string requestBody, CancellationToken cancellationToken = default)
        {
            using (var content = new StringContent(requestBody, Encoding.UTF8))
                return Put(url, content, cancellationToken);
        }

        private async Task<ClientResponse> Put(string url, HttpContent content, CancellationToken cancellationToken = default)
        {
            try
            {
                var response = await _httpClient.PutAsync(url, content, cancellationToken);

                return new ClientResponse(response.StatusCode, await response.Content.ReadAsByteArrayAsync(), response.Headers);
            }
            catch (HttpRequestException e)
            {
                throw new TransportClientException("Failed to execute PUT request", e);
            }
        }

        public async Task<ClientResponse> Delete(string url, CancellationToken cancellationToken = default)
        {
            try
            {
                var response = await _httpClient.DeleteAsync(url, cancellationToken);

                return new ClientResponse(response.StatusCode, await response.Content.ReadAsByteArrayAsync(), response.Headers);
            }
            catch (HttpRequestException e)
            {
                throw new TransportClientException("Failed to execute DELETE request", e);
            }
        }

        public Task<ClientResponse> Patch(string url, byte[] requestBody, CancellationToken cancellationToken = default)
        {
            using (var content = new ByteArrayContent(requestBody))
                return Patch(url, content, cancellationToken);
        }

        public Task<ClientResponse> Patch(string url, string requestBody, CancellationToken cancellationToken = default)
        {
            using (var content = new StringContent(requestBody, Encoding.UTF8))
                return Patch(url, content, cancellationToken);
        }

        private async Task<ClientResponse> Patch(string url, HttpContent content, CancellationToken cancellationToken = default)
        {
            try
            {
                var method = new HttpMethod("PATCH");

                var request = new HttpRequestMessage(method, url)
                {
                    Content = content
                };

                var response = await _httpClient.SendAsync(request, cancellationToken);

                return new ClientResponse(response.StatusCode, await response.Content.ReadAsByteArrayAsync(), response.Headers);
            }
            catch (HttpRequestException e)
            {
                throw new TransportClientException("Failed to execute PATCH request", e);
            }
        }

        public void StartWebHook(string url, Action<ClientResponse> callback, CancellationToken cancellationToken = default)
        {
            _httpListener = new HttpListener();
            _httpListener.Prefixes.Add(url);

            _httpListener.Start();

            Task.Run((Action)(async () =>
            {
                while (_httpListener.IsListening)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    var context = await _httpListener.GetContextAsync();

                    var request = context.Request;
                    var buf = new byte[request.ContentLength64];
                    request.InputStream.Read(buf, 0, (int)request.ContentLength64);

                    foreach (string header in request.Headers)
                    {
                        var val = request.Headers[header].Split(';');
                    }

                    var headers = request.Headers.Cast<string>().ToDictionary(s => s, s => (IEnumerable<string>)request.Headers[s].Split(';'));
                    var clientResponse = new ClientResponse((HttpStatusCode)context.Response.StatusCode, buf, headers);
                    context.Response.Close();

                    new Thread(o => callback((ClientResponse)o)).Start(clientResponse); //callback(clientResponse), cancellationToken);
                }

            }), cancellationToken);

        }

    }
}
