using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class PhotoAttachmentPayload
    {
        [JsonProperty("photo_id")]
        public long PhotoId { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public override string ToString() => $"PhotoAttachmentPayload{{ photoId='{PhotoId}' token='{Token}' url='{Url}'}}";
    }
}
