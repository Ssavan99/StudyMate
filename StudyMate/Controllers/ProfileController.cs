using Microsoft.AspNetCore.Mvc;
using StudyMate.Data;
using StudyMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Controllers
{
    public class ProfileController : Controller
    {
        private AppDbContext _db;

        public ProfileController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(Student student)
        {
            return View(student);
        }
    }
}
