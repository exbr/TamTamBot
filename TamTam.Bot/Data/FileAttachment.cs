using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class FileAttachment : Attachment
    {
        [JsonConverter(typeof(EnumMemberConverter)), JsonProperty("type")]
        public override AttachmentType Type => AttachmentType.File;

        [JsonProperty("payload")]
        public FileAttachmentPayload Payload { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        public override string ToString() => $"FileAttachment{{{base.ToString()} payload='{Payload}' filename='{Filename}' size='{Size}'}}";
    }
}
