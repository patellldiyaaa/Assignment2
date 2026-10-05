using Assignment2.Data;
using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment2.Controllers
{
    //Diya Patel
    public class HomeController : Controller
    {
        private readonly Assignment2Context _context;

        public HomeController(Assignment2Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();

            return View(students);
        }

        [Route("courses")]
        public IActionResult Courses()
        {
            var courses = _context.Courses.ToList();

            return View(courses);
        }
    }
}
