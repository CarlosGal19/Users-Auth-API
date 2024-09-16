using Microsoft.EntityFrameworkCore;
using Users_Login_Api.Models;

namespace Users_Login_Api.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        { 
        }

        public DbSet<User> Users { get; set; }
    }
}
