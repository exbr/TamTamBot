using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class NewMessageBody
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("attachments")]
        public List<AttachmentRequest> Attachments { get; set; }

        [JsonProperty("link")]
        public NewMessageLink Link { get; set; }

        [JsonProperty("notify")]
        public bool IsNotify { get; set; }

        public override string ToString() => $"NewMessageBody{{ text='{Text}' attachments='{Attachments}' link='{Link}' notify='{IsNotify}'}}";
    }
}
