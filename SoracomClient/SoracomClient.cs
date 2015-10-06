using Newtonsoft.Json;
using Soracom.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Soracom
{
    public class SoracomClient
    {
        private readonly HttpClient Client;

        internal readonly Uri BaseUri = new Uri("https://api.soracom.io/v1/");

        public readonly AuthOperation Auth;

        public SoracomClient(HttpMessageHandler handler)
        {
            this.Client = new HttpClient(handler);

            this.Auth = new AuthOperation(this);
        }


        internal async Task<T> SendRequest<T>(HttpRequestMessage message) where T : class
        {
            HttpResponseMessage response = await this.Client.SendAsync(message, HttpCompletionOption.ResponseContentRead);

            string content = await response.Content.ReadAsStringAsync();

            T retval = null;
            if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 300)
            {
                //200系で返ってきたら指定された型でデシリアライズ
                retval = JsonConvert.DeserializeObject<T>(content);
            }
            else
            {

            }

            return retval;
        }

        internal StringContent ToStringContent(JsonObject obj)
        {
            return new StringContent(obj.ToString(), Encoding.UTF8, "application/json");
        }


    }
}
