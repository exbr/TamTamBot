using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class InlineKeyboardAttachment : Attachment
    {
        [JsonConverter(typeof(EnumMemberConverter)), JsonProperty("type")]
        public override AttachmentType Type => AttachmentType.InlineKeyboard;

        [JsonProperty("payload")]
        public Keyboard Payload { get; set; }

        public override string ToString() => $"InlineKeyboardAttachment{{{base.ToString()} payload='{Payload}'}}";
    }
}
