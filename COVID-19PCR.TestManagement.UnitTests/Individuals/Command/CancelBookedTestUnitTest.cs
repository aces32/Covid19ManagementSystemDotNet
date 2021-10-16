using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Features.Individuals.Command.CancelBookedTest;
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

namespace COVID_19PCR.TestManagement.UnitTests.Individuals.Command
{
    public class CancelBookedTestUnitTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IIndividualRepository> _mockIndividualRepository;
        public CancelBookedTestUnitTest()
        {
            _mockIndividualRepository = IndividualRepositoryMock.GetIndividualRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        public async Task CancelBookedTest()
        {
            var handler = new CancelBookedTestCommandHandler(_mapper, new NullLogger<CancelBookedTestCommandHandler>(), _mockIndividualRepository.Object);
            var CancelBookedTestCommand = new CancelBookedTestCommand
            {
                IndividualEmailAddress = "Test3@test.com",
                IndividualMobileNumber = "080000000003",
                IndividualBookingStatus = false,
            };

            await handler.Handle(CancelBookedTestCommand, CancellationToken.None);
            var canceledBooking = await _mockIndividualRepository.Object.GetIndividualBookingByEmailAndMobileNo(CancelBookedTestCommand.IndividualEmailAddress,
                CancelBookedTestCommand.IndividualMobileNumber);
            canceledBooking.IndividualBookingStatus.ShouldBe(false);
        }
    }
}
