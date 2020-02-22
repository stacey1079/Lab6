using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        [Display(Name ="Student ID")]
        public virtual int StudentId { get; set; }

        [Required(ErrorMessage ="Your last name  is required")]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage ="Your name is too long")]
        public virtual string LastName { get; set; }

        [Required(ErrorMessage = "Your last name  is required")]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "Your name is too long")]
        public virtual string FirstName { get; set; }
    }
}