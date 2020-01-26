using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class SimpleQueryResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public override string ToString() => $"SimpleQueryResult{{ success='{Success}' message='{Message}'}}";
    }
}
