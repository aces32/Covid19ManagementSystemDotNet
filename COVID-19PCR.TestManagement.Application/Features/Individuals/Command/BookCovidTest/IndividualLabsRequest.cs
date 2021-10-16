namespace COVID_19PCR.TestManagement.Application.Features.Individuals.Command.BookCovidTest
{
    public class IndividualLabsRequest
    {
        /// <summary>
        /// Type of test individual wants to take
        /// Either pass PCRTest or RapidTest
        /// </summary>
        public string TestType { get; set; }
    }
}
