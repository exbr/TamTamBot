using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class InlineKeyboardAttachmentRequestPayload
    {
        [JsonProperty("buttons")]
        public List<List<Button>> Buttons { get; set; }

        public override string ToString() => $"InlineKeyboardAttachmentRequestPayload{{ buttons='{Buttons}'}}";
    }
}
