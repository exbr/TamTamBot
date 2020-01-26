using System;

namespace ExLib.TamTam.Bot.Exceptions
{
    public class TransportClientException : Exception
    {
        public TransportClientException(string message) : base(message)
        {
        }

        public TransportClientException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
