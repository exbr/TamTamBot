using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class AudioAttachment : Attachment
    {
        [JsonConverter(typeof(EnumMemberConverter)), JsonProperty("type")]
        public override AttachmentType Type => AttachmentType.Audio;

        [JsonProperty("payload")] public MediaAttachmentPayload Payload { get; set; }

        public override string ToString() => $"AudioAttachment{{{base.ToString()} payload='{Payload}'}}";
    }
}
