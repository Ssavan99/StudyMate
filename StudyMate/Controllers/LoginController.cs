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

        [HttpPost]
        public IActionResult Login(Login Login)
        {
            IActionResult result = View();
            if (ModelState.IsValid)
            {
                var student = _db.Logins.Where(l => l.UserEmail == Login.UserEmail && l.PasswordHash == Login.PasswordHash).FirstOrDefault();
                if (student != null)
                {
                    result = RedirectToAction("Profile");
                } else
                {
                    ViewBag.Message = "User does not exist or password did not match.";
                }
            }
            return result;
        }
    }
}
