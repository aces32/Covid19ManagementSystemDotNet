using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetBookingsReports;
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

namespace COVID_19PCR.TestManagement.UnitTests.Administrators.Queries
{
    public class GetBookingsReportsTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAdminBookingAllocationRepository> _mockAdminBookingAllocationRepository;

        public GetBookingsReportsTest()
        {
            _mockAdminBookingAllocationRepository = AdminBookingAllocationRepositoryMock.GetAdminBookingAllocationRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetBookingsReports()
        {
            var handler = new GetBookingsReportsQueryHandler(_mockAdminBookingAllocationRepository.Object, _mapper,
                new NullLogger<GetBookingsReportsQueryHandler>());

            var getBookingsReportsQuery = new GetBookingsReportsQuery
            {
                StartDate = DateTimeOffset.Now,
                EndDate = DateTimeOffset.Now.AddDays(2),
                Page = 1,
                Size = 10
            };
            var result = await handler.Handle(getBookingsReportsQuery, CancellationToken.None);

            result.ShouldBeOfType<List<BookingsReportsListsVm>>();
        }
    }
}
