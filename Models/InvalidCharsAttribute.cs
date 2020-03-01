using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        public InvalidCharsAttribute()
        {
            //_minLetters = minLetters;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsString = value.ToString();
                if (valueAsString.Split(' ').Length > 20)
                {
                    return new ValidationResult("Not enough letters");
                }
            }
            return ValidationResult.Success;
        }
    }
}