using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    class StickerAttachmentRequest : AttachmentRequest
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public override AttachmentType Type => AttachmentType.Sticker;

        [JsonProperty("payload")]
        public StickerAttachmentRequestPayload Payload { get; set; }

        public override string ToString() => $"StickerAttachmentRequest{{{base.ToString()} payload='{Payload}'}}";
    }
}
