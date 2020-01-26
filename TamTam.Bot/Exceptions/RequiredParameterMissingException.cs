using System.Net;

namespace ExLib.TamTam.Bot.Exceptions
{
    public class RequiredParameterMissingException : ClientException
    {
        public RequiredParameterMissingException( string message) : base(HttpStatusCode.BadRequest, message)
        {
        }
    }
}
