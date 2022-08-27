using jobrecuritment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class InterestViewmodel
    {
        public string InterestItem { get; set; }
        public List<Interests> interests { get; set; }
        public List<Category> categories { get; set; }
    }
}
