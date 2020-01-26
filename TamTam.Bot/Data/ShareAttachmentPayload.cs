using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ShareAttachmentPayload
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        public override string ToString() => $"ShareAttachmentPayload{{ url='{Url}' token='{Token}'}}";
    }
}
