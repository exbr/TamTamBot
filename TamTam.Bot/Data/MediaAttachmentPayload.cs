using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class MediaAttachmentPayload : AttachmentPayload
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        public override string ToString() => $"MediaAttachmentPayload{{{base.ToString()} token='{Token}'}}";
    }
}
