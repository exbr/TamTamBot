using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class GetAdminsQuery : TamTamQuery<ChatMembersList>
    {

        public GetAdminsQuery(TamTamClient client, long chatId)
            : base(client, $"/chats/{chatId}/members/admins", null, Method.GET)
        {
        }

    }
}
