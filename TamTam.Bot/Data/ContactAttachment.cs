using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ContactAttachment : Attachment
    {
        [JsonConverter(typeof(EnumMemberConverter)), JsonProperty("type")]
        public override AttachmentType Type => AttachmentType.Contact;

        [JsonProperty("payload")]
        public ContactAttachmentPayload Payload { get; set; }

        public override string ToString() => $"ContactAttachment{{{base.ToString()} payload='{Payload}'}}";
    }
}
