using COVID_19PCR.TestManagement.Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Administrators.Command.AllocateBookingSpace
{
    public class AllocateBookingSpaceCommandResponse : BaseResponse
    {
        public AllocateBookingSpaceCommandResponse() : base()
        {

        }
        /// <summary>
        /// Total space capacity for a specified Location
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Available date of booking
        /// </summary>
        public DateTimeOffset BookingDates { get; set; }

    }
}
