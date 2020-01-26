using ExLib.TamTam.Bot.Tools;

namespace ExLib.TamTam.Bot.Data
{
    public enum ChatStatus
    {
        [EnumMember("active")]
        Active,
        [EnumMember("removed")]
        Removed,
        [EnumMember("left")]
        Left,
        [EnumMember("closed")]
        Closed,
        [EnumMember("suspended")]
        Suspended
    }
}
