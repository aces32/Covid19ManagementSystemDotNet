using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Locations.Queries.GetAllAvailableLocations
{
    public class GetAllAvailableLocationsQuery : IRequest<List<AvailableLocationListVm>>
    {
    }
}
