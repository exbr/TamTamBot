using System.Collections.Generic;
using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class Chat
    {
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public ChatType Type { get; set; }

        [JsonProperty("status"), JsonConverter(typeof(EnumMemberConverter))]
        public ChatStatus Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("icon")]
        public Image Icon { get; set; }

        [JsonProperty("last_event_time ")]
        public long LastEventTime { get; set; }

        [JsonProperty("participants_count")]
        public int ParticipantsCount { get; set; }

        [JsonProperty("owner_id")]
        public long? OwnerId { get; set; }

        [JsonProperty("participants")]
        public Dictionary<string, long> Participants { get; set; }

        [JsonProperty("is_public")]
        public bool IsPublic { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("dialog_with_user")]
        public UserWithPhoto DialogWithUser { get; set; }

        [JsonProperty("messages_count")]
        public int MessagesCount { get; set; }

        [JsonProperty("chat_message_id")]
        public string ChatMessageId { get; set; }

        public override string ToString()
            => $"Chat{{ chatId='{ChatId}' type='{Type}' status='{Status}' title='{Title}' icon='{Icon}' lastEventTime='{LastEventTime}' "
               + $"participantsCount='{ParticipantsCount}' ownerId='{OwnerId}' participants='{Participants}' isPublic='{IsPublic}' link='{Link}' "
               + $"description='{Description}' dialogWithUser='{DialogWithUser}' messagesCount='{MessagesCount}' chatMessageId='{ChatMessageId}'}}";
    }
}
