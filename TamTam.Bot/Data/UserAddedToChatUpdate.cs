using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class UserAddedToChatUpdate : Update
    {
        [JsonProperty("update_type"), JsonConverter(typeof(EnumMemberConverter))]
        public override UpdateType UpdateType => UpdateType.UserAdded;

        [JsonProperty("chat_id")]
        public long ChatId { get; set; }


        [JsonProperty("user")]
        public User User { get; set; }


        [JsonProperty("inviter_id")]
        public long InviterId { get; set; }

        public override string ToString() => $"UserAddedToChatUpdate{{{base.ToString()} chatId='{ChatId}' user='{User}' inviterId='{InviterId}'}}";
    }
}
