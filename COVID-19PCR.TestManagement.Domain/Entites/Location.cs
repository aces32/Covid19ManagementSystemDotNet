using COVID_19PCR.TestManagement.Domain.Common;
using System.Collections.Generic;

namespace COVID_19PCR.TestManagement.Domain.Entites
{
    public class Location : AuditableEntity
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public ICollection<AdminBookingAllocation> AdminBookingAllocations { get; set; }
    }
}
