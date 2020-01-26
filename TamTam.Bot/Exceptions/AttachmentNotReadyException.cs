namespace ExLib.TamTam.Bot.Exceptions
{
    public class AttachmentNotReadyException : APIException
    {
        public AttachmentNotReadyException()
        : base("You cannot send message with unprocessed attachment (video in most cases). Please try after a " +
            "period of time. It depends on size of attachment.")
        {

        }
    }
}
