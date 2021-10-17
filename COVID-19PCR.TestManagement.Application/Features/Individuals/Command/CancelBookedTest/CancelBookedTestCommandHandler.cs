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

namespace COVID_19PCR.TestManagement.Application.Features.Individuals.Command.CancelBookedTest
{
    public class CancelBookedTestCommandHandler : IRequestHandler<CancelBookedTestCommand, CancelBookedTestCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILogger<CancelBookedTestCommandHandler> _logger;
        private readonly IIndividualRepository _individualRepository;

        public CancelBookedTestCommandHandler(IMapper mapper, ILogger<CancelBookedTestCommandHandler> logger,
            IIndividualRepository individualRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _individualRepository = individualRepository;
        }
        public async Task<CancelBookedTestCommandResponse> Handle(CancelBookedTestCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validator = new CancelBookedTestValidator(_individualRepository);
                var validationResult = await validator.ValidateAsync(request, cancellationToken);

                if (validationResult.Errors.Count > 0)
                    throw new ValidationException(validationResult);

                var individualRecord = await _individualRepository.GetIndividualBookingByEmailAndMobileNo(request.IndividualEmailAddress,
                    request.IndividualMobileNumber);
                if (!request.IndividualBookingStatus)
                    individualRecord.AdminBookingAllocation.SpaceAllocated -= 1;

                _mapper.Map(request, individualRecord, typeof(CancelBookedTestCommand), typeof(Individual));
                await _individualRepository.UpdateAsync(individualRecord);

                return _mapper.Map<CancelBookedTestCommandResponse>(individualRecord);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"System Error at CancelBookedTestCommandHandler {nameof(Handle)}");
                throw;
            }
        }
    }
}
