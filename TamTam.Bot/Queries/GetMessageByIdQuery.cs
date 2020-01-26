using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class GetMessageByIdQuery : TamTamQuery<Message>
    {
        public GetMessageByIdQuery(TamTamClient tamTamClient, string messageId)
            : base(tamTamClient, $"/messages/{messageId}", null, Method.GET)
        {
        }
    }
}