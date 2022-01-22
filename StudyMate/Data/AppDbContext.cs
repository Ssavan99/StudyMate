using Microsoft.EntityFrameworkCore;
using StudyMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) :
           base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Message> Messages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentClass>().HasKey(sc => new { sc.StudentId, sc.ClassId });
        }
    }
}
