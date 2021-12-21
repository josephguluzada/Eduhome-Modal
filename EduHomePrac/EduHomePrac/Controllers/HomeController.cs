using EduHomePrac.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomePrac.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Course> courses = _context.Courses.ToList();


            return View(courses);
        }

        public IActionResult Detail(int id)
        {
            Course course = _context.Courses.FirstOrDefault(x => x.Id == id);

            if (course == null) return NotFound();

            return PartialView("_CoursePartial", course);
        }


       
    }
}
