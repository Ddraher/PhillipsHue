using System;
using System.Json;
using System.Linq;
using System.Reflection;
using Hue.Framework.Extensions;

namespace Hue.Framework.Model.Response {
    public abstract class HueReturnableBase : IHueReturnableModel {
        public virtual void SetSelf(JsonObject value) {
            //Check if current item is nested inside a parent container
            string huePropertyName = this.GetHuePropertyName();
            if (value.ContainsKey(huePropertyName)) {
                value = value.First().Value.ToJsonObject();
            }

            Type type = this.GetType();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties) {
                type = property.PropertyType;

                if (typeof(IHueReturnableModel).IsAssignableFrom(type)) {
                    IHueReturnableModel instance = (IHueReturnableModel)Activator.CreateInstance(type);

                    huePropertyName = instance.GetHuePropertyName();

                    JsonValue propertyValue = value.ValueOrDefault(huePropertyName);

                    instance.SetSelf(propertyValue.ToJsonObject());

                    property.SetValue(this, instance);
                }
                else {
                    huePropertyName = property.GetHuePropertyName();
                    if (value.ContainsKey(huePropertyName)) {
                        JsonValue propertyValue = value.ValueOrDefault(huePropertyName);
                        object jsonPropertyValue = propertyValue.ReadAs(type);
                        property.SetValue(this, jsonPropertyValue);
                    }
                }
            }
        }
    }
}
