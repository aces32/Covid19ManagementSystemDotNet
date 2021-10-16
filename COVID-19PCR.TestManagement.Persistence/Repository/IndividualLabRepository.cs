using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Persistence.Repository
{
    public class IndividualLabRepository : BaseRepository<IndividualLab>, IIndividualLabRepository
    {
        public IndividualLabRepository(COVID19PCRDbContext dbContext) : base(dbContext)
        {

        }
    }
}
