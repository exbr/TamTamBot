using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class UserWithPhoto : User
    {
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("full_avatar_url")]
        public string FullAvatarUrl { get; set; }

        public override string ToString() => $"UserWithPhoto{{{base.ToString()} avatarUrl='{AvatarUrl}' fullAvatarUrl='{FullAvatarUrl}'}}";
    }
}
