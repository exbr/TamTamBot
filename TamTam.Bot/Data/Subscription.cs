using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class Subscription
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("update_types")]
        public List<string> UpdateTypes { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        public override string ToString() => $"Subscription{{ url='{Url}' time='{Time}' updateTypes='{UpdateTypes}' version='{Version}'}}";
    }
}
