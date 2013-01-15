using System;
using Hue.Framework.Extensions.Attributes;

namespace Hue.Framework.Model.Response {
    [HuePropertyName("config")]
    public class BridgeConfiguration : HueReturnableBase {
        #region Private Properties

        private string name;
        private string mac;
        private bool hasDhcpAddress;
        private string ipAddress;
        private string netMask;
        private string gateway;
        private string proxyAddress;
        private int proxyPort;
        private DateTime utc;
        private string swversion;
        private bool linkButton;
        private bool portalServices;
        private SoftwareStatus softwareStatus;
        private DeviceList deviceList;

        #endregion

        #region Public properties

        [HuePropertyName("name")]
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        [HuePropertyName("mac")]
        public string Mac {
            get {
                return mac;
            }
            set {
                mac = value;
            }
        }

        [HuePropertyName("dhcp")]
        public bool HasDhcpAddress {
            get {
                return hasDhcpAddress;
            }
            set {
                hasDhcpAddress = value;
            }
        }

        [HuePropertyName("ipaddress")]
        public string IpAddress {
            get {
                return ipAddress;
            }
            set {
                ipAddress = value;
            }
        }

        [HuePropertyName("netmask")]
        public string NetMask {
            get {
                return netMask;
            }
            set {
                netMask = value;
            }
        }

        [HuePropertyName("gateway")]
        public string Gateway {
            get {
                return gateway;
            }
            set {
                gateway = value;
            }
        }

        [HuePropertyName("proxyaddress")]
        public string ProxyAddress {
            get {
                return proxyAddress;
            }
            set {
                proxyAddress = value;
            }
        }

        [HuePropertyName("proxyport")]
        public int ProxyPort {
            get {
                return proxyPort;
            }
            set {
                proxyPort = value;
            }
        }

        [HuePropertyName("UTC")]
        public DateTime Utc {
            get {
                return utc;
            }
            set {
                utc = value;
            }
        }

        [HuePropertyName("swversion")]
        public string Swversion {
            get { return swversion; }
            set { swversion = value; }
        }

        [HuePropertyName("linkbutton")]
        public bool LinkButton {
            get {
                return linkButton;
            }
            set {
                linkButton = value;
            }
        }

        [HuePropertyName("portalservices")]
        public bool PortalServices {
            get {
                return portalServices;
            }
            set {
                portalServices = value;
            }
        }

        public SoftwareStatus SoftwareStatus {
            get {
                return softwareStatus;
            }
            set {
                softwareStatus = value;
            }
        }

        public DeviceList DeviceList {
            get {
                return deviceList;
            }
            set {
                deviceList = value;
            }
        }

        #endregion
    }
}
