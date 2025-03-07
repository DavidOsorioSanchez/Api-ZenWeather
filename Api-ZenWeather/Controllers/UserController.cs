using Api_ZenWeather.Data;
using Api_ZenWeather.Model;
using Api_ZenWeather.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_ZenWeather.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller, IUser
    {
        private readonly UserDBContext _dbContext;

        public UserController(UserDBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User newUser)
        {
            if (newUser is null)
                return BadRequest();

            _dbContext.userdb.Add(newUser);
            await _dbContext.SaveChangesAsync();
            return Ok(newUser);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteUser(Guid Id)
        {
            var user = await _dbContext.userdb.FindAsync(Id);
            if (user is null)
                return NotFound();

            _dbContext.userdb.Remove(user);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<User>> GetUser(Guid Id)
        {
            var user = await _dbContext.userdb.FindAsync(Id);
            if (user is null)
                return NotFound();
            return Ok(user);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateUser(Guid Id, User UserActual)
        {
            var user = await _dbContext.userdb.FindAsync(Id);
            if (user is null)
                return NotFound();


            user.Location = UserActual.Location;
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
