using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Cache;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Features.Individuals.Queries.GetIndividualInfoByMobileNoAndEmail;
using COVID_19PCR.TestManagement.Application.Profiles;
using COVID_19PCR.TestManagement.Domain.Entites;
using COVID_19PCR.TestManagement.UnitTests.Mocks;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace COVID_19PCR.TestManagement.UnitTests.Individuals.Queries
{
    public class GetIndividualInfoByMobileNoAndEmailTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IIndividualRepository> _mockIndividualRepository;
        private readonly Mock<ICacheApplicationService<Individual>> _mockCacheApplicationService;

        public GetIndividualInfoByMobileNoAndEmailTest()
        {
            _mockIndividualRepository = IndividualRepositoryMock.GetIndividualRepository();
            _mockCacheApplicationService = CacheApplicationServiceMock<Individual>.GetCacheApplicationService();
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
                            _mockIndividualRepository.Object, _mockCacheApplicationService.Object);

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
