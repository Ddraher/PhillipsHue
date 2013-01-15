using System;
using System.Collections.Generic;
using System.Json;
using System.Reflection;
using Hue.Framework.Extensions;

namespace Hue.Framework.Model.Request {
    public abstract class HuePostableBase : IHuePostableModel {
        #region IHuePostableModel Members

        public virtual JsonObject CreateJsonObject() {
            JsonObject jsonObject = new JsonObject();

            Type type = this.GetType();

            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties) {
                Type propertyType = property.PropertyType;

                string HuePropertyName = property.GetHuePropertyName();

                JsonPrimitive subItem = new JsonPrimitive(property.GetValue(this).ToString());

                jsonObject.Add(new KeyValuePair<string, JsonValue>(HuePropertyName, subItem));
            }

            return jsonObject;
        }

        #endregion
    }
}
