using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class LoginController: BaseController
    {
        private readonly DataContext _context;
        public LoginController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(string username, string password)
        {
            using var hmac = new HMACSHA512();

            var user = new User
            {
                Username = username,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                PasswordSalt = hmac.Key
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}