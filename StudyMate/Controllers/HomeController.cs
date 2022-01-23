using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudyMate.Data;
using StudyMate.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    [HttpGet]
        public ActionResult Search(string searchString)
        {
            ActionResult actionResult = View();
            if (ModelState.IsValid)
            {
                //var newVendor = new SmiPIM.Database.Models.Vendor { Name = vendor.Name };
                bool containsInt = searchString.Any(char.IsDigit);
                if (!containsInt)
                {
                    List<Student> students =_db.Students.Where(s => s.Major == searchString).ToList();
                    Console.WriteLine(students);
                    if(students.Count == 0)
                    {
                        return NotFound();
                    }
                    return Ok(students);
                } else
                {
                    //find from classes table
                }

            }
            return View();
        }
    }
}
