using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Persistence.Repository
{
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        public LocationRepository(COVID19PCRDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> DoesLocationExist(int locationId)
        {
            var matches = _dbContext.Locations.Any(e => e.LocationID == locationId);
            return Task.FromResult(matches);
        }
    }
}
