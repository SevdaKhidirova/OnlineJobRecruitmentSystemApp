using jobrecuritment.DAL;
using jobrecuritment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class EditEducationViewModel :BaseEntity
    {
        public List<Education> education { get; set; }
        public AppUser AppUser { get; set; }
        public PersonalInfo NavbarProfil { get; set; }
    }
}
