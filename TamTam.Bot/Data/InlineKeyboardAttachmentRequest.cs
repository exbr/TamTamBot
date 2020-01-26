using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class InlineKeyboardAttachmentRequest : AttachmentRequest
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public override AttachmentType Type => AttachmentType.InlineKeyboard;

        [JsonProperty("payload")]
        public InlineKeyboardAttachmentRequestPayload Payload { get; set; }

        public override string ToString() => $"InlineKeyboardAttachmentRequest{{{base.ToString()} payload='{Payload}'}}";
    }
}
