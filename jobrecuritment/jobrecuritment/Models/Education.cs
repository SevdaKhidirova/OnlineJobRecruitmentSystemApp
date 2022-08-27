using jobrecuritment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.Models
{
    public class Education :BaseEntity 
    {
        public string UserId { get; set; }
        public string Degree { get; set; }
        public string University { get; set; }
        public string EntranceYear { get; set; }
        public string EntranceScore { get; set; }
        public string GraduationYear { get; set; }
        public string Specialization { get; set; }
    }
}
