using CoursesReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoursesReg.ViewModels
{
    public class NewCourseViewModel
    {
        public IEnumerable<Department> Department { get; set; }
        public Courses Course { get; set; }
    }
}