using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class LinkViewModel
    {
        [MaxLength(100)]
        public string Linkedin { get; set; }
        [MaxLength(100)]
        public string Github { get; set; }
        [MaxLength(100)]
        public string Facebook { get; set; }
    }
}
