using AuthService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Services
{
    public class PasswordValidator : IPasswordValidator
    {

        public bool ValidatePassword(string password, string passwordHash, string salt)
        {
            throw new NotImplementedException();
        }
    }
}
