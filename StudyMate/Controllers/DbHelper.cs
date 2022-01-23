using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudyMate.Data;
using StudyMate.Models;

namespace StudyMate.Controllers
{
    public class DbHelper
    {
        public static async Task<Student> queryStudent(AppDbContext context, string email)
        {
            return await context.Students.Where(s => s.EmailId == email).FirstOrDefaultAsync();
        }
    }
}
