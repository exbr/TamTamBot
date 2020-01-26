using System;
using System.Net;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Exceptions
{
    public class APIException : Exception
    {
        public HttpStatusCode StatusCode { get; }

        public APIException(string message) : this(HttpStatusCode.BadRequest, message)
        {
        }

        public APIException(HttpStatusCode statusCode)
           : this(HttpStatusCode.ServiceUnavailable, "Unexpected server error: " + statusCode)
        {
        }

        public APIException(HttpStatusCode statusCode, string responseBody)
            : base("Server error " + statusCode + ": " + responseBody)
        {
            this.StatusCode = statusCode;
        }

        public APIException(HttpStatusCode statusCode, string errorCode, string message)
            : base("API exception " + errorCode + ": " + message)
        {
            this.StatusCode = statusCode;
        }

        public static APIException Map(HttpStatusCode statusCode, Error error)
        {
            var message = error.Message;
            switch (error.Code)
            {
                case "attachment.not.ready":
                    return new AttachmentNotReadyException();
                case "too.many.requests":
                    return new TooManyRequestsException(message);
                case "access.denied":
                    return new AccessForbiddenException(message);
                case "chat.denied":
                    if ("chat.send.msg.no.permission.because.not.admin" == message)
                    {
                        return new SendMessageForbiddenException(message);
                    }
                    return new ChatAccessForbiddenException(message);
            }

            return new APIException(statusCode, error.Code, message);
        }
    }
}
