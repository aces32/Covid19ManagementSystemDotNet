using COVID_19PCR.TestManagement.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Persistence.Configuration
{
    public class IndividualLabConfiguration : IEntityTypeConfiguration<IndividualLab>
    {
        public void Configure(EntityTypeBuilder<IndividualLab> builder)
        {
            builder.Property(e => e.TestCompleted)
                .IsRequired();

            builder.Property(e => e.TestOutCome)
                .IsRequired();

            builder.Property(e => e.TestType)
                .IsRequired();
        }
    }
}
