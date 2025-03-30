using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Cache;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Domain.Entites;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetAvailableBookingDetails
{
    public class GetAvailableBookingDetailsQueryHandler : IRequestHandler<GetAvailableBookingDetailsQuery, List<AvailableBookingListVm>>
    {
        private readonly IAdminBookingAllocationRepository _adminBookingAllocationRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetAvailableBookingDetailsQueryHandler> _logger;
        private readonly ICacheApplicationService<AdminBookingAllocation> _cacheApplicationService;

        public GetAvailableBookingDetailsQueryHandler(IAdminBookingAllocationRepository adminBookingAllocationRepository,
            IMapper mapper, ILogger<GetAvailableBookingDetailsQueryHandler> logger, ICacheApplicationService<AdminBookingAllocation> cacheApplicationService)
        {
            _adminBookingAllocationRepository = adminBookingAllocationRepository;
            _mapper = mapper;
            _logger = logger;
            _cacheApplicationService = cacheApplicationService;
        }
        public async Task<List<AvailableBookingListVm>> Handle(GetAvailableBookingDetailsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var cachedAdminBooking = _cacheApplicationService.GetCachedItemsList("AdminBookingKey");
                if (cachedAdminBooking?.Count() > 0)
                {
                    return _mapper.Map<List<AvailableBookingListVm>>(cachedAdminBooking);
                }

                var allBookings = await _adminBookingAllocationRepository.GetAllRecentAvailableBookings();
                _cacheApplicationService.SetListCachedItems(allBookings, "AdminBookingKey");
                return _mapper.Map<List<AvailableBookingListVm>>(allBookings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"System Error at GetAvailableBookingDetailsQueryHandler {nameof(Handle)}");
                throw;
            }
        }
    }
}
