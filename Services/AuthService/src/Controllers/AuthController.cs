using AuthService.Interfaces;
using AuthService.Requests;
using Database.Common.ContextProvider;
using Database.Common.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AuthService.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AuthController : Controller
    {
        private readonly IAuthorizationService _authorizationService;
        private readonly IContextProvider contextProvider;

        public AuthController(IAuthorizationService authorizationService, IContextProvider contextProvider)
        {
            this._authorizationService = authorizationService;
            this.contextProvider = contextProvider;
        }

        [HttpPost]
        public IActionResult LogIn([FromBody]LogInRequest value)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult GetAccessToken([FromBody]AccessTokenRequest value)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> Test()
        {
            using (var context = contextProvider.GetContext<TstModel>())
            {
                var a = await context.GetAll();
                var b = await context.GetSingle(x => x.Name == "Michael");
            }
                return Ok();
        }

    }
}
