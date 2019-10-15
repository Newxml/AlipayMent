using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.UI;
using Essensoft.AspNetCore.Payment.Alipay;
using Essensoft.AspNetCore.Payment.Alipay.Request;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace JxStudioAPICenter.Alipay
{
    public class AlipayManager:IAlipayManager
    {
        private readonly IAlipayClient _alipayClient;
        private readonly IAlipayNotifyClient _alipayNotifyClient;

        public AlipayManager(IAlipayClient alipayClient,
            IAlipayNotifyClient alipayNotifyClient
         )
        {
            _alipayClient = alipayClient;
            _alipayNotifyClient = alipayNotifyClient;
            
        }
        /// <summary>
        /// 获取会员基础信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<AuthDto> GetAuthAsync(string code)
        {
    
            var options = new AlipayOptions();
            options.AppId = "";
            options.AppPrivateKey = "";
            options.AlipayPublicKey = "";
            var req = new AlipaySystemOauthTokenRequest()
            {
                Code = code,
                RefreshToken = "",
                GrantType = "authorization_code"
            };

            AlipaySystemOauthTokenResponse response = await _alipayClient.ExecuteAsync(req, options);

            if (response.IsError)
            {
                throw new UserFriendlyException(response.SubMsg);
            }

            var dto = new AuthDto();
            dto.AccessToken = response.AccessToken;
            dto.AuthTokenType = response.AuthTokenType;
            dto.ExpiresIn = response.ExpiresIn;
            dto.ReExpiresIn = response.ReExpiresIn;
            dto.RefreshToken = response.RefreshToken;
            dto.UserId = response.UserId;
            return dto;
        }
    }
}
