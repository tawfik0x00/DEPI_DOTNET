using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Task1.Models;
using Task1.Configurations;

namespace Task1.Context
{
    public class SchoolDbContext: DbContext
    {
        public DbSet<Student>  Students {get; set;}
        public DbSet<Teacher> Teachers {get; set;}
        public DbSet<Department> Departments {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SchoolDb2;User Id=sa;Password=Mm7302002#@!;Encrypt=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TeacherDepartmentConfiguration());
        }
    }
}