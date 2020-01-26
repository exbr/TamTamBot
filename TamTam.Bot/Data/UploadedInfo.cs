using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class UploadedInfo
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        public override string ToString() => $"UploadedInfo{{ token='{Token}'}}";
    }
}
