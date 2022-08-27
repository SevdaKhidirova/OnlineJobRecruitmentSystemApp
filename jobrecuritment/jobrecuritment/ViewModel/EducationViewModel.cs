using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class EducationViewModel
    {
        [Required]
        public string Degree { get; set; }
        [Required]
        public string University { get; set; }
        [Required]
        public string EntranceYear { get; set; }
        [Required]
        public string EntranceScore { get; set; }
        [Required]
        public string GraduationYear { get; set; }
        [Required]
        public string Specialization { get; set; }
    }
}
