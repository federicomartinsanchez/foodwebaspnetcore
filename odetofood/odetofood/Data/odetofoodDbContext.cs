using Microsoft.EntityFrameworkCore;
using odetofood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace odetofood.Data
{
    public class odetofoodDbContext : DbContext
    {
        public odetofoodDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
