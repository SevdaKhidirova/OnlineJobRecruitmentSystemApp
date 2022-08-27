using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class DocumentViewModel
    {
        [Required]
        public IFormFile Cv { get; set; }
        public string Diploms { get; set; }
        public string Certificate { get; set; }
        [MaxLength(300)]
        public string MotivationLetter { get; set; }
        public string Salary { get; set; }
        public string Position { get; set; }
    }
}
