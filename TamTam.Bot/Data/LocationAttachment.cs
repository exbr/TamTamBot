using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class LocationAttachment : Attachment
    {
        [JsonConverter(typeof(EnumMemberConverter)), JsonProperty("type")]
        public override AttachmentType Type => AttachmentType.Location;

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        public override string ToString() => $"LocationAttachment{{{base.ToString()} latitude='{Latitude}' longitude='{Longitude}'}}";
    }
}
