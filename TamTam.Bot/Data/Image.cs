using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class Image
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        public override string ToString() => $"Image{{ url='{Url}'}}";
    }
}
