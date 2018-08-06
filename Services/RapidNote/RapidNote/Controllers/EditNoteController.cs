using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RapidNote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditNoteController : Controller
    {
        private readonly IMediator _mediator;

        public EditNoteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult EditNote()
        {
            throw new NotImplementedException();
        }
    }
}