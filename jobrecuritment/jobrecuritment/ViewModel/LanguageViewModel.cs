using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class LanguageViewModel
    {
        [Required]
        public string LanguageItem { get; set; }
        [Required]
        public string Read { get; set; }
        [Required]
        public string Write { get; set; }
        [Required]
        public string Speak { get; set; }
    }
}
