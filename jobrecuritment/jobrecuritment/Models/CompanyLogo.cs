using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.Models
{
    public class CompanyLogo : BaseEntity
    {
        public string CompanyName { get; set; }
        public string LogoImage { get; set; }

        [NotMapped]
        public IFormFile LogoImg { get; set; }
    }
}
