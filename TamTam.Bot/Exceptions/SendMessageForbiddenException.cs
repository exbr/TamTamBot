namespace ExLib.TamTam.Bot.Exceptions
{
    public class SendMessageForbiddenException : APIException
    {
        public SendMessageForbiddenException(string message)
            : base(message)
        {
        }
    }
}
