using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetBookingsReports
{
    public class GetBookingsReportsQuery : IRequest<List<BookingsReportsListsVm>>
    {
        /// <summary>
        /// start date range query
        /// </summary>
        public DateTimeOffset StartDate { get; set; }
        /// <summary>
        /// End date range query
        /// </summary>
        public DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// page number requested
        /// </summary>
        /// 
        public int Page { get; set; }
        /// <summary>
        /// size of the data to be returned
        /// </summary>
        public int Size { get; set; }


    }
}
