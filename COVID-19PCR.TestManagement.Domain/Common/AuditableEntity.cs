﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Domain.Common
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTimeOffset? LastModifiedDate { get; set; }
    }
}
