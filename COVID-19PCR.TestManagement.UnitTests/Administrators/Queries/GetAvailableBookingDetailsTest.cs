using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Cache;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetAvailableBookingDetails;
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

namespace COVID_19PCR.TestManagement.UnitTests.Administrators.Queries
{
    public class GetAvailableBookingDetailsTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAdminBookingAllocationRepository> _mockAdminBookingAllocationRepository;
        private readonly Mock<ICacheApplicationService<AdminBookingAllocation>> _mockCacheApplicationService;

        public GetAvailableBookingDetailsTest()
        {
            _mockAdminBookingAllocationRepository = AdminBookingAllocationRepositoryMock.GetAdminBookingAllocationRepository();
            _mockCacheApplicationService = CacheApplicationServiceMock<AdminBookingAllocation>.GetCacheApplicationService();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetAvailableBookingDetails()
        {
            var handler = new GetAvailableBookingDetailsQueryHandler(_mockAdminBookingAllocationRepository.Object, _mapper,
                new NullLogger<GetAvailableBookingDetailsQueryHandler>(), _mockCacheApplicationService.Object);

            var result = await handler.Handle(new GetAvailableBookingDetailsQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<AvailableBookingListVm>>();
        }
    }
}
