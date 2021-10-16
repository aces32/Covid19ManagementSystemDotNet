using COVID_19PCR.TestManagement.Application.Features.Locations.Queries.GetAllAvailableLocations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetAvailableBookingDetails
{
    public class AvailableBookingListVm
    {
        /// <summary>
        /// Total space capacity for a specified Location
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Total space booked by individuals
        /// </summary>
        public int SpaceAllocated { get; set; }
        /// <summary>
        /// Available date of booking
        /// </summary>
        public DateTimeOffset BookingDates { get; set; }
        /// <summary>
        /// Location of booking
        /// </summary>
        public AvailableLocationListVm Location { get; set; }
    }
}
