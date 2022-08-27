using jobrecuritment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class EditAdViewModel : BaseViewModel
    {
        public JobVacancy jobVacancy { get; set; }
        public List<JobVacancy> jobVacancyLs { get; set; }
        public List<Level> levels { get; set; }
        public List<Category> category { get; set; }
        public List<JobType> jobType { get; set; }
    }
}
