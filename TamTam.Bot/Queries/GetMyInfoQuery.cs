using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class GetMyInfoQuery : TamTamQuery<BotInfo>
    {

        public GetMyInfoQuery(TamTamClient client)
            : base(client, "/me", null, Method.GET)
        {
        }

    }
}
