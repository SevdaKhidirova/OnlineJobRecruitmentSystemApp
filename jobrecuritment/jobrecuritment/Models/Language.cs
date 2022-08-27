using jobrecuritment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.Models
{
    public class Language : BaseEntity
    {
        public string UserId { get; set; }
        public string LanguageItem{ get; set; }
        public string Read{ get; set; }
        public string Write{ get; set; }
        public string Speak{ get; set; }
    }
}
