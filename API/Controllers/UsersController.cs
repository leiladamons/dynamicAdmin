using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class UsersController: BaseController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            /*var users = await _context.Users.ToListAsync();
            return Ok(users);*/

            return Ok("Users many");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            /*return await _context.Users.FindAsync(id);*/
            return Ok("One User");
        }
        
        [HttpPost("new-user")]
        [AllowAnonymous]
        public async Task<ActionResult> Post(User user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            
            var existingUser = _context.Users.FirstOrDefault(u => u.Name == user.Name && u.Surname == user.Surname);

            if (existingUser != null)
            {
                return BadRequest("User exists");
            }
            
            //
            // If password field is empty we assume a default one.
            //
           // var effectivePassword = string.IsNullOrEmpty(user.Password) ? "12345678" : user.Password;

           var effectivePassword = "12345678";
            
            user.Password = BCrypt.Net.BCrypt.HashPassword(effectivePassword);

            user.Username = user.Name.ToLower() + "." + user.Surname.ToLower();
            
            var role = _context.Roles.FirstOrDefault(g => g.Id == user.Role.Id);
            user.Role = role;

            _context.Users.Add(user);
            
            if (await _context.SaveChangesAsync() == 0)
            {
                return BadRequest();
            }

            return Ok(user);
        }
    }
}