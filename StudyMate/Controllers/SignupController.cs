using Microsoft.AspNetCore.Mvc;
using StudyMate.Data;
using StudyMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Controllers
{
    public class SignupController : Controller
    {
        private AppDbContext _db;
        public IActionResult Index()
        {
            return View();
        }
        public SignupController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Signup(Student Student)
        {
            
            if (ModelState.IsValid)
            {
                //var newVendor = new SmiPIM.Database.Models.Vendor { Name = vendor.Name };
                var newStudent = new Student { Name = Student.Name, EmailId = Student.EmailId, Major = Student.Major, PasswordHash = Student.PasswordHash };
                _db.Add(newStudent);
                _db.SaveChanges();
            }
            return RedirectToAction("index", "profile", Student);
        }
    }
}
