using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soracom
{
    public class JsonObject
    {

        public override string ToString()
        {
            //どうにかこうにかしたい場合はここを参照
            //http://www.newtonsoft.com/json/help/html/Samples.htm
            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.NullValueHandling = NullValueHandling.Ignore;

            return JsonConvert.SerializeObject(this, setting);
        }

    }
}
