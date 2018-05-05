using AuthService.Configurations;
using AuthService.Interfaces;
using AuthService.Responses;
using SimpleJwtProvider.Interfaces;
using SimpleJwtProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Services
{
    public class TokenService : ITokenService
    {
        
        private readonly IAccessTokenProvider _accessTokenProvider;
        private readonly IRefreshTokenProvider _refreshTokenProvider;
        private readonly TokensConfiguration _config;
        private readonly Dictionary<string, object> _claims;

        public TokenService(IAccessTokenProvider accessTokenProvider, IRefreshTokenProvider refreshTokenProvider, TokensConfiguration config)
        {
            this._accessTokenProvider = accessTokenProvider;
            this._refreshTokenProvider = refreshTokenProvider;
            this._config = config;
            this._claims = ConfigureClaims();
        }
        public Token GetAccessToken(string userRole)
        {
            throw new NotImplementedException();
        }

        public async Task<LogInResponse> LogIn(string userRole)
        {
            var refreshToken = _refreshTokenProvider.GetRefreshToken(DateTime.Now.AddHours(_config.RefreshTokenExpHours));
            
            _claims.Add("role", userRole);

            var accesToken = _accessTokenProvider.GetAccessToken(DateTime.Now.AddMinutes(_config.AccessTokenExpMinutes), _claims);

            return new LogInResponse()
            {
                AccessToken = accesToken,
                RefreshToken = await refreshToken
            };            
        }

        private Dictionary<string, object> ConfigureClaims()
        {
            var claims = new Dictionary<string, object>();

            claims.Add("iss", "DemoAuthorizationService");

            return claims;

        }
    }
}
