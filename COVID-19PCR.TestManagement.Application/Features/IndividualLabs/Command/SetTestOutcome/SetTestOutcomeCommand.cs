using MediatR;

namespace COVID_19PCR.TestManagement.Application.Features.IndividualLabs.Command.SetTestOutcome
{
    public class SetTestOutcomeCommand : IRequest<SetTestOutcomeCommandResponse>
    {
        /// <summary>
        /// Individual booking Labs Id
        /// </summary>
        public int IndividualLabId { get; set; }
        /// <summary>
        /// Outcome of the covid test taken set by the lab administrator
        /// either negative or positive 
        /// </summary>
        public string TestOutCome { get; set; }
        /// <summary>
        /// Set that tests has been completed
        /// </summary>
        public bool TestCompleted { get; set; }
    }
}
