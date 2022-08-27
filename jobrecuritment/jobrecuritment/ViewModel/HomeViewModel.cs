using jobrecuritment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public List<Level> levels { get; set; }
        public List<Category> categories { get; set; }
        public List<JobType> jobTypes { get; set; }
        public List<JobVacancy> jobVacancies { get; set; }
        public CardOne cardOne { get; set; }
        public CardTwo cardTwo { get; set; }
        public CardThree cardThree { get; set; }
        public List<CompanyLogo> companyLogos { get; set; }

    }
}
