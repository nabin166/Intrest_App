using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectIntrest.Interface.IImplement;
using ProjectIntrest.Interface.IInterface;

namespace ProjectIntrest.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IntrestDbContext intrestDbContext;
        public UserController(IntrestDbContext intrestDbContext) 
        {
            this.intrestDbContext = intrestDbContext;
        }

        public IActionResult Create(User users)
        {

            //   intrestDbContext.Add(users);
           return RedirectToAction("Index");

            
        }
    }
}
