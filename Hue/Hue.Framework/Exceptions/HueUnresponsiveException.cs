using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hue.Framework.Exceptions {
    public class HueUnresponsiveException : Exception {
        public HueUnresponsiveException(Uri hueUri)
            : base("Hue basestation unresponsive at : " + hueUri) { }
    }
}
