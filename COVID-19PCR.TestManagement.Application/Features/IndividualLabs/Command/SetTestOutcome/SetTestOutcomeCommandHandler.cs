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

namespace COVID_19PCR.TestManagement.Application.Features.IndividualLabs.Command.SetTestOutcome
{
    public class SetTestOutcomeCommandHandler : IRequestHandler<SetTestOutcomeCommand, SetTestOutcomeCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILogger<SetTestOutcomeCommandHandler> _logger;
        private readonly IIndividualLabRepository _individualLabRepository;

        public SetTestOutcomeCommandHandler(IMapper mapper, ILogger<SetTestOutcomeCommandHandler> logger,
            IIndividualLabRepository individualLabRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _individualLabRepository = individualLabRepository;
        }
        public async Task<SetTestOutcomeCommandResponse> Handle(SetTestOutcomeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validator = new SetTestOutcomeValidator();
                var validationResult = await validator.ValidateAsync(request, cancellationToken);

                if (validationResult.Errors.Count > 0)
                    throw new ValidationException(validationResult);

                var getIndividualLabsRecords = await _individualLabRepository.GetByIdAsync(request.IndividualLabId);
                _mapper.Map(request, getIndividualLabsRecords, typeof(SetTestOutcomeCommand), typeof(IndividualLab));

                await _individualLabRepository.UpdateAsync(getIndividualLabsRecords);
                return _mapper.Map<SetTestOutcomeCommandResponse>(getIndividualLabsRecords);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"System Error at SetTestOutcomeCommandHandler {nameof(Handle)}");
                throw;
            }
        }
    }
}
