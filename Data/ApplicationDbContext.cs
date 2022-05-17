using AutoSchool.Models.Tables;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSchool.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public new DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            /*Database.EnsureDeleted();*/
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(u => u.Student).WithOne(u => u.User);
            modelBuilder.Entity<User>().HasOne(t => t.Teacher).WithOne(u => u.User);

            modelBuilder.Entity<Course>().HasOne(t => t.Teacher).WithMany(c => c.Courses);
            modelBuilder.Entity<Course>().HasMany(s => s.Students).WithMany(c => c.Courses);


            base.OnModelCreating(modelBuilder);
        }
    }
}
