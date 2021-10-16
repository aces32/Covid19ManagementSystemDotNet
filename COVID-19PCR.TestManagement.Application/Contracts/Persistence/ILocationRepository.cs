using COVID_19PCR.TestManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Contracts.Persistence
{
    public interface ILocationRepository : IAsyncRepository<Location>
    {
        Task<bool> DoesLocationExist(int locationId);
    }
}
