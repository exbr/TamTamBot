using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ChatMember : UserWithPhoto
    {
        [JsonProperty("last_access_time")]
        public long LastAccessTime { get; set; }

        [JsonProperty("is_owner")]
        public bool IsOwner { get; set; }

        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("join_time")]
        public long JoinTime { get; set; }

        [JsonProperty("permissions")]
        public List<ChatAdminPermission> Permissions { get; set; }

        public override string ToString() => $"ChatMember{{{base.ToString()} lastAccessTime='{LastAccessTime}' isOwner='{IsOwner}' "
            + $"isAdmin='{IsAdmin}' joinTime='{JoinTime}' permissions='{Permissions}'}}";
    }
}
