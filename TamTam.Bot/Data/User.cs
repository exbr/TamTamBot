using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class User
    {
        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        public override string ToString() => $"User{{ userId='{UserId}' name='{Name}' username='{UserName}'}}";
    }
}
