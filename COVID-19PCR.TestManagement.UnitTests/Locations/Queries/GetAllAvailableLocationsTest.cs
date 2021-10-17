using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Cache;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Features.Locations.Queries.GetAllAvailableLocations;
using COVID_19PCR.TestManagement.Application.Profiles;
using COVID_19PCR.TestManagement.Domain.Entites;
using COVID_19PCR.TestManagement.UnitTests.Mocks;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using Shouldly;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace COVID_19PCR.TestManagement.UnitTests.Locations.Queries
{
    public class GetAllAvailableLocationsTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<ILocationRepository> _mockLocationRepository;
        private readonly Mock<ICacheApplicationService<Location>> _mockCacheApplicationService;

        public GetAllAvailableLocationsTest()
        {
            _mockLocationRepository = LocationRepositoryMock.GetLocationRepository();
            _mockCacheApplicationService = CacheApplicationServiceMock<Location>.GetCacheApplicationService();
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
                            new NullLogger<GetAllAvailableLocationsQueryHandler>(), _mockCacheApplicationService.Object);

            var result = await handler.Handle(new GetAllAvailableLocationsQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<AvailableLocationListVm>>();
        }
    }
}
