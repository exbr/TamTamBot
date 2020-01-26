using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class GetChatQuery : TamTamQuery<Chat>
    {

        public GetChatQuery(TamTamClient client, long chatId)
            : base(client, $"/chats/{chatId}", null, Method.GET)
        {
        }

    }
}
