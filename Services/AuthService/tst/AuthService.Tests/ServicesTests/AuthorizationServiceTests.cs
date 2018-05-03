using AuthService.Interfaces;
using AuthService.Requests;
using AuthService.Responses;
using AuthService.Services;
using Database.Common.ContextProvider;
using Database.Common.Models;
using Moq;
using SimpleJwtProvider.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AuthService.Tests.ServicesTests
{
    public class AuthorizationServiceTests
    {
        [Fact]
        public void LogIn_ThrowsArgumentNullException_RequestIsNull()
        {
            var usersRepositoryMock = new Mock<IUsersRepository>();
            var passwordValidatorMock = new Mock<IPasswordValidator>();
            var tokenServiceMock = new Mock<ITokenService>();

            var authorizationService = new AuthorizationService(usersRepositoryMock.Object, passwordValidatorMock.Object, tokenServiceMock.Object);

            Assert.ThrowsAsync<ArgumentNullException>(() => authorizationService.LogIn(null));
            
        }
        [Fact]
        public async void LogIn_Invokes_GetUserByLogin()
        {
            
            var usersRepositoryMock = new Mock<IUsersRepository>();
            usersRepositoryMock.Setup(x => x.GetUserByLogin(It.IsAny<string>())).Returns(Task.FromResult(new UserModel()));

            var passwordValidatorMock = new Mock<IPasswordValidator>();
            passwordValidatorMock.Setup(x => x.ValidatePassword(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var tokenServiceMock = new Mock<ITokenService>();

            var request = new LogInRequest();

            var authorizationService = new AuthorizationService(usersRepositoryMock.Object, passwordValidatorMock.Object, tokenServiceMock.Object);

            await authorizationService.LogIn(request);

            usersRepositoryMock.Verify(x => x.GetUserByLogin(It.IsAny<string>()), Times.Once);
        }


        [Fact]
        public async void LogIn_InvokesIPasswordValidator_ValidatePassword()
        {

            var usersRepositoryMock = new Mock<IUsersRepository>();
            usersRepositoryMock.Setup(x => x.GetUserByLogin(It.IsAny<string>())).Returns(Task.FromResult(new UserModel()));

            var passwordValidatorMock = new Mock<IPasswordValidator>();
            passwordValidatorMock.Setup(x => x.ValidatePassword(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var tokenServiceMock = new Mock<ITokenService>();

            var request = new LogInRequest();

            var authorizationService = new AuthorizationService(usersRepositoryMock.Object, passwordValidatorMock.Object, tokenServiceMock.Object);
            
            await authorizationService.LogIn(request);

            passwordValidatorMock.Verify(x => x.ValidatePassword(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);

        }

    }
}
