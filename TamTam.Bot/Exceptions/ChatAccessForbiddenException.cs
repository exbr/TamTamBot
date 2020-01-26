using System.Net;

namespace ExLib.TamTam.Bot.Exceptions
{
    public class ChatAccessForbiddenException : APIException
    {
        public ChatAccessForbiddenException(string message)
            : base(HttpStatusCode.Forbidden, message)
        {
        }
    }
}
