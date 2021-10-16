using COVID_19PCR.TestManagement.Application.Features.IndividualLabs.Command.SetTestOutcome;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public class IndividualLabsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IndividualLabsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// An endpoint where a lab admin can set the outcome of tests.
        /// </summary>
        /// <param name="setTestOutcomeCommand"></param>
        /// <returns></returns>
        [HttpPut("/api/IndividualLabs/SetTestOutcome", Name = "SetTestOutcome")]
        public async Task<ActionResult<SetTestOutcomeCommandResponse>> Update(SetTestOutcomeCommand setTestOutcomeCommand)
        {
            var response = await _mediator.Send(setTestOutcomeCommand);
            return Ok(response);
        }


    }
}
