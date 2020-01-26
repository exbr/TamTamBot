using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class FileAttachmentRequest : AttachmentRequest
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public override AttachmentType Type => AttachmentType.File;

        [JsonProperty("payload")]
        public UploadedInfo Payload { get; set; }

        public override string ToString() => $"FileAttachmentRequest{{{base.ToString()} payload='{Payload}'}}";
    }
}
