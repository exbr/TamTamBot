using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class UpdateList
    {
        [JsonProperty("updates")]
        public List<Update> Updates { get; set; }

        [JsonProperty("marker")]
        public long? Marker { get; set; }

        public override string ToString() => $"UpdateList{{ updates='{Updates}' marker='{Marker}'}}";
    }
}
