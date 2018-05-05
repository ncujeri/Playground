using AuthService.Interfaces;
using AuthService.Requests;
using AuthService.Responses;
using Database.Common.ContextProvider;
using Database.Common.Models;
using SimpleJwtProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IPasswordValidator _passwordValidator;
        private readonly ITokenService _tokenService;

        public AuthorizationService(IUsersRepository usersRepository, IPasswordValidator passwordValidator, ITokenService tokenService)
        {

            this._usersRepository = usersRepository;
            this._passwordValidator = passwordValidator;
            this._tokenService = tokenService;
        }
        public async Task<LogInResponse> LogIn(LogInRequest request)
        {
            
            if (string.IsNullOrEmpty(request.Login)) throw new ArgumentException();
            if (string.IsNullOrEmpty(request.Password)) throw new ArgumentException();

            var user = await _usersRepository.GetUserByLogin(request.Login);

            if (_passwordValidator.ValidatePassword(request.Password, user.Password, user.Salt))
            {
                return await _tokenService.LogIn(user.Role);
            }

            throw new ArgumentException("Invalid username or password");

        }

        public AccessToken RefreshAccessToken(AccessTokenRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
