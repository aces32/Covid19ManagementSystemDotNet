using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Locations.Queries.GetAllAvailableLocations
{
    public class AvailableLocationListVm
    {
        /// <summary>
        /// Location Id to be used by the administrator
        /// </summary>
        public int LocationID { get; set; }
        /// <summary>
        /// Available locations for Covid Tests
        /// </summary>
        public string LocationName { get; set; }
    }
}
