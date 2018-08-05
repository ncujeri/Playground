using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RapidNote.Commands;

namespace RapidNote.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeleteNoteController : Controller
    {
        private readonly IMediator _mediator;

        public DeleteNoteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public IActionResult DeleteNote([FromBody] DeleteNoteCommand command)
        {
            throw new NotImplementedException();
        }

    }
}