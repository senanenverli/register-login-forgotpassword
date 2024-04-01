using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5.Database
{
    public class NestDbContext : IdentityDbContext
    {
        public NestDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Shipping>? Shippings { get; set; }
        public DbSet<AppUser>? AppUsers { get; set; }


    }
}
