using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace ExLib.TamTam.Bot.Client
{
    public class ClientResponse
    {
        public HttpStatusCode StatusCode { get; }
        public byte[] Body { get; }
        public Dictionary<string, IEnumerable<string>> Headers { get; }

        public ClientResponse(HttpStatusCode statusCode, byte[] body, HttpHeaders headers)
                : this(statusCode, body, headers.ToDictionary(h => h.Key, h => h.Value))
        {

        }

        public ClientResponse(HttpStatusCode statusCode, byte[] body, Dictionary<string, IEnumerable<string>> headers)
        {
            StatusCode = statusCode;
            Body = body;
            Headers = headers;
        }

        public string BodyAsString => Encoding.UTF8.GetString(Body);
    }
}
