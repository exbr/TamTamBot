using System.Collections.Generic;
using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class MessageConstructorInput : ConstructorInput
    {
        [JsonProperty("input_type"), JsonConverter(typeof(EnumMemberConverter))]
        public override ConstructorInputType Type => ConstructorInputType.Message;

        [JsonProperty("messages")]
        public List<NewMessageBody> Messages;

        public override string ToString() => $"MessageConstructorInput{{{base.ToString()} messages='{Messages}'}}";
    }
}
