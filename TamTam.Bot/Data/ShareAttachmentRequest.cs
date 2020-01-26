using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ShareAttachmentRequest : AttachmentRequest
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public override AttachmentType Type => AttachmentType.Share;

        [JsonProperty("payload")]
        public ShareAttachmentPayload Payload { get; set; }

        public override string ToString() => $"ShareAttachmentRequest{{{base.ToString()} payload='{Payload}'}}";
    }
}
