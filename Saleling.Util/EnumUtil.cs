using System.ComponentModel;
using System.Reflection;

namespace Saleling.Util
{
    public static class EnumUtil
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo? fi = value.GetType().GetField(value.ToString());

            if (fi != null)
            {
                if (Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    return attribute.Description;
                }
            }
            return value.ToString();
        }
    }
}
