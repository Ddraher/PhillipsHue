using System;
using System.IO;
using System.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hue.Framework.Test {
    [TestClass]
    public class SimpleCommandsTest {
        [TestMethod]
        public void TestMethod() {
            HttpClient http = new HttpClient { Timeout = TimeSpan.FromMilliseconds(2000) };
            Task<string> repsonse =  http.GetStringAsync(new Uri("http://192.168.1.50/api"));
            
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(repsonse.Result));
            JsonValue value = JsonValue.Load(stream);

            value.ToString(JsonSaveOptions.None);
        }
    }
}
