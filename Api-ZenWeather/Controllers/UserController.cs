using Api_ZenWeather.Model;
using Api_ZenWeather.Service;
using Microsoft.AspNetCore.Mvc;

namespace Api_ZenWeather.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller, IUser
    {
        public Task<ActionResult<User>> AddUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> DeleteUser(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<User>> GetUser()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateUser(long Id, User UserActual)
        {
            throw new NotImplementedException();
        }
    }
}
