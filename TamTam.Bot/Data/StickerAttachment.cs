using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class StickerAttachment : Attachment
    {
        [JsonProperty("type")]
        public override AttachmentType Type => AttachmentType.Sticker;

        [JsonProperty("payload")]
        public StickerAttachmentPayload Payload { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        public override string ToString() => $"StickerAttachment{{{base.ToString()} payload='{Payload}' width='{Width}' height='{Height}'}}";
    }
}
