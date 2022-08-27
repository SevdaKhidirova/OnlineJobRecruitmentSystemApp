using jobrecuritment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.Models
{
    public class UserToVacancy : BaseEntity
    {
        public string UserId { get; set; }
        public int VacancyId { get; set; }
        public DateTime AplyTime { get; set; }
        public AppUser AppUser { get; set; }
        public JobVacancy JobVacancy { get; set; }
    }
}
