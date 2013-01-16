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

                if (propertyType.IsValueType && Nullable.GetUnderlyingType(propertyType) == null) {
                    string HuePropertyName = property.GetHuePropertyName();

                    JsonPrimitive subItem = GetJsonPrimitive(property.GetValue(this), propertyType);

                    jsonObject.Add(new KeyValuePair<string, JsonValue>(HuePropertyName, subItem));
                }
                else {
                    object propertyValue = property.GetValue(this);

                    if (propertyValue != null) {
                        Type baseType = Nullable.GetUnderlyingType(propertyType);

                        string HuePropertyName = property.GetHuePropertyName();

                        JsonPrimitive subItem = GetJsonPrimitive(property.GetValue(this), baseType);

                        jsonObject.Add(new KeyValuePair<string, JsonValue>(HuePropertyName, subItem));
                    }
                }
            }

            return jsonObject;
        }

        #endregion

        protected JsonPrimitive GetJsonPrimitive(object objectToConvert) {
            Type propertyType = objectToConvert.GetType();

            return GetJsonPrimitive(objectToConvert, propertyType);
        }

        protected JsonPrimitive GetJsonPrimitive(object objectToConvert, Type type) {
            if (type == typeof(Int32)) {
                return new JsonPrimitive((int)objectToConvert);
            }
            else if (type == typeof(bool)) {
                return new JsonPrimitive((int)objectToConvert);
            }
            else {
                return new JsonPrimitive(objectToConvert.ToString());
            }
        }
    }
}
