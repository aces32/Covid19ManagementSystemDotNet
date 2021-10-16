using COVID_19PCR.TestManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Contracts.Persistence
{
    public interface IIndividualRepository : IAsyncRepository<Individual>
    {
        Task<bool> DoesIndividualExist(string emailAddress, string mobileNumber);
        Task<Individual> GetIndividualBookingByEmailAndMobileNo(string emailAddress, string mobileNumber);
    }
}
