using Microsoft.EntityFrameworkCore;
using StudyMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace StudyMate.Data
{
    public class AppDbContext: DbContext
    {
        private string connectionString;
        public AppDbContext(DbContextOptions options) :
           base(options)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);

            var configuration = builder.Build();

            connectionString = configuration.GetConnectionString("StudyMate");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<RequestReceived> RequestReceived { get; set; }

        public DbSet<RequestSent> RequestSent { get; set; }

        public DbSet<Login> Logins { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentClass>().HasKey(sc => new { sc.StudentId, sc.ClassId });

            modelBuilder.Entity<RequestSent>().HasKey(rs => new {rs.StudentId});
            modelBuilder.Entity<RequestReceived>().HasKey(rr => new { rr.StudentId });
        }
    }
}
