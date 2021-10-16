using COVID_19PCR.TestManagement.API;
using COVID_19PCR.TestManagement.Application.Features.IndividualLabs.Command.SetTestOutcome;
using COVID_19PCR.TestManagement.IntegrationTests.Base;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace COVID_19PCR.TestManagement.IntegrationTests.Controllers
{
    public class IndividualLabsControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public IndividualLabsControllerTests(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task SetTestOutcomeReturnsSuccessResult()
        {

            var client =  _factory.GetAnonymousClient();

            var payload = new SetTestOutcomeCommand
            {
                IndividualLabId = 2,
                TestCompleted = true,
                TestOutCome = "negative"
            };

            var response = await client.PutAsync("/api/IndividualLabs/SetTestOutcome", new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<SetTestOutcomeCommandResponse>(responseString);

            Assert.IsType<SetTestOutcomeCommandResponse>(result);
        }
    }
}
