using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Soracom.Auth
{
    public class AuthOperation
    {
        private readonly SoracomClient parent;

        public AuthOperation(SoracomClient parent)
        {
            this.parent = parent;
        }


        public async Task<AuthResponse> Auth(AuthRequest request)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, new Uri(parent.BaseUri, "auth"));
            message.Content = new StringContent(request.ToString(), Encoding.UTF8, "application/json");

            AuthResponse response = await this.parent.SendRequest<AuthResponse>(message);

            return response;
        }

    }
}
