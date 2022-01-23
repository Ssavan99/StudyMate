using Microsoft.AspNetCore.Mvc;
using StudyMate.Data;
using StudyMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Controllers
{
    public class LoginController : Controller
    {
        private AppDbContext _db;

        public IActionResult Index()
        {
            return View();
        }
        public LoginController(AppDbContext db)
        {
            _db = db;
        }
        public ActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login Login)
        {
            IActionResult result = View();
            if (ModelState.IsValid)
            {
                var student = _db.Students.Where(l => l.EmailId == Login.UserEmail).FirstOrDefault<Student>();
                if (student != null)
                {
                    result = RedirectToAction("index", "profile", student);
                } else
                {
                    Response.Redirect("");
                    ViewBag.Message = "User does not exist or password did not match.";
                }
            }
            return result;
        }
    }
}
