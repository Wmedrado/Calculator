using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Calculator
{
    internal class EnumHelper
    {
        public static string EnumToString(Enum enumType)
        {
            return enumType.ToString();
        }

        public static string GetDisplayName<TEnum>(TEnum value) where TEnum : Enum
        {
            var enumType = typeof(TEnum);
            var enumName = value.ToString();
            var member = enumType.GetMember(enumName).FirstOrDefault();
            
            if (member == null)
            {
                return enumName;
            }
            var displayAttribute = member.GetCustomAttribute<DisplayAttribute>();
            return displayAttribute != null ? displayAttribute.GetName() : enumName;
        }
    }
}
