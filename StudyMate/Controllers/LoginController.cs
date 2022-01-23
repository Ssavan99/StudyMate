using Microsoft.AspNetCore.Mvc;
using StudyMate.Data;
using StudyMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static StudyMate.Controllers.DbHelper;

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
        public async Task<IActionResult> Login(Login Login)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var email = Login.UserEmail;
            var student = await queryStudent(_db, email);

            if (student == null)
            {
                ModelState.AddModelError("Email", "Invalid email or password");
                return this.View(Login);
            }

            if (student.PasswordHash == Login.PasswordHash)
            {
                var password = Login.PasswordHash;
                var studentHome = new Student();
                return RedirectToAction("Index", "Profile", studentHome);
            }
            else
            {
                ModelState.AddModelError("Email", "Invalid email or password");
                return this.View();
            }

            /*IActionResult result = View();
            if (ModelState.IsValid)
            {
                var student = _db.Students.Where(e => e.EmailId == Login.UserEmail).FirstOrDefault();
                if (student != null)
                {
                    result = RedirectToAction("~/Profile");
                } else
                {
                    Response.Redirect("");
                    ViewBag.Message = "User does not exist or password did not match.";
                }
            }*/

        }
    }
}
