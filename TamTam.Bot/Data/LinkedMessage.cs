using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class LinkedMessage
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        private MessageLinkType Type { get; set; }

        [JsonProperty("sender")]
        private User Sender { get; set; }

        [JsonProperty("chat_id")]
        private long ChatId { get; set; }

        [JsonProperty("message")]
        private MessageBody Message { get; set; }

        public override string ToString() => $"LinkedMessage{{ type='{Type}' sender='{Sender}' chatId='{ChatId}' message='{Message}'}}";
    }
}
