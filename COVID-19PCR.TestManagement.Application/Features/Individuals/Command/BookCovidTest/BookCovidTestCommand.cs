using MediatR;
using System;

namespace COVID_19PCR.TestManagement.Application.Features.Individuals.Command.BookCovidTest
{
    public class BookCovidTestCommand : IRequest<BookCovidTestCommandResponse>
    {
        /// <summary>
        /// Individual booking first name
        /// </summary>
        public string IndividualFirstName { get; set; }
        /// <summary>
        /// Individual booking Last name
        /// </summary>
        public string IndividualLastName { get; set; }
        /// <summary>
        /// Individual booking Email Address
        /// </summary>
        public string IndividualEmailAddress { get; set; }
        /// <summary>
        /// Individual booking Mobile Number
        /// </summary>
        public string IndividualMobileNumber { get; set; }
        /// <summary>
        /// Date of booking
        /// </summary>
        public DateTimeOffset BookingDate { get; set; }
        /// <summary>
        /// Id of the location been booked
        /// </summary>
        public int LocationID { get; set; }
        /// <summary>
        /// Individual lab details
        /// </summary>
        public IndividualLabsRequest IndividualLab { get; set; }

    }
}
