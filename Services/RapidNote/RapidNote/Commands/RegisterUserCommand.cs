using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RapidNote.Models;

namespace RapidNote.Commands
{
    public class RegisterUserCommand
    {
        public UserModel User { get; set; }
    }
}
