using jobrecuritment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.ViewModel
{
    public class SummaryViewModel : BaseViewModel
    {
        public JobVacancy jobVacancy { get; set; }
        public UserToVacancy apliedVacancy { get; set; }
    }
}
