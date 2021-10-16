using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Command.AllocateBookingSpace;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetAvailableBookingDetails;
using COVID_19PCR.TestManagement.Application.Profiles;
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

        public GetAvailableBookingDetailsTest()
        {
            _mockAdminBookingAllocationRepository = AdminBookingAllocationRepositoryMock.GetAdminBookingAllocationRepository();
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
                new NullLogger<GetAvailableBookingDetailsQueryHandler>());

            var result = await handler.Handle(new GetAvailableBookingDetailsQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<AvailableBookingListVm>>();
        }
    }
}
