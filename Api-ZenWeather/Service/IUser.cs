using Api_ZenWeather.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api_ZenWeather.Service
{
    public interface IUser
    {
        Task<ActionResult<User>> AddUser(User newUser);
        Task<IActionResult> DeleteUser(long Id);
        Task<ActionResult<User>> GetUser();
        Task<IActionResult> UpdateUser(long Id, User UserActual);
    }
}
