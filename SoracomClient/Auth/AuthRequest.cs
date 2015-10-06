using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soracom.Auth
{
    /// <summary>
    /// 
    /// </summary>
    public class AuthRequest: JsonObject
    {
        public string email { get; set; }
        public string password { get; set; }
        public int tokenTimeoutSeconds { get; set; }

    }
}
