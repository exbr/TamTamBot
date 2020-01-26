using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class BotCommand
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public override string ToString() => $"BotCommand{{ name='{Name}' description='{Description}'}}";
    }
}
