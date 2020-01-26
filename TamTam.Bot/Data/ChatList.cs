using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ChatList
    {
        [JsonProperty("chats")]
        public List<Chat> Chats { get; set; }

        [JsonProperty("marker")]
        public long? Marker { get; set; }

        public override string ToString() => $"ChatList{{ chats='{Chats}' marker='{Marker}'}}";
    }
}
