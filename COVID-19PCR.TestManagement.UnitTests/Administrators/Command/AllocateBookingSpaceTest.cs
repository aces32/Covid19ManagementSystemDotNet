using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Command.AllocateBookingSpace;
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

namespace COVID_19PCR.TestManagement.UnitTests.Administrators.Command
{
    public class AllocateBookingSpaceTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAdminBookingAllocationRepository> _mockAdminBookingAllocationRepository;
        private readonly Mock<ILocationRepository> _mockLocationRepository;
        public AllocateBookingSpaceTest()
        {
            _mockAdminBookingAllocationRepository = AdminBookingAllocationRepositoryMock.GetAdminBookingAllocationRepository();
            _mockLocationRepository = LocationRepositoryMock.GetLocationRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task AllocateBookingSpace()
        {
            var handler = new AllocateBookingSpaceCommandHandler(_mockAdminBookingAllocationRepository.Object,_mapper, new NullLogger<AllocateBookingSpaceCommandHandler>(),
                               _mockLocationRepository.Object);
            var allocateBookingSpaceCommand = new AllocateBookingSpaceCommand
            {
                BookingDates = DateTimeOffset.UtcNow.AddDays(5),
                Capacity = 30,
                LocationID = 1
            };
            await handler.Handle(allocateBookingSpaceCommand, CancellationToken.None);
            var allAllocatedBookingLists = await _mockAdminBookingAllocationRepository.Object.ListAllAsync();
            allAllocatedBookingLists.Count.ShouldBe(4);
        }
    }
}
