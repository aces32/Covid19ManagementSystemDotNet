using AutoMapper;
using COVID_19PCR.TestManagement.Application.Contracts.Cache;
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

namespace COVID_19PCR.TestManagement.Application.Features.Individuals.Queries.GetIndividualInfoByMobileNoAndEmail
{
    public class GetIndividualInfoByMobileNoAndEmailQueryHandler : IRequestHandler<GetIndividualInfoByMobileNoAndEmailQuery, IndividualInfoListVm>
    {
        private readonly IMapper _mapper;
        private readonly ILogger<GetIndividualInfoByMobileNoAndEmailQueryHandler> _logger;
        private readonly IIndividualRepository _individualRepository;
        private readonly ICacheApplicationService<Individual> _cacheApplicationService;

        public GetIndividualInfoByMobileNoAndEmailQueryHandler(IMapper mapper, ILogger<GetIndividualInfoByMobileNoAndEmailQueryHandler> logger,
            IIndividualRepository individualRepository, ICacheApplicationService<Individual> cacheApplicationService)
        {
            _mapper = mapper;
            _logger = logger;
            _individualRepository = individualRepository;
            _cacheApplicationService = cacheApplicationService;
        }
        public async Task<IndividualInfoListVm> Handle(GetIndividualInfoByMobileNoAndEmailQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var validator = new GetIndividualInfoByMobileNoAndEmailValidator(_individualRepository);
                var validationResult = await validator.ValidateAsync(request, cancellationToken);

                if (validationResult.Errors.Count > 0)
                    throw new ValidationException(validationResult);

                var cachedIndividualBooking = _cacheApplicationService.GetCachedItems("individuabookingKey");
                if (cachedIndividualBooking is not null)
                {
                    return _mapper.Map<IndividualInfoListVm>(cachedIndividualBooking);
                }

                var individualRecord = await _individualRepository.GetIndividualBookingByEmailAndMobileNo(request.IndividualEmailAddress,
                                        request.IndividualMobileNumber);
                _cacheApplicationService.SetCachedItems(individualRecord, "individuabookingKey");
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
