using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetAvailableBookingDetails
{
    public class GetAvailableBookingDetailsQuery : IRequest<List<AvailableBookingListVm>>
    {
    }
}
