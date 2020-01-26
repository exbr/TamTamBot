using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class BotInfo : UserWithPhoto
    {
        [JsonProperty("commands")]
        public List<BotCommand> Commands { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public override string ToString() => $"BotInfo{{{base.ToString()} commands='{Commands}' description='{Description}'}}";
    }
}
