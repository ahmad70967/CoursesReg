using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CoursesReg.Models
{
    public class Students
    {

        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [Required]
        [StringLength(60)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(60)]
        public string LastName { get; set; }

        public AddmissionCode AddmissionCode { get; set; }

        [Display(Name = "Addmission Code")]
        [Required]
        public int AdmissionTermCode { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        public Major Major { get; set; }

        [Display(Name ="Major")]
        public byte MajorId { get; set; }
    }
}