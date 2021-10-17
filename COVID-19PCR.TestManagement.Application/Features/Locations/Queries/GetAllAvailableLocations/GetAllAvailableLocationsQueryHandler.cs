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

namespace COVID_19PCR.TestManagement.Application.Features.Locations.Queries.GetAllAvailableLocations
{
    public class GetAllAvailableLocationsQueryHandler : IRequestHandler<GetAllAvailableLocationsQuery, List<AvailableLocationListVm>>
    {
        private readonly IMapper _mapper;
        private readonly ILocationRepository _locationRepository;
        private readonly ILogger<GetAllAvailableLocationsQueryHandler> _logger;
        private readonly ICacheApplicationService<Location> _cacheApplicationService;

        public GetAllAvailableLocationsQueryHandler(IMapper mapper, ILocationRepository locationRepository,
            ILogger<GetAllAvailableLocationsQueryHandler> logger, ICacheApplicationService<Location> cacheApplicationService)
        {
            _mapper = mapper;
            _locationRepository = locationRepository;
            _logger = logger;
            _cacheApplicationService = cacheApplicationService;
        }

        public async Task<List<AvailableLocationListVm>> Handle(GetAllAvailableLocationsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var cachedLocation = _cacheApplicationService.GetCachedItemsList("locationKey");
                if (cachedLocation?.Count() > 0)
                {
                    return _mapper.Map<List<AvailableLocationListVm>>(cachedLocation);
                }

                var allLocations = (await _locationRepository.ListAllAsync()).OrderBy(x => x.LocationID);

                _cacheApplicationService.SetListCachedItems(allLocations, "locationKey");
                return _mapper.Map<List<AvailableLocationListVm>>(allLocations);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"System Error at GetAllAvailableLocationsQueryHandler {nameof(Handle)}");
                throw;
            }
        }
    }
}
