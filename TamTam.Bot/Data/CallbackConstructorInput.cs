using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class CallbackConstructorInput : ConstructorInput
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }

        public override string ToString() => $"CallbackConstructorInput{{{base.ToString()} payload='{Payload}'}}";
    }
}
