using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workoutapp.Entity.Entities;

namespace Workoutapp.Entity
{
    public class WorkoutDbContext: DbContext
    {
        public WorkoutDbContext(DbContextOptions options): base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<User> AppUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Set>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<User>()
                .HasKey(c => c.Id);
        }


    }
}
