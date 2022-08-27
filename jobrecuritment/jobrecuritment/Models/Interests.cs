using jobrecuritment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.Models
{
    public class Interests :BaseEntity
    {
        public string UserId { get; set; }
        public string InterestItem { get; set; }
    }
}
