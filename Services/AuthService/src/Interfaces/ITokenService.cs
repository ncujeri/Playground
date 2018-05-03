using AuthService.Responses;
using SimpleJwtProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Interfaces
{
    public interface ITokenService
    {
        Token GetAccessToken(string userRole);
        Task<LogInResponse> LogIn(string userRole);
    }
}
