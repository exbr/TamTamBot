using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    [JsonConverter(typeof(EnumMemberConverter))]
    public enum ButtonType
    {
        [EnumMember("callback")]
        Callback,
        [EnumMember("link")]
        Link,
        [EnumMember("request_geo_location")]
        RequestGeoLocation,
        [EnumMember("request_contact")]
        RequestContact,
        [EnumMember("chat")]
        Chat,

    }
}
