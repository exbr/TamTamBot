using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class GetSubscriptionsQuery : TamTamQuery<GetSubscriptionsResult>
    {

        public GetSubscriptionsQuery(TamTamClient client)
            : base(client, "/subscriptions", null, Method.GET)
        {
        }

    }
}
