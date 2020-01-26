using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class PhotoToken
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        public override string ToString() => $"PhotoToken{{ token='{Token}'}}";
    }
}
