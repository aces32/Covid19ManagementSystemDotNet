using COVID_19PCR.TestManagement.Domain.Common;
using COVID_19PCR.TestManagement.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Persistence
{
    public class COVID19PCRDbContext : DbContext
    {

        public COVID19PCRDbContext(DbContextOptions<COVID19PCRDbContext> options)
                : base(options)
        {

        }

        public DbSet<AdminBookingAllocation> AdminBookingAllocations { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<IndividualLab> IndividualLabs { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContextOptions).Assembly);
            modelBuilder.Entity<Location>().HasData(new Location
            {
                LocationID = 1,
                LocationName = "Lagos, Nigeria"
            });

            modelBuilder.Entity<Location>().HasData(new Location
            {
                LocationID = 2,
                LocationName = "Ogun, Nigeria"
            });

            modelBuilder.Entity<Location>().HasData(new Location
            {
                LocationID = 3,
                LocationName = "Texas, USA"
            });

            modelBuilder.Entity<Location>().HasData(new Location
            {
                LocationID = 4,
                LocationName = "San Fransisco, USA"
            });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
