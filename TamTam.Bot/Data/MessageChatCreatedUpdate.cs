using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class MessageChatCreatedUpdate : Update
    {
        [JsonProperty("update_type"), JsonConverter(typeof(EnumMemberConverter))]
        public override UpdateType UpdateType => UpdateType.MessageChatCreated;

        [JsonProperty("chat")]
        public Chat Chat { get; set; }
        
        [JsonProperty("message_id")]
        public string MessageId { get; set; }
        
        [JsonProperty("start_payload")]
        public string StartPayload { get; set; }

        public override string ToString() => $"MessageChatCreatedUpdate{{{base.ToString()} chat='{Chat}' messageId='{MessageId}' startPayload='{StartPayload}'}}";
    }
}
