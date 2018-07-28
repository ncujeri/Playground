using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RapidNote.Commands.Abstract;
using RapidNote.Models;

namespace RapidNote.Commands
{
    public class AddNoteCommand : BaseCommand
    {
        public NoteModel Note { get; set; }
    }
}
