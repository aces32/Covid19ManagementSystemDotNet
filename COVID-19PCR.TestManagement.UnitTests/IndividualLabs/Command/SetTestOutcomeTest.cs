using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Features.IndividualLabs.Command.SetTestOutcome;
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

namespace COVID_19PCR.TestManagement.UnitTests.IndividualLabs.Command
{
    public class SetTestOutcomeTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IIndividualLabRepository> _mockIndividualLabRepository;
        public SetTestOutcomeTest()
        {
            _mockIndividualLabRepository = IndividualLabRepositoryMock.GetIndividualLabRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task SetTestOutcome()
        {
            var handler = new SetTestOutcomeCommandHandler(_mapper, new NullLogger<SetTestOutcomeCommandHandler>() ,
                            _mockIndividualLabRepository.Object);
            var setTestOutcomeCommand = new SetTestOutcomeCommand
            {
                IndividualLabId = 1,
                TestCompleted = true,
                TestOutCome = "negative"

            };

            var result = await handler.Handle(setTestOutcomeCommand, CancellationToken.None);

            result.TestOutCome.ShouldBe(setTestOutcomeCommand.TestOutCome);
            result.TestCompleted.ShouldBe(setTestOutcomeCommand.TestCompleted);
        }
    }
}
