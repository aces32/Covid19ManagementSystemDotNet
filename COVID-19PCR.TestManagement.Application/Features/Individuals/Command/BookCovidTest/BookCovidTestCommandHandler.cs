using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Exceptions;
using COVID_19PCR.TestManagement.Domain.Entites;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Individuals.Command.BookCovidTest
{
    public class BookCovidTestCommandHandler : IRequestHandler<BookCovidTestCommand, BookCovidTestCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILogger<BookCovidTestCommandHandler> _logger;
        private readonly ILocationRepository _locationRepository;
        private readonly IIndividualRepository _individualRepository;
        private readonly IAdminBookingAllocationRepository _adminBookingAllocationRepository;

        public BookCovidTestCommandHandler(IMapper mapper, ILogger<BookCovidTestCommandHandler> logger, ILocationRepository locationRepository,
            IIndividualRepository individualRepository, IAdminBookingAllocationRepository adminBookingAllocationRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _locationRepository = locationRepository;
            _individualRepository = individualRepository;
            _adminBookingAllocationRepository = adminBookingAllocationRepository;
        }
        public async Task<BookCovidTestCommandResponse> Handle(BookCovidTestCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validator = new BookCovidTestValidator(_locationRepository, _individualRepository);
                var validationResult = await validator.ValidateAsync(request, cancellationToken);

                if (validationResult.Errors.Count > 0)
                    throw new ValidationException(validationResult);

                var getAdminProfiling = await _adminBookingAllocationRepository.GetAdminBookingAllocationByLocationIdandBookingDate(request.LocationID, request.BookingDate);
                if (getAdminProfiling == null)
                {
                    throw new NotFoundException(nameof(AdminBookingAllocation), request.LocationID);

                }
                if (getAdminProfiling.SpaceAllocated >= getAdminProfiling.Capacity)
                {
                    throw new BadRequestException("Capacity at the specified location and date is full");
                }

                var individualData = _mapper.Map<Individual>(request);
                individualData.AdminBookingAllocationId = getAdminProfiling.AdminBookingAllocationId;

                var insertIndividualDetails = await _individualRepository.AddAsync(individualData);

                //Increase total allowed capacity and update the allocation table
                getAdminProfiling.SpaceAllocated += 1;
                await _adminBookingAllocationRepository.UpdateAsync(getAdminProfiling);

                return _mapper.Map<BookCovidTestCommandResponse>(insertIndividualDetails);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"System Error at BookCovidTestCommandHandler {nameof(Handle)}");
                throw;
            }

        }
    }
}
