using System;

namespace Hue.Framework.Model {
    public class Bridge {
        private Uri uri;
        private string deviceUserName;
        private string deviceType;

        public Uri UriRoot {
            get {
                return uri;
            }
            set {
                uri = value;
            }
        }

        public string DeviceUserName {
            get {
                return deviceUserName;
            }
            set {
                deviceUserName = value;
            }
        }

        public string DeviceType {
            get {
                return deviceType;
            }
            set {
                deviceType = value;
            }
        }

        public Uri ApiUri {
            get {
                return new Uri(UriRoot + "api");
            }
        }

        public Uri FullUri {
            get {
                return new Uri(ApiUri + "/" + DeviceUserName);
            }
        }

        public Bridge(string bridgeUrl, string deviceUserName) {
            this.uri = new Uri(bridgeUrl);
            this.deviceUserName = deviceUserName;
            this.deviceType = deviceUserName;
        }

        public Bridge(Uri bridgeUri, string deviceUserName) {
            this.uri = bridgeUri;
            this.deviceUserName = deviceUserName;
            this.deviceType = deviceUserName;
        }

        public Bridge(string bridgeUrl, string deviceUserName, string deviceType) {
            this.uri = new Uri(bridgeUrl);
            this.deviceUserName = deviceUserName;
            this.deviceType = deviceType;
        }

        public Bridge(Uri bridgeUri, string deviceUserName, string deviceType) {
            this.uri = bridgeUri;
            this.deviceUserName = deviceUserName;
            this.deviceType = deviceType;
        }
    }
}
