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

        public TokenService(IAccessTokenProvider accessTokenProvider, IRefreshTokenProvider refreshTokenProvider)
        {
            this._accessTokenProvider = accessTokenProvider;
            this._refreshTokenProvider = refreshTokenProvider;
        }
        public Token GetAccessToken(string userRole)
        {
            throw new NotImplementedException();
        }

        public Task<LogInResponse> LogIn(string userRole)
        {
            throw new NotImplementedException();
        }
    }
}
