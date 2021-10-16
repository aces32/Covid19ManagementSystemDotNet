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
    public class IndividualConfiguration : IEntityTypeConfiguration<Individual>
    {
        public void Configure(EntityTypeBuilder<Individual> builder)
        {
            builder.Property(e => e.IndividualFirstName)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(e => e.IndividualLastName)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(e => e.IndividualMobileNumber)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.IndividualEmailAddress)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.IndividualBookingStatus)
                .IsRequired();
        }
    }
}
