namespace ExLib.TamTam.Bot.Exceptions
{
    public class TooManyRequestsException : APIException
    {
        public TooManyRequestsException(string message)
            : base(message)
        {
        }
    }
}
