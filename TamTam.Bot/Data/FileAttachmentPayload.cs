using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class FileAttachmentPayload : AttachmentPayload
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        public override string ToString() => $"FileAttachmentPayload{{{base.ToString()} token='{Token}'}}";
    }
}
