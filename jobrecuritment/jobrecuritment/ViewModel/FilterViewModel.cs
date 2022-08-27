using jobrecuritment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class FilterViewModel :BaseViewModel
    {
        public List<Level> levels { get; set; }
        public List<Category> categories { get; set; }
        public List<JobType> jobTypes { get; set; }
        public List<JobVacancy> jobVacancies { get; set; }
        public List<UserToVacancy> userToVacancies { get; set; }
    }
}
