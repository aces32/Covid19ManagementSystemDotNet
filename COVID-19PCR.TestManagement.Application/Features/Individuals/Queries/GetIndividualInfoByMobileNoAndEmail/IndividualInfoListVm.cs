using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Individuals.Queries.GetIndividualInfoByMobileNoAndEmail
{
    public class IndividualInfoListVm
    {
        public string IndividualFirstName { get; set; }
        public string IndividualLastName { get; set; }
        public string IndividualEmailAddress { get; set; }
        public string IndividualMobileNumber { get; set; }
        public IndividualLabDetailsVm IndividualLab { get; set; }
        public int AdminBookingAllocationId { get; set; }

    }
}
