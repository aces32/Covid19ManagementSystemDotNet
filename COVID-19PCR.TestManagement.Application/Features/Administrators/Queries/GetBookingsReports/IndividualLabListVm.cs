using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetBookingsReports
{
    public class IndividualLabListVm
    {
        public string TestType { get; set; }
        public string TestOutCome { get; set; }
        public bool TestCompleted { get; set; }
    }
}
