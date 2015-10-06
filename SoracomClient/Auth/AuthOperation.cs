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

        /// <summary>
        /// /auth<br/>
        /// Operator の認証を行う。<br/>
        /// 認証が成功した場合、API キー、オペレータ ID、 Token が返却される。<br/>
        /// 認証が必要なAPIのリクエストには API キーと Token をヘッダーに付与する必要がある。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthResponse> Auth(AuthRequest request)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, new Uri(parent.BaseUri, "auth"));
            message.Content = parent.ToStringContent(request);

            AuthResponse response = await this.parent.SendRequest<AuthResponse>(message);

            return response;
        }

    }
}
