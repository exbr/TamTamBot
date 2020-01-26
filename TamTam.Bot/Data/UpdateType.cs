using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    [JsonConverter(typeof(EnumMemberConverter))]
    public enum UpdateType
    {
        [EnumMember("message_created")]
        MessageCreated,
        [EnumMember("message_callback")]
        MessageCallback,
        [EnumMember("message_edited")]
        MessageEdited,
        [EnumMember("message_removed")]
        MessageRemoved,
        [EnumMember("bot_added")]
        BotAdded,
        [EnumMember("bot_removed")]
        BotRemoved,
        [EnumMember("user_added")]
        UserAdded,
        [EnumMember("user_removed")]
        UserRemoved,
        [EnumMember("bot_started")]
        BotStarted,
        [EnumMember("chat_title_changed")]
        ChatTitleChanged,
        [EnumMember("message_construction_request")]
        MessageConstructionRequest,
        [EnumMember("message_constructed")]
        MessageConstructed,
        [EnumMember("message_chat_created")]
        MessageChatCreated,

    }
}
