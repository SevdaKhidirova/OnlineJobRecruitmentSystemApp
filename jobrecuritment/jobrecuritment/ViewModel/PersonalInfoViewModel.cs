using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class PersonalInfoViewModel
    {
        [Required, MinLength(3), MaxLength(30)]
        public string Name { get; set; }
        [Required, MinLength(3), MaxLength(40)]
        public string Surname { get; set; }
        [Required, MinLength(3), MaxLength(30)]
        public string FatherName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required,MinLength(3),MaxLength(70)]
        public string Adress { get; set; }
        [ MinLength(3), MaxLength(70)]
        public string RegistrAdress { get; set; }
        //public string ProfilPhoto { get; set; }
        
        public IFormFile ProfilImg { get; set; }
    }
}
