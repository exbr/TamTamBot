using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class SubscriptionRequestBody
    {
        [JsonProperty("url")]
        public string Url { get; set; }


        [JsonProperty("update_types")]
        public List<string> UpdateTypes { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        public override string ToString() => $"SubscriptionRequestBody{{ url='{Url}' updateTypes='{UpdateTypes}' version='{Version}'}}";
    }
}
