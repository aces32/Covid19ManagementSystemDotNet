using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Exceptions;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetAvailableBookingDetails;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetBookingsReports
{
    public class GetBookingsReportsQueryHandler : IRequestHandler<GetBookingsReportsQuery, List<BookingsReportsListsVm>>
    {

        private readonly IAdminBookingAllocationRepository _adminBookingAllocationRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetBookingsReportsQueryHandler> _logger;
        public GetBookingsReportsQueryHandler(IAdminBookingAllocationRepository adminBookingAllocationRepository,
            IMapper mapper, ILogger<GetBookingsReportsQueryHandler> logger)
        {
            _adminBookingAllocationRepository = adminBookingAllocationRepository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<List<BookingsReportsListsVm>> Handle(GetBookingsReportsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var validator = new GetBookingsReportsValidators();
                var validationResult = await validator.ValidateAsync(request, cancellationToken);

                if (validationResult.Errors.Count > 0)
                    throw new ValidationException(validationResult);

                var bookingsReportsLists = await _adminBookingAllocationRepository.GetAdminBookingAllocationHistorybyBookingDates(request.StartDate, request.EndDate, request.Page, request.Size);
                return _mapper.Map<List<BookingsReportsListsVm>>(bookingsReportsLists);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"System Error at GetBookingsReportsQueryHandler {nameof(Handle)}");
                throw;
            }
        }
    }
}
