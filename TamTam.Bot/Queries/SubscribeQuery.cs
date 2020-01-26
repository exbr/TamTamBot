using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class SubscribeQuery : TamTamQuery<SimpleQueryResult>
    {
        public SubscribeQuery(TamTamClient client, SubscriptionRequestBody subscriptionRequestBody)
          : base(client, "/subscriptions", subscriptionRequestBody, Method.POST)
        {
        }

}
}
