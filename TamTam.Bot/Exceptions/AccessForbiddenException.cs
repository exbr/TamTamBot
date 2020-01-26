namespace ExLib.TamTam.Bot.Exceptions
{
    public class AccessForbiddenException : APIException
    {
        public AccessForbiddenException(string message)
            : base(message)
        {
        }
    }
}
