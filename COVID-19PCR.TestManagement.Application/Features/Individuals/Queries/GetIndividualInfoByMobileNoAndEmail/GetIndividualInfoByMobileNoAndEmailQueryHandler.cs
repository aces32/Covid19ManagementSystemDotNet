using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Exceptions;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Individuals.Queries.GetIndividualInfoByMobileNoAndEmail
{
    public class GetIndividualInfoByMobileNoAndEmailQueryHandler : IRequestHandler<GetIndividualInfoByMobileNoAndEmailQuery, IndividualInfoListVm>
    {
        private readonly IMapper _mapper;
        private readonly ILogger<GetIndividualInfoByMobileNoAndEmailQueryHandler> _logger;
        private readonly IIndividualRepository _individualRepository;
        public GetIndividualInfoByMobileNoAndEmailQueryHandler(IMapper mapper, ILogger<GetIndividualInfoByMobileNoAndEmailQueryHandler> logger,
            IIndividualRepository individualRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _individualRepository = individualRepository;
        }
        public async Task<IndividualInfoListVm> Handle(GetIndividualInfoByMobileNoAndEmailQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var validator = new GetIndividualInfoByMobileNoAndEmailValidator(_individualRepository);
                var validationResult = await validator.ValidateAsync(request, cancellationToken);

                if (validationResult.Errors.Count > 0)
                    throw new ValidationException(validationResult);

                var individualRecord = await _individualRepository.GetIndividualBookingByEmailAndMobileNo(request.IndividualEmailAddress,
                                        request.IndividualMobileNumber);

                return _mapper.Map<IndividualInfoListVm>(individualRecord);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"System Error at GetIndividualInfoByMobileNoAndEmailQueryHandler {nameof(Handle)}");
                throw;
            }

        }
    }
}
