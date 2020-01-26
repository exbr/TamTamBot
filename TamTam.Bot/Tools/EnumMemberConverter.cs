using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ExLib.TamTam.Bot.Tools
{
    public class EnumMemberConverter : StringEnumConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            var text = ((Enum) value).GetEnumMember();
            writer.WriteValue(text);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                var enumString = reader.Value.ToString();
                var el = Enum.GetValues(objectType).Cast<Enum>().FirstOrDefault(e => e.GetEnumMember() == enumString);
                if (el != null)
                {
                    return el;
                }
            }
            return base.ReadJson(reader, objectType, existingValue, serializer);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.HasElementType;
        }
    }
}
