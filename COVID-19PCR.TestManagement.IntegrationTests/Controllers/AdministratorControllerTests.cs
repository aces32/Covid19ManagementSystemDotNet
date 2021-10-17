using COVID_19PCR.TestManagement.API;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Command.AllocateBookingSpace;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetAvailableBookingDetails;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetBookingsReports;
using COVID_19PCR.TestManagement.IntegrationTests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace COVID_19PCR.TestManagement.IntegrationTests.Controllers
{
    public class AdministratorControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public AdministratorControllerTests(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task AllocateBookingSpaceReturnsSuccessResult()
        {

            var client = _factory.GetAnonymousClient();

            var payload = new AllocateBookingSpaceCommand
            {
                BookingDates = DateTimeOffset.UtcNow.AddDays(5),
                Capacity = 30,
                LocationID = 1
            };

            var response = await client.PostAsync("/api/Administrator/AllocateBookingSpace", new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<AllocateBookingSpaceCommandResponse>(responseString);

            Assert.IsType<AllocateBookingSpaceCommandResponse>(result);
        }



        [Fact]
        public async Task GetAvailableBookingDetailsReturnsSuccessResult()
        {
            var client = _factory.GetAnonymousClient();

            var response = await client.GetAsync("/api/Administrator/GetAvailableBookingDetails");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<AvailableBookingListVm>>(responseString);

            Assert.IsType<List<AvailableBookingListVm>>(result);
        }

        [Fact]
        public async Task GetBookingsReportsReturnsSuccessResult()
        {
            var client = _factory.GetAnonymousClient();

            var response = await client.GetAsync($"/api/Administrator/GetBookingsReports?startDate=2021-10-13%2017%3A11%3A03.6340000%20%2B00%3A00&endDate=2131-10-29%2000%3A00%3A00.0000000%20%2B01%3A00&page=1&size=60");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<BookingsReportsListsVm>>(responseString);

            Assert.IsType<List<BookingsReportsListsVm>>(result);
        }
    }
}
