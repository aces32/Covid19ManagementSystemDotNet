using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Administrators.Command.AllocateBookingSpace
{
    public class AllocateBookingSpaceCommand : IRequest<AllocateBookingSpaceCommandResponse>
    {
        /// <summary>
        /// Total space capacity for a specified Location
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Available date of booking
        /// </summary>
        public DateTimeOffset BookingDates { get; set; }
        /// <summary>
        /// Location ID based on the location name selected by the administrator
        /// </summary>
        public int LocationID { get; set; }
    }
}
