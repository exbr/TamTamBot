using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class GetSubscriptionsResult
    {
        [JsonProperty("subscriptions")]
        public List<Subscription> Subscriptions { get; set; }

        public override string ToString() => $"GetSubscriptionsResult{{ subscriptions='{Subscriptions}'}}";
    }
}
