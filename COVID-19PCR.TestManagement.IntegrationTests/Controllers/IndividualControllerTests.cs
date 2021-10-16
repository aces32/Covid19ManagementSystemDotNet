using COVID_19PCR.TestManagement.API;
using COVID_19PCR.TestManagement.Application.Features.Individuals.Command.BookCovidTest;
using COVID_19PCR.TestManagement.Application.Features.Individuals.Command.CancelBookedTest;
using COVID_19PCR.TestManagement.Application.Features.Individuals.Queries.GetIndividualInfoByMobileNoAndEmail;
using COVID_19PCR.TestManagement.IntegrationTests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace COVID_19PCR.TestManagement.IntegrationTests.Controllers
{
    public class IndividualControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public IndividualControllerTests(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task BookCovidTestReturnsSuccessResult()
        {

            var client = _factory.GetAnonymousClient();

            var payload = new BookCovidTestCommand
            {
                IndividualEmailAddress = "Test4@test.com",
                IndividualFirstName = "Test4FirstName",
                IndividualLastName = "Test4LastName",
                IndividualMobileNumber = "080000000004",
                LocationID = 1,
                BookingDate = DateTimeOffset.UtcNow.AddDays(1),
                IndividualLab = new IndividualLabsRequest
                {
                    TestType = "pcrTest"
                }
            };

            var response = await client.PostAsync("/api/Individual/BookCovidTest", new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<BookCovidTestCommandResponse>(responseString);

            Assert.IsType<BookCovidTestCommandResponse>(result);
        }

        [Fact]
        public async Task CancelBookedTestReturnsSuccessResult()
        {

            var client = _factory.GetAnonymousClient();

            var payload = new CancelBookedTestCommand
            {
                IndividualEmailAddress = "Test3@test.com",
                IndividualMobileNumber = "080000000003",
                IndividualBookingStatus = false
            };

            var response = await client.PutAsync("/api/Individual/CancelBookedTest", new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<CancelBookedTestCommandResponse>(responseString);

            Assert.IsType<CancelBookedTestCommandResponse>(result);
        }

        [Fact]
        public async Task GetIndividualInfoByMobileNoAndEmailReturnsSuccessResult()
        {
            var client =  _factory.GetAnonymousClient();

            var response = await client.GetAsync("/api/Individual/getIndividualInfoByMobileNoAndEmail?emailAddress=Test@test.com&mobileNumber=08000000000");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IndividualInfoListVm>(responseString);

            Assert.IsType<IndividualInfoListVm>(result);
        }
    }
}
