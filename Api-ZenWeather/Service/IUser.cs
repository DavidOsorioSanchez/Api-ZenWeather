using Api_ZenWeather.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api_ZenWeather.Service
{
    public interface IUser
    {
        Task<ActionResult<User>> AddUser(User newUser);
        Task<IActionResult> DeleteUser(Guid Id);
        Task<ActionResult<User>> GetUser(Guid Id);
        Task<IActionResult> UpdateUser(Guid Id, User UserActual);
    }
}
