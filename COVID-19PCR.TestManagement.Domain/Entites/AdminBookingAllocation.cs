using COVID_19PCR.TestManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Domain.Entites
{
    public class AdminBookingAllocation : AuditableEntity
    {
        public int AdminBookingAllocationId { get; set; }
        public int Capacity { get; set; }
        public int SpaceAllocated { get; set; }
        public DateTimeOffset BookingDates { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
        public ICollection<Individual> Individuals { get; set; }
    }
}
