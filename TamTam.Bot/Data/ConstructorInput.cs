using System;
using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExLib.TamTam.Bot.Data
{
    [JsonConverter(typeof(ConstructorInputConverter))]
    public class ConstructorInput
    {
        [JsonProperty("input_type"), JsonConverter(typeof(EnumMemberConverter))]
        public virtual ConstructorInputType Type { get; set; }

        public override string ToString() => "ConstructorInput{}";
    }

    public class ConstructorInputConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);


            //Enum.TryParse<ButtonType>(jObject.GetValue("type").Value<string>(), out var attachmentType);

            var constructorInput = new ConstructorInput();
            serializer.Populate(jObject.CreateReader(), constructorInput);

            switch (constructorInput.Type)
            {
                case ConstructorInputType.Callback:
                    constructorInput = new CallbackConstructorInput();
                    break;
                case ConstructorInputType.Message:
                    constructorInput = new MessageConstructorInput();
                    break;
                default:
                    constructorInput = new ConstructorInput();
                    break;
            }


            // Create target object based on JObject
            //T target = Create(objectType, jObject);

            // Populate the object properties
            serializer.Populate(jObject.CreateReader(), constructorInput);

            return constructorInput;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }

}
