using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soracom.Auth
{
    public class AuthResponse : JsonObject
    {



        public string apiKey { get; set; }
        public string operatorId { get; set; }
        public string token { get; set; }
    }
}
