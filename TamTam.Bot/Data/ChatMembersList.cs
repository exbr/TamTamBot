using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ChatMembersList
    {
        [JsonProperty("members")]
        public List<ChatMember> Members { get; set; }

        [JsonProperty("marker")]
        public long? Marker { get; set; }

        public override string ToString() => $"ChatMembersList{{ members='{Members}' marker='{Marker}'}}";
    }
}
