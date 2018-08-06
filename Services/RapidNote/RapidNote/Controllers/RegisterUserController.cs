using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RapidNote.Commands;

namespace RapidNote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterUserController : Controller
    {
        private readonly IMediator _mediator;

        public RegisterUserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult RegisterUser()
        {
           throw new NotImplementedException();
        }
    }
}
