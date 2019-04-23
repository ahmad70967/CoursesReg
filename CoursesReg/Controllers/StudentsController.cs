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
    public class StudentsController : Controller
    {
        private ApplicationDbContext _context;
        public StudentsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Students


        public ViewResult Listing()
        {
            var Student = _context.Students.Include(c => c.Major).ToList();
            return View(Student);

        }

        public ActionResult AddStudent()
        {
            var major = _context.Major.ToList();
            var Addmission = _context.AddmissionCode.ToList();
            var ViewModel = new NewStudentViewModel
            {
                Majors = major,
                AddmissionCodes = Addmission

            };
            return View(ViewModel);
        }

        [HttpPost]
        public ActionResult Add(Students student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return RedirectToAction("Listing","Students");
        }
    }
}