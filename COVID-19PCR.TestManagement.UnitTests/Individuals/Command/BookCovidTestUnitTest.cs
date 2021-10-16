using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Features.Individuals.Command.BookCovidTest;
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

namespace COVID_19PCR.TestManagement.UnitTests.Individuals.Command
{
    public class BookCovidTestUnitTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAdminBookingAllocationRepository> _mockAdminBookingAllocationRepository;
        private readonly Mock<ILocationRepository> _mockLocationRepository;
        private readonly Mock<IIndividualRepository> _mockIndividualRepository;
        public BookCovidTestUnitTest()
        {
            _mockAdminBookingAllocationRepository = AdminBookingAllocationRepositoryMock.GetAdminBookingAllocationRepository();
            _mockLocationRepository = LocationRepositoryMock.GetLocationRepository();
            _mockIndividualRepository = IndividualRepositoryMock.GetIndividualRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task BookCovidTest()
        {
            var handler = new BookCovidTestCommandHandler(_mapper, new NullLogger<BookCovidTestCommandHandler>(), _mockLocationRepository.Object,
                _mockIndividualRepository.Object, _mockAdminBookingAllocationRepository.Object);
            var bookCovidTestCommand = new BookCovidTestCommand
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

            await handler.Handle(bookCovidTestCommand, CancellationToken.None);
            var allIndividualLists = await _mockIndividualRepository.Object.ListAllAsync();
            allIndividualLists.Count.ShouldBe(4);

        }
    }
}
