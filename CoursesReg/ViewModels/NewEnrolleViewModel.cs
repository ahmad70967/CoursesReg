using CoursesReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoursesReg.ViewModels
{
    public class NewEnrolleViewModel
    {
        public IEnumerable<Major> Majors { get; set; }
        public IEnumerable<Students> Students { get; set; }
        public IEnumerable<Courses> Courses { get; set; }
        public Enrollment Enrollment { get; set; }
    }
}