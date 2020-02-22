using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }

        [Required(ErrorMessage = "Your course  is required")]
        [Display(Name = "Course Title")]
        [StringLength(150, ErrorMessage = "Your course name is too long")]
        public virtual string Title { get; set; }

        [Display(Name = "Description")]
        public virtual string CourseDescription { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Number of credits")]
        [Range(1,4, ErrorMessage = "Must be between 1 and 4")]
        public virtual int Credits { get; set; }
    }
}