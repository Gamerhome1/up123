using UP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP.Reports
{
    public class EnrolleeReport
    {
        public List<Enrollee> Enrollees { get; set; }

        public EnrolleeReport(List<Enrollee> enrollees)
        {
            Enrollees = enrollees;
        }
    }
}
