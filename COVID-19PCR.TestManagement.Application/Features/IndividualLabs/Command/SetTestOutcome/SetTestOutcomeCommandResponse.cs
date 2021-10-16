using COVID_19PCR.TestManagement.Application.Response;

namespace COVID_19PCR.TestManagement.Application.Features.IndividualLabs.Command.SetTestOutcome
{
    public class SetTestOutcomeCommandResponse : BaseResponse
    {
        public SetTestOutcomeCommandResponse() : base()
        {

        }
        /// <summary>
        /// Test Outcome if it is positive or negative
        /// Pass Negative or Positive
        /// </summary>
        public string TestOutCome { get; set; }
        /// <summary>
        /// Indicates that tests has been completed
        /// </summary>
        public bool TestCompleted { get; set; }
    }
}
