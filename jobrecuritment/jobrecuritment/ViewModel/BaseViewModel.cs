using jobrecuritment.DAL;
using jobrecuritment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class BaseViewModel
    {
        public PersonalInfo NavbarProfil { get; set; }
        public AppUser AppUser { get; set; }
    }
}
