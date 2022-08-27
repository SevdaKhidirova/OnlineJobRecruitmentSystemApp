using jobrecuritment.DAL;
using jobrecuritment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class ProfilViewModel : BaseViewModel
    {
        public PersonalInfo personalInfos { get; set; }
        public List<Interests> interests { get; set; }
        public Education education { get; set; }
        public List<Experience> experience { get; set; }
        public Document Documents { get; set; }
        public List<Language> languages { get; set; }
        public Link links { get; set; }
        public List<UserToVacancy> userToVacancy { get; set; }
        public List<JobVacancy> jobVacancy { get; set; }
        public List<Level> levels { get; set; }
        public List<Category> category { get; set; }
        public List<JobType> jobType { get; set; }
    }
}
