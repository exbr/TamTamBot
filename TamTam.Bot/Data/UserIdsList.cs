using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class UserIdsList
    {
        [JsonProperty("user_ids")]
        public List<long> UserIds { get; set; }

        public override string ToString() => $"UserIdsList{{ userIds='{UserIds}'}}";
    }
}
