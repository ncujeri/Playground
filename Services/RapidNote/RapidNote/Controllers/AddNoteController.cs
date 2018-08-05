using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RapidNote.Commands;

namespace RapidNote.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddNoteController : Controller
    {
        private readonly IMediator _mediator;

        public AddNoteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public IActionResult AddNote([FromBody] AddNoteCommand command)
        {
            throw new NotImplementedException();
        }

    }
}