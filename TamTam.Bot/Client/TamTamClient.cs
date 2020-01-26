using System;
using ExLib.TamTam.Bot.Data;
using ExLib.TamTam.Bot.Queries;

namespace ExLib.TamTam.Bot.Client
{
    public class TamTamClient
    {
        private const string ENDPOINT = "https://botapi.tamtam.chat";

        public string AccessToken { get; }
        public ITamTamTransportClient Transport { get; }
        public string Endpoint { get; }

        public TamTamClient(string accessToken, ITamTamTransportClient transport)
        {
            if (accessToken == null)
            {
                throw new ArgumentNullException(nameof(accessToken));
            }

            if (transport == null)
            {
                throw new ArgumentNullException(nameof(transport));
            }

            Endpoint = CreateEndpoint();
            AccessToken = accessToken;
            Transport = transport;
        }

        public static TamTamClient Create(string accessToken)
        {
            if (accessToken == null)
            {
                throw new ArgumentNullException(nameof(accessToken));
            }

            var transport = new OkHttpTransportClient();
            return new TamTamClient(accessToken, transport);
        }

        private string CreateEndpoint()
        {
            //return (!string.IsNullOrWhiteSpace(Settings.Default.endpoint)) ? Settings.Default.endpoint : ENDPOINT;
            return ENDPOINT;
        }

        public void StartWebHook(string url, Action<Update> callback)
        {

            Transport.StartWebHook(url, (response) =>
            {
                var update = TamTamQuery<Update>.Deserialize(response);
                callback(update);
            });
        }
    }
}
