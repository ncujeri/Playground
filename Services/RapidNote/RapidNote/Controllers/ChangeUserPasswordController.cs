using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RapidNote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangeUserPasswordController : Controller
    {
        private readonly IMediator _mediator;

        public ChangeUserPasswordController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult ChangeUserPassword()
        {
            throw new NotImplementedException();
        }
    }
}