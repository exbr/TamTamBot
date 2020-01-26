using System;
using System.Reflection;

namespace ExLib.TamTam.Bot.Tools
{
    static class EnumTool
    {
        public static string GetEnumMember(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            EnumMemberAttribute[] attributes =
                (EnumMemberAttribute[])fi.GetCustomAttributes
                    (typeof(EnumMemberAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Value : value.ToString();
        }
    }
}
