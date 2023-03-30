using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using ProjectIntrest.Interface.IImplement;
using ProjectIntrest.Interface.IInterface;
using ProjectIntrest.Model;

namespace ProjectIntrest.Api
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    { 
       private readonly IntrestDbContext _context;
        public UserController(IntrestDbContext context) { 
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Create(User users)
        {
            if (ModelState.IsValid)
            {
                await _context.AddAsync(users);
                await _context.SaveChangesAsync(); 
                return Ok();
            }

            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> Update( int userid , User users)
        {
            if(users.userId != userid)
            {
                return NotFound();
            }

         //   var _users = _context.Users.FindAsync(userid);
            
            if (ModelState.IsValid)
            {
                _context.Update(users);
                await _context.SaveChangesAsync();

                return Ok();
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<User> list = await _context.Users.ToListAsync();
           
            if (list == null)
            {
                return NotFound();
            }
            else
            {

                return Ok(list);
            }
            
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Getone(int userid)
        {
            var ActualUser = await _context.Users.FindAsync(userid);

            if (ActualUser == null)
            {
                return NotFound();
            }
            else
            {

                return Ok(ActualUser);
            }

            return NotFound();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int userid)
        {
            var ActualUser = await _context.Users.FindAsync(userid);

            if (ActualUser == null)
            {
                return NotFound();
            }
            else
            {

                _context.Remove(ActualUser);
                _context.SaveChanges();
                return Ok();
            }

            return NotFound();
        }




    }
}
