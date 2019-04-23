using CoursesReg.Models;
using CoursesReg.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace CoursesReg.Controllers
{
    public class EnrollmentController : Controller
    {
        private ApplicationDbContext _context;

        public EnrollmentController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Enrollment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EnrolleStudent()
        {
        var major = _context.Major.ToList();
        var student = _context.Students.ToList();
        var course = _context.Courses.ToList();

       var ViewModel = new NewEnrolleViewModel
        {
            Majors = major,
            Students=student,
            Courses=course
        };
            return View(ViewModel);
        
        }


        [HttpPost]
        public ActionResult Enrolle(Enrollment enrollment)
        {
            
            enrollment.PaymentIndicator = true;
            enrollment.EnrolledIndicator = true;
            _context.Enrollment.Add(enrollment);
            _context.SaveChanges();

            return RedirectToAction("Listing", "Enrollment");
        }

        public ActionResult Listing() {
            var enrolled = _context.Enrollment.Include(c => c.Course).Include(c => c.Major).Include(c => c.Student).ToList();
            return View(enrolled);
            
        }


    }
}