using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    [JsonConverter(typeof(EnumMemberConverter))]
    public enum SenderAction
    {
        [EnumMember("typing_on")]
        TypingOn,
        [EnumMember("typing_off")]
        TypingOff,
        [EnumMember("sending_photo")]
        SendingPhoto,
        [EnumMember("sending_video")]
        SendingVideo,
        [EnumMember("sending_audio")]
        SendingAudio,
        [EnumMember("mark_seen")]
        MarkSeen
    }
}
