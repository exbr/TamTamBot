using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ChatPatch
    {
        [JsonProperty("icon")]
        public PhotoAttachmentRequestPayload Icon { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        public override string ToString() => $"ChatPatch{{ icon='{Icon}' title='{Title}'}}";
    }
}
