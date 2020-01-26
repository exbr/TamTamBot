using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class PhotoAttachment : Attachment
    {
        [JsonConverter(typeof(EnumMemberConverter)), JsonProperty("type")]
        public override AttachmentType Type => AttachmentType.Image;

        [JsonProperty("payload")]
        public PhotoAttachmentPayload Payload { get; set; }

        public override string ToString() => $"PhotoAttachment{{{base.ToString()} payload='{Payload}'}}";
    }
}
