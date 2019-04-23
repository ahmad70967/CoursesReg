using CoursesReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoursesReg.ViewModels
{
    public class NewStudentViewModel
    {
        public IEnumerable<Major> Majors { get; set; }
        public IEnumerable<AddmissionCode> AddmissionCodes { get; set; }
        public Students Student { get; set; }
    }
}