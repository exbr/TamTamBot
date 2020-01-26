using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class MessageBody
    {
        [JsonProperty("mid")]
        public string Mid { get; set; }

        [JsonProperty("seq")]
        public long Seq { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("attachments")]
        public List<Attachment> Attachments { get; set; }

        public override string ToString() => $"MessageBody{{ mid='{Mid}' seq='{Seq}' text='{Text}' attachments='{Attachments}'}}";
    }
}
