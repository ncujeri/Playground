using AuthService.Interfaces;
using Database.Common.ContextProvider;
using Database.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IContextProvider _contextProvider;

        public UsersRepository(IContextProvider contextProvider)
        {
            this._contextProvider = contextProvider;
        }
        

        public async Task<UserModel> GetUserByLogin(string login)
        {
            try
            {
                using (var context = _contextProvider.GetContext<UserModel>())
                {
                    return await context.GetSingle(x => x.UserLogin == login);
                }
            }
            catch (Exception ex)
            {
                //Log exception
                throw new ArgumentException("User not found");                
            }
            
        }
    }
}
