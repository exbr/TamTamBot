using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    [JsonConverter(typeof(EnumMemberConverter))]
    public enum AttachmentType
    {
        [EnumMember("image")]
        Image,
        [EnumMember("video")]
        Video,
        [EnumMember("audio")]
        Audio,
        [EnumMember("file")]
        File,
        [EnumMember("sticker")]
        Sticker,
        [EnumMember("contact")]
        Contact,
        [EnumMember("inline_keyboard")]
        InlineKeyboard,
        [EnumMember("share")]
        Share,
        [EnumMember("location")]
        Location
    }
}
