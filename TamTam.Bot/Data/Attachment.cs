using System;
using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExLib.TamTam.Bot.Data
{
    [JsonConverter(typeof(AttachmentConverter))]
    public class Attachment
    {

        [JsonConverter(typeof(EnumMemberConverter)), JsonProperty("type")]
        public virtual AttachmentType Type { get; set; }

        public override string ToString()
        {
            return "Attachment{}";
        }
    }

    public class AttachmentConverter : JsonConverter
    {
        public override bool CanRead => true;
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            //var attachmentType = jObject.GetValue("type").Value<string>();
            var attachment = new Attachment();
            serializer.Populate(jObject.CreateReader(), attachment);

            switch (attachment.Type)
            {
                case AttachmentType.Contact:
                    attachment = new ContactAttachment();
                    break;
                case AttachmentType.Image:
                    attachment = new PhotoAttachment();
                    break;
                case AttachmentType.Audio:
                    attachment = new AudioAttachment();
                    break;
                case AttachmentType.Video:
                    attachment = new VideoAttachment();
                    break;
                case AttachmentType.File:
                    attachment = new FileAttachment();
                    break;
                case AttachmentType.Sticker:
                    attachment = new StickerAttachment();
                    break;
                case AttachmentType.Share:
                    attachment = new ShareAttachment();
                    break;
                case AttachmentType.Location:
                    attachment = new LocationAttachment();
                    break;
                case AttachmentType.InlineKeyboard:
                    attachment = new InlineKeyboardAttachment();
                    break;
                default:
                    attachment = new Attachment();
                    break;
            }

            serializer.Populate(jObject.CreateReader(), attachment);

            return attachment;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }


    }
}
