using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class RegisterViewModel
    {
        [Required,MinLength(3),MaxLength(30)]
        public string Name { get; set; }
        [Required, MinLength(3), MaxLength(40)]
        public string Surname { get; set; }
        [Required, MinLength(3), MaxLength(30)]
        public string FatherName { get; set; }
        [Required, EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, MinLength(8), MaxLength(14)]
        public string PhoneNumber { get; set; }
        [Required,MinLength(8),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, MinLength(8), DataType(DataType.Password),Compare(nameof(Password))]
        public string RepeatPassword { get; set; }
    }
}
