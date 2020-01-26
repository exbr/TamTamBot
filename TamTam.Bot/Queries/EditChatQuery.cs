using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class EditChatQuery : TamTamQuery<Chat>
    {
        public EditChatQuery(TamTamClient client, ChatPatch chatPatch, long chatId)
            : base(client, $"/chats/{chatId}", chatPatch, Method.PATCH)
        {
        }
    }
}
