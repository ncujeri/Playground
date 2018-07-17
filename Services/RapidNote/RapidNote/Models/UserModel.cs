using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RapidNote.Models.Abstract;

namespace RapidNote.Models
{
    public class UserModel : BaseModel
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }

        public override string GetKeyName()
        {
            return "User:";
        }
    }
}
