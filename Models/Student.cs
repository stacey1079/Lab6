using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models 
{
    public class Student : IValidatableObject
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

        public virtual string Address1 { get; set; }

        public virtual string Address2 { get; set; }

        public virtual string City { get; set; }

        public virtual string Zipcode { get; set; }

        public virtual string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Validation 1:
            if(Address2.Equals(Address1))
            {
                yield return (new ValidationResult("Address2 cannot be the same as Address1"));
            }
            if(State.Length < 2 || State.Length > 2 )
            {
                yield return (new ValidationResult("Enter a 2 digit State code"));
            }
            if(Zipcode.Length < 5 || Zipcode.Length > 5)
            {
                yield return (new ValidationResult("Enter a 5 digit Zipcode"));
            }


            throw new NotImplementedException();
        }
    }
}