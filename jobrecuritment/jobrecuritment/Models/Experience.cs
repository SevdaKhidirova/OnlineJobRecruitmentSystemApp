using jobrecuritment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.Models
{
    public class Experience : BaseEntity
    {
        public string UserId { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string Responsibilities { get; set; }
        public string StartToWork { get; set; }
        public string EndToWork { get; set; }
        

    }
}
