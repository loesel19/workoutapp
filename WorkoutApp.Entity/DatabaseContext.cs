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
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Set> Sets { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
           /* modelBuilder.Entity<Category>().HasData(new Category
            {
                Name = "Chest", Id = 1, AddedBy = -1, DateAdded = DateTime.Now, DateUpdated = DateTime.Now, IsDeleted = false, UpdatedBy = -1
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Name = "Back", Id = 2, AddedBy = -1, DateAdded = DateTime.Now, DateUpdated = DateTime.Now, IsDeleted = false, UpdatedBy = -1
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Name = "Arms", Id = 3, AddedBy = -1, DateAdded = DateTime.Now, DateUpdated = DateTime.Now, IsDeleted = false, UpdatedBy = -1
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Name = "Legs", Id = 4, AddedBy = -1, DateAdded = DateTime.Now, DateUpdated = DateTime.Now, IsDeleted = false, UpdatedBy = -1
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Name = "Shoulders", Id = 5, AddedBy = -1, DateAdded = DateTime.Now, DateUpdated = DateTime.Now, IsDeleted = false, UpdatedBy = -1
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Name = "Abs", Id = 6, AddedBy = -1, DateAdded = DateTime.Now, DateUpdated = DateTime.Now, IsDeleted = false, UpdatedBy = -1
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise 
            { 
                Name = "Bench Press", Id = 1, CategoryId = 1, AddedBy = -1, DateAdded = DateTime.Now, DateUpdated = DateTime.Now, IsDeleted = false, UpdatedBy = -1
            });
            modelBuilder.Entity<Exercise>().HasData(new Exercise 
            { 
                Name = "Lateral Pull Down", Id = 2, CategoryId = 2, AddedBy = -1, DateAdded = DateTime.Now, DateUpdated = DateTime.Now, IsDeleted = false, UpdatedBy = -1
            });
            modelBuilder.Entity<Exercise>().HasData(new Exercise 
            { 
                Name = "Dumbbell Curls", Id = 3, CategoryId = 3, AddedBy = -1, DateAdded = DateTime.Now, DateUpdated = DateTime.Now, IsDeleted = false, UpdatedBy = -1
            });
            modelBuilder.Entity<Exercise>().HasData(new Exercise 
            { 
                Name = "Squat", Id = 4, CategoryId = 4, AddedBy = -1, DateAdded = DateTime.Now, DateUpdated = DateTime.Now, IsDeleted = false, UpdatedBy = -1
            });
            modelBuilder.Entity<Exercise>().HasData(new Exercise 
            { 
                Name = "Overhead Press", Id = 5, CategoryId = 5, AddedBy = -1, DateAdded = DateTime.Now, DateUpdated = DateTime.Now, IsDeleted = false, UpdatedBy = -1
            });
            modelBuilder.Entity<Exercise>().HasData(new Exercise 
            { 
                Name = "V-Ups", Id = 6, CategoryId = 6, AddedBy = -1, DateAdded = DateTime.Now, DateUpdated = DateTime.Now, IsDeleted = false, UpdatedBy = -1
            });*/
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
