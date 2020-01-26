using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class VideoAttachmentRequest : AttachmentRequest
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public override AttachmentType Type => AttachmentType.Video;

        [JsonProperty("payload")]
        public UploadedInfo Payload { get; set; }

        public override string ToString() => $"VideoAttachmentRequest{{{base.ToString()} payload='{Payload}'}}";
    }
}
