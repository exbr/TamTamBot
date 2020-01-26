using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class PhotoTokens
    {
        [JsonProperty("photos")]
        public Dictionary<string, PhotoToken> Photos { get; set; }

        public override string ToString() => $"PhotoTokens{{ photos='{Photos}'}}";
    }
}
