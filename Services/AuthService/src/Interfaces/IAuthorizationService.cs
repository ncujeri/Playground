using AuthService.Requests;
using AuthService.Responses;
using SimpleJwtProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Interfaces
{
    public interface IAuthorizationService
    {
        Task<LogInResponse> LogIn(LogInRequest request);
        AccessToken RefreshAccessToken(AccessTokenRequest request);
    }
}
