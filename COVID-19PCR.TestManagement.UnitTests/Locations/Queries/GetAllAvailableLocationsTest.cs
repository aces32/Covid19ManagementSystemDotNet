using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Features.Locations.Queries.GetAllAvailableLocations;
using COVID_19PCR.TestManagement.Application.Profiles;
using COVID_19PCR.TestManagement.UnitTests.Mocks;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace COVID_19PCR.TestManagement.UnitTests.Locations.Queries
{
    public class GetAllAvailableLocationsTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<ILocationRepository> _mockLocationRepository;
        public GetAllAvailableLocationsTest()
        {
            _mockLocationRepository = LocationRepositoryMock.GetLocationRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetAllAvailableLocations()
        {
            var handler = new GetAllAvailableLocationsQueryHandler(_mapper, _mockLocationRepository.Object,
                            new NullLogger<GetAllAvailableLocationsQueryHandler>());

            var result = await handler.Handle(new GetAllAvailableLocationsQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<AvailableLocationListVm>>();
        }
    }
}
