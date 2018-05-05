using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Common.ContextProvider;
using Database.Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
   
    [Route("api/[controller]/[action]")]
    public class TestController : Controller
    {
        private readonly IContextProvider _contextProvider;

        public TestController(IContextProvider contextProvider)
        {
            this._contextProvider = contextProvider;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<TstModel> result;
            using (var context = _contextProvider.GetContext<TstModel>())
            {
                 result = await context.GetAll();                
            }
            return Ok(result);
        }
    }
}