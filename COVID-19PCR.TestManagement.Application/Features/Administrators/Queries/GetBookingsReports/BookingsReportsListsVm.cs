using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetBookingsReports
{
    public class BookingsReportsListsVm
    {
        /// <summary>
        /// Capacity allocated for covid tests at a specified location
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// space allocated to individuals for covid tests at the specified location
        /// </summary>
        public int SpaceAllocated { get; set; }
        /// <summary>
        /// date allocated for covid test
        /// </summary>
        public DateTimeOffset BookingDates { get; set; }
        /// <summary>
        /// location information for the covid tests
        /// </summary>
        public LocationListsVm Location { get; set; }
        /// <summary>
        /// individuals that booked covid tests
        /// </summary>
        public List<IndividualListsVm> Individuals { get; set; }
    }
}
