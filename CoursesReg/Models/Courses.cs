using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CoursesReg.Models
{
    public class Courses
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        public string CourseName { get; set; }

        public byte Credits { get; set; }

        public Department Department { get; set; }
        public byte DepartmentId { get; set; }

    }
}