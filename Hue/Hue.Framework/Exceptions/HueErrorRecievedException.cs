using System;
using Hue.Framework.Model.Response;

namespace Hue.Framework.Exceptions {
    public class HueErrorRecievedException : Exception {
        private Error error;

        public HueErrorRecievedException(Error error) : base(error.Description) {
            this.error = error;
        }

        public Error Error {
            get {
                return error;
            }
            set {
                error = value;
            }
        }
    }
}
