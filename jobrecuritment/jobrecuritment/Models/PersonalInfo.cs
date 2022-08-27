using jobrecuritment.DAL;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.Models
{
    public class PersonalInfo:BaseEntity
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public DateTime DateOfBiirth { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
        public string RegistrAdress { get; set; }
        public string ProfilImage { get; set; }
        public DateTime RegistrationTime { get; set; }

        [NotMapped]
        public IFormFile ProfilImg { get; set; }

    }
}
