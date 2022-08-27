using jobrecuritment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class EmployerResumeViewModel : BaseViewModel
    {
        public List<Level> levels { get; set; }
        public List<Category> categories { get; set; }
        public List<JobType> jobTypes { get; set; }
        public List<JobVacancy> jobVacancies { get; set; }
        public List<PersonalInfo> personalInfos { get; set; }
        public List<Interests> interests { get; set; }
        public List<Education> education { get; set; }
        public List<Experience> experience { get; set; }
        public List<Document> Documents { get; set; }
        public List<Language> languages { get; set; }
        public List<Link> links { get; set; }
    }
}
