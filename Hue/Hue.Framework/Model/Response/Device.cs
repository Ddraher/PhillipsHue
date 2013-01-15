using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hue.Framework.Extensions.Attributes;

namespace Hue.Framework.Model.Response {
    public class Device : HueReturnableBase {
        private string lastUseDate;
        private string createDate;
        private string name;

        public readonly string UserName;

        [HuePropertyName("last use date")]
        public string LastUseDate {
            get { return lastUseDate; }
            set { lastUseDate = value; }
        }

        [HuePropertyName("create date")]
        public string CreateDate {
            get { return createDate; }
            set { createDate = value; }
        }

        [HuePropertyName("name")]
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public Device(string userName) {
            UserName = userName;
        }
    }
}
