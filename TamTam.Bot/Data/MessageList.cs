using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class MessageList
    {
        [JsonProperty("messages")]
        private List<Message> Messages { get; set; }

        public override string ToString() => $"MessageList{{ messages='{Messages}'}}";
    }
}
