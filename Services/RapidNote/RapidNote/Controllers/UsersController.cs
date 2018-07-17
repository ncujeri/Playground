using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RapidNote.Commands;

namespace RapidNote.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody]RegisterUserCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
