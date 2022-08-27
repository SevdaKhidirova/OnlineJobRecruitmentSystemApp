using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class ExperienceViewModel
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Responsibilities { get; set; }
        [Required]
        public string StartToWork { get; set; }
        [Required]
        public string EndToWork { get; set; }
    }
}
