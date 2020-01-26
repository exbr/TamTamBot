using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class LeaveChatQuery : TamTamQuery<SimpleQueryResult>
    {

        public LeaveChatQuery(TamTamClient client, long chatId)
            : base(client, $"/chats/{chatId}/members/me", null, Method.DELETE)
        {
        }

    }
}
