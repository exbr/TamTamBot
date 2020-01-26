using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class MessageStat
    {
        [JsonProperty("views")]
        public int Views { get; set; }

        public override string ToString() => $"MessageStat{{ views='{Views}'}}";
    }
}
