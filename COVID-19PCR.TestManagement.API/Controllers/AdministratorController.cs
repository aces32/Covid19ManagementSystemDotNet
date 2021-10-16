using COVID_19PCR.TestManagement.Application.Features.Administrators.Command.AllocateBookingSpace;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetAvailableBookingDetails;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetBookingsReports;
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
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public class AdministratorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdministratorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// An endpoint to allocate spaces for tests at specific locations and days.
        /// </summary>
        /// <param name="allocateBookingSpaceCommand"></param>
        /// <returns></returns>
        [HttpPost("/api/Administrator/AllocateBookingSpace", Name = "AllocateBookingSpace")]
        public async Task<ActionResult<AllocateBookingSpaceCommandResponse>> Create(AllocateBookingSpaceCommand allocateBookingSpaceCommand)
        {
            var response = await _mediator.Send(allocateBookingSpaceCommand);
            return Ok(response);
        }

        /// <summary>
        /// An endpoint that shows all Available booking details from query date
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/Administrator/GetAvailableBookingDetails", Name = "GetAvailableBookingDetails")]
        public async Task<ActionResult<List<AvailableBookingListVm>>> Get()
        {
            var response = await _mediator.Send(new GetAvailableBookingDetailsQuery());
            return Ok(response);
        }

        /// <summary>
        /// An endpoint that spool all booking reports based on specified dates
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/Administrator/GetBookingsReports", Name = "GetBookingsReports")]
        public async Task<ActionResult<List<BookingsReportsListsVm>>> Get(DateTimeOffset startDate, DateTimeOffset endDate, int page, int size)
        {
            var getBookingsReportsQuery = new GetBookingsReportsQuery
            {
                StartDate = startDate,
                EndDate = endDate,
                Page = page,
                Size = size
            };
            var response = await _mediator.Send(getBookingsReportsQuery);
            return Ok(response);
        }
    }
}
