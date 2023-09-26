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
        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
               
        }
        public override int SaveChanges()
        {
            this.ChangeTracker.DetectChanges();
            var added = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Added)
                        .Select(t => t.Entity)
                        .ToArray();

            foreach (var entity in added)
            {
                if (entity is IEntity)
                {
                    var track = entity as IEntity;
                    track.DateAdded = DateTime.Now;
                    track.DateUpdated = DateTime.Now;
                }
            }

            var modified = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Modified)
                        .Select(t => t.Entity)
                        .ToArray();

            foreach (var entity in modified)
            {
                if (entity is IEntity)
                {
                    var track = entity as IEntity;
                    track.DateUpdated = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

    }

    
}
