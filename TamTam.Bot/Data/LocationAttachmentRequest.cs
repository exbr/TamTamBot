using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class LocationAttachmentRequest : AttachmentRequest
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        public override string ToString() => $"LocationAttachmentRequest{{{base.ToString()} latitude='{Latitude}' longitude='{Longitude}'}}";
    }
}
