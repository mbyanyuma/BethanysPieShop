using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class PieDbContext : DbContext
    {
        public PieDbContext(DbContextOptions<PieDbContext> options) : base(options)
        {
            
        }

        public DbSet<Pie> Pies { get; set; }
    }
}
