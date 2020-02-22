using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }

        [Required(ErrorMessage = "You must enter a grade")]
        [RegularExpression(@"A-F", ErrorMessage ="Invalid grade input")]
        public virtual string Grade { get; set; }
        public virtual string Student { get; set; }
        public virtual Course Course { get; set; }
        public virtual bool IsActive { get; set; }

        [Required(ErrorMessage = "You must enter assigned campus")]
        [Display(Name = "Assigned Campus")]
        public virtual string AssignedCampus { get; set; }

        [Required(ErrorMessage = "You must enter enrollment semester")]
        [Display(Name = "Enrolled in semester")]
        public virtual string EnrollmentSemester { get; set; }

        [Required(ErrorMessage = "You must enter enrollment year")]
        [Range(2018, 3000, ErrorMessage = "Must be enrolled after 2018")]
        public virtual int EnrollmentYear { get; set; }
    }
}