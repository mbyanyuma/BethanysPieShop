using BethanysPieShop.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Data.DataAccess
{
    public class BethanyDbContext : IdentityDbContext<IdentityUser>
    {
        public BethanyDbContext(DbContextOptions<BethanyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
