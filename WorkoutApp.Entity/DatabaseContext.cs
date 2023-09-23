using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.Entity.Entities;

namespace WorkoutApp.Entity
{
    public class DatabaseContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Set> Sets { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        
        
    }

    
}
