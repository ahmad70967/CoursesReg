using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CoursesReg.Models
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int TermCode { get; set; }

        public Students Student { get; set; }
        public byte StudentId { get; set; }

        public Courses Course { get; set; }
        public byte CourseId { get; set; }

        public Major Major { get; set; }
        public byte MajorId { get; set; }

        public int Grade { get; set; }

        public bool EnrolledIndicator { get; set; }

        public bool PaymentIndicator { get; set; }

    }
}