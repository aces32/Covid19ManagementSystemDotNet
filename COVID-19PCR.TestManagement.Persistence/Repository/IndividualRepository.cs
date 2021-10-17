using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Persistence.Repository
{
    public class IndividualRepository : BaseRepository<Individual>, IIndividualRepository
    {
        public IndividualRepository(COVID19PCRDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> DoesIndividualExist(string emailAddress, string mobileNumber)
        {
            var matches = _dbContext.Individuals.Any(e => e.IndividualEmailAddress == emailAddress 
            && e.IndividualMobileNumber == mobileNumber && e.IndividualBookingStatus == true);
            return Task.FromResult(matches);
        }

        public Task<Individual> GetIndividualBookingByEmailAndMobileNo(string emailAddress, string mobileNumber)
        {
            var individualBooking = _dbContext.Individuals.Include(t => t.IndividualLab).Include(x => x.AdminBookingAllocation).Where(x => x.IndividualEmailAddress == emailAddress &&
                                            x.IndividualMobileNumber == mobileNumber && x.IndividualBookingStatus == true).FirstOrDefault();
            return Task.FromResult(individualBooking);
        }

    }
}
