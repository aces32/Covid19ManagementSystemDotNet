using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Individuals.Command.CancelBookedTest
{
    public class CancelBookedTestCommand : IRequest<CancelBookedTestCommandResponse>
    {
        /// <summary>
        /// Individual booking Email Address
        /// </summary>
        public string IndividualEmailAddress { get; set; }
        /// <summary>
        /// Individual booking Mobile Number
        /// </summary>
        public string IndividualMobileNumber { get; set; }
        /// <summary>
        /// Use to cancel the booking status
        /// </summary>
        public bool IndividualBookingStatus { get; set; }
    }
}
