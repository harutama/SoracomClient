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
            return JsonConvert.SerializeObject(this);
        }

    }
}
