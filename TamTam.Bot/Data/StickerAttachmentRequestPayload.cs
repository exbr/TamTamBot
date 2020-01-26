using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class StickerAttachmentRequestPayload
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        public override string ToString() => $"StickerAttachmentRequestPayload{{ code='{Code}'}}";
    }
}
