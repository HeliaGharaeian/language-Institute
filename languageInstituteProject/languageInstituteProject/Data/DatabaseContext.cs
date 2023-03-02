using languageInstituteProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System;

namespace languageInstituteProject.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                        .HasOne(p => p.classes)
            .WithOne(a => a.Teacher)
                        .HasForeignKey<Teacher>(a => a.ClassID);
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Class> classes { get; set; }
    }
}
