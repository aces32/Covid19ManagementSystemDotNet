using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Individuals.Queries.GetIndividualInfoByMobileNoAndEmail
{
    public class GetIndividualInfoByMobileNoAndEmailQuery : IRequest<IndividualInfoListVm>
    {
        public string IndividualEmailAddress { get; set; }
        public string IndividualMobileNumber { get; set; }
    }
}
