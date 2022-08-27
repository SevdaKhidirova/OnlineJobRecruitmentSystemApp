using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.Models
{
    public class JobVacancy : BaseEntity
    {
        public string UserId { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string RequiredEducation { get; set; }
        public string DueTime { get; set; }
        public string Salary { get; set; }
        public string WorkTime { get; set; }
        public string RequiredAge { get; set; }
        public string Summary { get; set; }
        public string Responsibilities { get; set; }
        public string Requirements { get; set; }
        public string ReasonToJoinUs { get; set; }
        public DateTime PostTime { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Level Level { get; set; }
        public int LevelId { get; set; }
        public JobType JobType { get; set; }
        public int JobTypeId { get; set; }
    }
}
