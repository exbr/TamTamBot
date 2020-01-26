using System.Net;

namespace ExLib.TamTam.Bot.Exceptions
{
    public class ServiceNotAvailableException : ClientException
    {
        public ServiceNotAvailableException(string message) : base(HttpStatusCode.ServiceUnavailable, message)
        {
        }
    }
}
