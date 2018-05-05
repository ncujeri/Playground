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

        public AuthController(IAuthorizationService authorizationService)
        {
            this._authorizationService = authorizationService;
        }

        [HttpPost]
        public async Task<IActionResult> LogIn([FromBody]LogInRequest request)
        {
            try
            {
                if (request == null) throw new ArgumentNullException();                
                var result = _authorizationService.LogIn(request);
                return Ok(await result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest();
                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public IActionResult GetAccessToken([FromBody]AccessTokenRequest value)
        {
            throw new NotImplementedException();
        }

        

    }
}
