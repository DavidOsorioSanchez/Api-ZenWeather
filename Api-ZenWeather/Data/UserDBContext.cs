using Api_ZenWeather.Model;
using Microsoft.EntityFrameworkCore;

namespace Api_ZenWeather.Data
{
    public sealed class UserDBContext(DbContextOptions<UserDBContext> options)
        : DbContext(options)
    {
        public DbSet<User> userdb { get; set; }
    }
}
