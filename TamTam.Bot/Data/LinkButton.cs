using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class LinkButton : Button
    {
        [JsonProperty("type")]
        public override ButtonType Type => ButtonType.Link;

        [JsonProperty("url")]
        public string Url { get; set; }

        public override string ToString() => $"LinkButton{{{base.ToString()} url='{Url}'}}";
    }
}
