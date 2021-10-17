using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Exceptions;
using COVID_19PCR.TestManagement.Domain.Entites;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Administrators.Command.AllocateBookingSpace
{
    public class AllocateBookingSpaceCommandHandler : IRequestHandler<AllocateBookingSpaceCommand, AllocateBookingSpaceCommandResponse>
    {
        private readonly IAdminBookingAllocationRepository _adminBookingAllocationRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AllocateBookingSpaceCommandHandler> _logger;
        private readonly ILocationRepository _locationRepository;

        public AllocateBookingSpaceCommandHandler(IAdminBookingAllocationRepository adminBookingAllocationRepository,
            IMapper mapper, ILogger<AllocateBookingSpaceCommandHandler> logger, ILocationRepository locationRepository)
        {
            _adminBookingAllocationRepository = adminBookingAllocationRepository;
            _mapper = mapper;
            _logger = logger;
            _locationRepository = locationRepository;
        }

        public async Task<AllocateBookingSpaceCommandResponse> Handle(AllocateBookingSpaceCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validator = new AllocateBookingSpaceValidator(_locationRepository, _adminBookingAllocationRepository);
                var validationResult = await validator.ValidateAsync(request, cancellationToken);

                if (validationResult.Errors.Count > 0)
                    throw new ValidationException(validationResult);

                var allocateBookingSpace = await _adminBookingAllocationRepository.AddAsync(_mapper.Map<AdminBookingAllocation>(request));
                return _mapper.Map<AllocateBookingSpaceCommandResponse>(allocateBookingSpace);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"System Error at AllocateBookingSpaceCommandHandler {nameof(Handle)}");
                throw;
            }
        }
    }
}
