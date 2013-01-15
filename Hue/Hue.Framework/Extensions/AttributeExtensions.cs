using System;
using System.Reflection;
using Hue.Framework.Extensions.Attributes;
using Hue.Framework.Model.Response;

namespace Hue.Framework.Extensions {
    public static class AttributeExtensions {
        public static string GetHuePropertyName(this PropertyInfo property) {
            HuePropertyNameAttribute attribute = property.GetCustomAttribute<HuePropertyNameAttribute>();

            if (attribute == null) {
                return property.Name;
            }
            else {
                return attribute.PropertyName;
            }
        }

        public static string GetHuePropertyName(this IHueReturnableModel returnableObject) {
            Type type = returnableObject.GetType();

            HuePropertyNameAttribute attribute = type.GetCustomAttribute<HuePropertyNameAttribute>();

            if (attribute == null) {
                return type.Name;
            }
            else {
                return attribute.PropertyName;
            }
        }
    }
}
