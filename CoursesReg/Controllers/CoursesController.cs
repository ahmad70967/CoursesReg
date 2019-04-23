using CoursesReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CoursesReg.ViewModels;

namespace CoursesReg.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext _context;
        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Listing()
        {
            var Course = _context.Courses.Include(c => c.Department).ToList();
            return View(Course);
        }

        public ActionResult AddCourse()
        {
            var Department = _context.Department.ToList();
            var ViewModel = new NewCourseViewModel
            {
                Department=Department
            };
            return View(ViewModel);
        }

        [HttpPost]
        public ActionResult Add(Courses course)
        {
           
            _context.Courses.Add(course);
            _context.SaveChanges();

            return RedirectToAction("Listing", "Courses");
        }


    }
}