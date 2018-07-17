using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RapidNote.Models;

namespace RapidNote.Commands
{
    public class UdateNoteCommand
    {
        public int NoteId { get; set; }
        public NoteModel Note { get; set; }
    }
}
