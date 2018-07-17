using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RapidNote.Commands;

namespace RapidNote.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NotesController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> AddNote([FromBody] AddNoteCommand command)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetTop(int notesCount)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int noteId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody]UdateNoteCommand command)
        {
            throw new NotImplementedException();
        }

    }
}