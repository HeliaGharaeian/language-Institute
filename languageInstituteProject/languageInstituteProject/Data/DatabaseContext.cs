using languageInstituteProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace languageInstituteProject.Data
{
    public class DatabaseContext :DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) 
        {
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Class> classes { get; set; }
    }
}
