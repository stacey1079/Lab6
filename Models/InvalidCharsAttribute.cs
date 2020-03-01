using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        readonly int minLetters;
        public InvalidCharsAttribute(int minLetters)
        {
            this.minLetters = minLetters;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsString = value.ToString();
                if (valueAsString.Split(' ').Length > minLetters)
                {
                    return new ValidationResult("Error! Not enough letters");
                }
            }
            return ValidationResult.Success;
        }
    }
}