using ExLib.TamTam.Bot.Tools;

namespace ExLib.TamTam.Bot.Data
{
    public enum Intent
    {
        [EnumMember("default")]
        Default,
        [EnumMember("positive")]
        Positive,
        [EnumMember("negative")]
        Negative
    }
}
