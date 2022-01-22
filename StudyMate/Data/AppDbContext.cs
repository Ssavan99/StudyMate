using Microsoft.EntityFrameworkCore;
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
        public DbSet<User> Users { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Message> Message { get; set; }
    }
}
