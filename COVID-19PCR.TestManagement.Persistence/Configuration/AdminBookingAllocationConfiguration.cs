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
    public class AdminBookingAllocationConfiguration : IEntityTypeConfiguration<AdminBookingAllocation>
    {
        public void Configure(EntityTypeBuilder<AdminBookingAllocation> builder)
        {
            builder.Property(e => e.BookingDates)
                .IsRequired();
            builder.Property(e => e.Capacity)
                .IsRequired();
        }
    }
}
