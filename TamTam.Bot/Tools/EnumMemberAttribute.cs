using System;

namespace ExLib.TamTam.Bot.Tools
{
    public class EnumMemberAttribute : Attribute
    {
        public string Value { get; set; }

        public EnumMemberAttribute(string value)
        {
            Value = value;
        }
    }
}
