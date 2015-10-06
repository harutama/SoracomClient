using Newtonsoft.Json;
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
        internal readonly Uri BaseUri = new Uri("https://api.soracom.io/v1");



        internal async Task<T> SendRequest<T>(HttpRequestMessage message) where T : class
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(message, HttpCompletionOption.ResponseContentRead);

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
    }
}
