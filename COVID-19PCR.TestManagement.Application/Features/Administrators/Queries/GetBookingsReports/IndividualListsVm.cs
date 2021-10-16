using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetBookingsReports
{
    public class IndividualListsVm
    {
        public string IndividualFirstName { get; set; }
        public string IndividualLastName { get; set; }
        public string IndividualEmailAddress { get; set; }
        public string IndividualMobileNumber { get; set; }
        public bool IndividualBookingStatus { get; set; }

        public IndividualLabListVm IndividualLab { get; set; }
    }
}
