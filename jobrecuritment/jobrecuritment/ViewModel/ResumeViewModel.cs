using jobrecuritment.DAL;
using jobrecuritment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class ResumeViewModel : BaseViewModel
    {
    
        public PersonalInfo personalInfos { get; set; }
        public List<Interests> interests { get; set; }
        public List<Education> education { get; set; }
        public List<Experience> experience { get; set; }
        public Document Documents { get; set; }
        public List<Language> languages { get; set; }
        public Link links { get; set; }
        public AppUser appUser { get; set; }
        public List<PersonalInfo> personalInfosLs { get; set; }
        public List<Interests> interestsLs2 { get; set; }
        public List<Education> educationLs2 { get; set; }
        public List<Experience> experienceLs2 { get; set; }
        public List<Language> languagesLs2 { get; set; }
        public List<AppUser> appUserLs { get; set; }
        public List<Document> documentsLs { get; set; }


    }
}
