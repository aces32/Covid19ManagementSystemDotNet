using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Domain.Entites
{
    public class Individual
    {
        public int IndividualId { get; set; }
        public string IndividualFirstName { get; set; }
        public string IndividualLastName { get; set; }
        public string IndividualEmailAddress { get; set; }
        public string IndividualMobileNumber { get; set; }
        public bool IndividualBookingStatus { get; set; } = true;

        public int AdminBookingAllocationId { get; set; }
        public AdminBookingAllocation AdminBookingAllocation { get; set; }
        public IndividualLab IndividualLab { get; set; }
    }
}
