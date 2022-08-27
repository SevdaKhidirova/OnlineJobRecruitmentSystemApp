using jobrecuritment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.Models
{
    public class Document:BaseEntity
    {
        public string UserId { get; set; }
        public string Cv { get; set; }
        public string Diploms { get; set; }
        public string Certificate { get; set; }
        public string MotivationLetter { get; set; }
        public string Salary { get; set; }
        public string Position { get; set; }
    }
}
