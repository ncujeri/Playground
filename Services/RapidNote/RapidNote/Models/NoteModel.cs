using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RapidNote.Models.Abstract;

namespace RapidNote.Models
{
    public class NoteModel : BaseModel
    {
        

        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime ModificationTime { get; set; }

        public override string GetKeyName()
        {
            return "Note:";
        }
    }
}
