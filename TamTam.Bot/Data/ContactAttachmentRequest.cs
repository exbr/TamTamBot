using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ContactAttachmentRequest : AttachmentRequest
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public override AttachmentType Type => AttachmentType.Contact;

        [JsonProperty("payload")]
        public ContactAttachmentRequestPayload Payload { get; set; }

        public override string ToString() => $"ContactAttachmentRequest{{{base.ToString()} payload='{Payload}'}}";
    }
}
