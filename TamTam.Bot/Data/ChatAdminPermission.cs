using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    [JsonConverter(typeof(EnumMemberConverter))]
    public enum ChatAdminPermission
    {
        [EnumMember("read_all_messages")]
        ReadAllMessages,
        [EnumMember("add_remove_members")]
        AddRemoveMembers,
        [EnumMember("add_admins")]
        AddAdmins,
        [EnumMember("change_chat_info")]
        ChangeChatInfo,
        [EnumMember("pin_message")]
        PinMessage,
        [EnumMember("write")]
        Write,

    }
}
