using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class StickerAttachmentPayload : AttachmentPayload
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        public override string ToString() => $"StickerAttachmentPayload{{{base.ToString()} code='{Code}'}}";
    }
}
