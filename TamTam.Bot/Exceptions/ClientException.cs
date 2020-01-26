using System;
using System.Net;

namespace ExLib.TamTam.Bot.Exceptions
{
    public class ClientException : Exception
    {
        public HttpStatusCode Code { get; }

        public ClientException(HttpStatusCode code)
        {
            Code = code;
        }

        public ClientException()
        {
            Code = HttpStatusCode.BadRequest;
        }

        public ClientException(string message) : base(message)
        {
            Code = HttpStatusCode.BadRequest;
        }

        public ClientException(string message, Exception innerException) : base(message, innerException)
        {
            Code = HttpStatusCode.BadRequest;
        }

        public ClientException(HttpStatusCode code, string message) : base(message)
        {
            Code = code;
        }

        public ClientException(string message, Exception innerException, HttpStatusCode code) : base(message, innerException)
        {
            Code = code;
        }
    }
}
