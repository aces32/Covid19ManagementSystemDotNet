using COVID_19PCR.TestManagement.Application.Features.Locations.Queries.GetAllAvailableLocations;
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
    public class LocationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// An endpoint that returns all locations available for allocating booking space
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetAllAvailableLocations")]
        public async Task<ActionResult<List<AvailableLocationListVm>>> GetAllAvailableLocations()
        {
            var dtos = await _mediator.Send(new GetAllAvailableLocationsQuery());
            return Ok(dtos);
        }
    }
}
