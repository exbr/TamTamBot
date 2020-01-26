using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class SendActionQuery : TamTamQuery<SimpleQueryResult>
    {
        public SendActionQuery(TamTamClient client, ActionRequestBody actionRequestBody, long chatId)
            : base(client, $"/chats/{chatId}/actions", actionRequestBody, Method.POST)
        {

        }
    }
}
