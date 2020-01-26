using ExLib.TamTam.Bot.Tools;

namespace ExLib.TamTam.Bot.Data
{
    public enum UploadType
    {
        [EnumMember("photo")]
        Photo,
        [EnumMember("video")]
        Video,
        [EnumMember("audio")]
        Audio,
        [EnumMember("file")]
        File,

    }
}
