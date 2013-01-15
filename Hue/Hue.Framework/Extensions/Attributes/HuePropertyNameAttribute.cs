using System;

namespace Hue.Framework.Extensions.Attributes {
    [AttributeUsage(AttributeTargets.All)]
    public class HuePropertyNameAttribute : Attribute {
        private readonly string propertyName;

        public string PropertyName {
            get {
                return propertyName;
            }
        }

        public HuePropertyNameAttribute(string propertyName) {
            this.propertyName = propertyName;
        }
    }
}
