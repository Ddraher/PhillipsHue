using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Hue.Framework.Exceptions;

namespace Hue.Framework {
    public static class HttpHelper {
        public static async Task<string> GetAsync(Uri uri) {
            try {
                using (HttpClient client = new HttpClient()) {
                    HttpResponseMessage result = await client.GetAsync(uri, HttpCompletionOption.ResponseContentRead).ConfigureAwait(false);

                    return await ParseMessageAsync(result);
                }
            }
            catch (HttpRequestException) {
                throw new HueUnresponsiveException(uri);
            }
        }

        public static async Task<string> PostAsync(Uri uri, string content) {
            StringContent stringContent = new StringContent(content, Encoding.UTF8, "application/json");

            try {
                using (HttpClient client = new HttpClient()) {
                    HttpResponseMessage result = await client.PostAsync(uri, stringContent).ConfigureAwait(false);

                    return await ParseMessageAsync(result);
                }
            }
            catch (HttpRequestException) {
                throw new HueUnresponsiveException(uri);
            }
        }

        public static async Task<string> PutAsync(Uri uri, string content) {
            try {
                StringContent stringContent = new StringContent(content, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient()) {
                    HttpResponseMessage result = await client.PutAsync(uri, stringContent).ConfigureAwait(false);

                    return await ParseMessageAsync(result);
                }
            }
            catch (HttpRequestException) {
                throw new HueUnresponsiveException(uri);
            }
        }

        public static async Task<string> ParseMessageAsync(HttpResponseMessage message) {
            if (message.IsSuccessStatusCode) {
                string response = await message.Content.ReadAsStringAsync().ConfigureAwait(false);

                return response;
            }

            return string.Empty;
        }
    }
}
