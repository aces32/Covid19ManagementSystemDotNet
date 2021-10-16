using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Features.Individuals.Queries.GetIndividualInfoByMobileNoAndEmail;
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

namespace COVID_19PCR.TestManagement.UnitTests.Individuals.Queries
{
    public class GetIndividualInfoByMobileNoAndEmailTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IIndividualRepository> _mockIndividualRepository;
        public GetIndividualInfoByMobileNoAndEmailTest()
        {
            _mockIndividualRepository = IndividualRepositoryMock.GetIndividualRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetIndividualInfoByMobileNoAndEmail()
        {
            var handler = new GetIndividualInfoByMobileNoAndEmailQueryHandler(_mapper, new NullLogger<GetIndividualInfoByMobileNoAndEmailQueryHandler>(),
                            _mockIndividualRepository.Object);

            var getIndividualInfoByMobileNoAndEmailQuery = new GetIndividualInfoByMobileNoAndEmailQuery()
            {
                IndividualMobileNumber = "08000000000",
                IndividualEmailAddress = "Test@test.com"
            };

            var result = await handler.Handle(getIndividualInfoByMobileNoAndEmailQuery, CancellationToken.None);

            result.ShouldBeOfType<IndividualInfoListVm>();
        }
    }
}
