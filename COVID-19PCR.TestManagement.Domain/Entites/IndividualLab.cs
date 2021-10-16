using COVID_19PCR.TestManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Domain.Entites
{
    public class IndividualLab : AuditableEntity
    {
        public int IndividualLabId { get; set; }
        public string TestType { get; set; }
        public string TestOutCome { get; set; }
        public bool TestCompleted { get; set; }
        public int IndividualId { get; set; }

        public Individual Individual { get; set; }
    }
}
