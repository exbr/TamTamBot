using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class EditMyInfoQuery : TamTamQuery<BotInfo>
    {

        public EditMyInfoQuery(TamTamClient client, BotPatch botPatch)
            : base(client, "/me", botPatch, Method.PATCH)
        {
        }

    }
}
