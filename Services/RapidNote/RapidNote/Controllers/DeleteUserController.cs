using System;
using Microsoft.AspNetCore.Mvc;

namespace RapidNote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteUserController : Controller
    {
        [HttpDelete]
        public IActionResult DeleteUser()
        {
            throw new NotImplementedException();
        }
    }
}