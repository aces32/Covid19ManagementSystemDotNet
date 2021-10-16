using COVID_19PCR.TestManagement.Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Individuals.Command.BookCovidTest
{
    public class BookCovidTestCommandResponse : BaseResponse
    {
        public BookCovidTestCommandResponse() : base()
        {

        }

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
        public DateTime BookingDate { get; set; }
    }
}
