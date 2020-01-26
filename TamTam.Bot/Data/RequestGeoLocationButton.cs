using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class RequestGeoLocationButton : Button
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public override ButtonType Type => ButtonType.RequestGeoLocation;

        [JsonProperty("quick")]
        public bool Quick { get; set; }

        public override string ToString() => $"RequestGeoLocationButton{{{base.ToString()} quick='{Quick}'}}";
    }
}
