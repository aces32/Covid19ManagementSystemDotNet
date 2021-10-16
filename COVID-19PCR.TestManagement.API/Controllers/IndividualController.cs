using COVID_19PCR.TestManagement.Application.Features.Individuals.Command.BookCovidTest;
using COVID_19PCR.TestManagement.Application.Features.Individuals.Command.CancelBookedTest;
using COVID_19PCR.TestManagement.Application.Features.Individuals.Queries.GetIndividualInfoByMobileNoAndEmail;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public class IndividualController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IndividualController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// An endpoint used by an individual to book PCR or Rapid Test at a specific day and location, based on availability.
        /// </summary>
        /// <param name="bookCovidTestCommand"></param>
        /// <returns></returns>
        [HttpPost("/api/Individual/BookCovidTest", Name = "BookCovidTest")]
        public async Task<ActionResult<BookCovidTestCommandResponse>> Create(BookCovidTestCommand bookCovidTestCommand)
        {
            var response = await _mediator.Send(bookCovidTestCommand);
            return Ok(response);
        }

        /// <summary>
        /// An endpoint for an individual to cancel a booked test,
        /// </summary>
        /// <param name="cancelBookedTestCommand"></param>
        /// <returns></returns>
        [HttpPut("/api/Individual/CancelBookedTest", Name = "CancelBookedTest")]
        public async Task<ActionResult<CancelBookedTestCommandResponse>> Update(CancelBookedTestCommand cancelBookedTestCommand)
        {
            var canceledBookings = await _mediator.Send(cancelBookedTestCommand);
            return Ok(canceledBookings);
        }

        /// <summary>
        /// An enpoint to return individual booked tests based on emailaddress and mobile number
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <param name="mobileNumber"></param>
        /// <returns></returns>
        [HttpGet("/api/Individual/getIndividualInfoByMobileNoAndEmail", Name = "GetIndividualInfoByMobileNoAndEmail")]
        public async Task<ActionResult<IndividualInfoListVm>> Get(string emailAddress, string mobileNumber)
        {
            var getIndividualInfoByMobileNoAndEmail = new GetIndividualInfoByMobileNoAndEmailQuery
            {
                IndividualEmailAddress = emailAddress.Trim(),
                IndividualMobileNumber = mobileNumber.Trim()
            };

            var response = await _mediator.Send(getIndividualInfoByMobileNoAndEmail);

            return Ok(response);
        }
    }
}
