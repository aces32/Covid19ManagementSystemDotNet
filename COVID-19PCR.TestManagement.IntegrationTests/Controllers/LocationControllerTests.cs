using COVID_19PCR.TestManagement.API;
using COVID_19PCR.TestManagement.Application.Features.Locations.Queries.GetAllAvailableLocations;
using COVID_19PCR.TestManagement.IntegrationTests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace COVID_19PCR.TestManagement.IntegrationTests.Controllers
{
    public class LocationControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public LocationControllerTests(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetAllAvailableLocationsReturnsSuccessResult()
        {
            var client =  _factory.GetAnonymousClient();

            var response = await client.GetAsync("/api/Location");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<AvailableLocationListVm>>(responseString);

            Assert.IsType<List<AvailableLocationListVm>>(result);
        }
    }
}
