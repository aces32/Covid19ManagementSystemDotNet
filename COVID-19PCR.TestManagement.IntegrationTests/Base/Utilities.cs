using COVID_19PCR.TestManagement.Domain.Entites;
using COVID_19PCR.TestManagement.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.IntegrationTests.Base
{
    public class Utilities
    {
        public static void InitializeDbForTests(COVID19PCRDbContext context)
        {
            #region IntegrationTestInMemoryData


            var adminAllocationId1 = new AdminBookingAllocation
            {
                AdminBookingAllocationId = 1,
                SpaceAllocated = 50,
                BookingDates = DateTimeOffset.UtcNow.AddDays(2),
                Capacity = 30,
                LocationID = 1,
            };
            var adminAllocationId2 = new AdminBookingAllocation
            {
                AdminBookingAllocationId = 2,
                SpaceAllocated = 20,
                BookingDates = DateTimeOffset.UtcNow.AddDays(1),
                Capacity = 20,
                LocationID = 2,
            };
            var adminAllocationId3 = new AdminBookingAllocation
            {
                AdminBookingAllocationId = 3,
                SpaceAllocated = 5,
                BookingDates = DateTimeOffset.UtcNow.AddDays(1),
                Capacity = 20,
                LocationID = 1,
            };


            context.AdminBookingAllocations.Add(adminAllocationId1);
            context.AdminBookingAllocations.Add(adminAllocationId2);
            context.AdminBookingAllocations.Add(adminAllocationId3);

            var individual1 = new Individual
            {
                IndividualId = 1,
                IndividualBookingStatus = true,
                IndividualEmailAddress = "Test@test.com",
                IndividualFirstName = "TestFirstName",
                IndividualLastName = "TestLastName",
                IndividualMobileNumber = "08000000000"
            };

            var individual2 = new Individual
            {
                IndividualId = 2,
                IndividualBookingStatus = false,
                IndividualEmailAddress = "Test2@test.com",
                IndividualFirstName = "Test2FirstName",
                IndividualLastName = "Test2LastName",
                IndividualMobileNumber = "08000000002"
            };

            var individual3 = new Individual
            {
                IndividualId = 3,
                IndividualBookingStatus = true,
                IndividualEmailAddress = "Test3@test.com",
                IndividualFirstName = "Test3FirstName",
                IndividualLastName = "Test3LastName",
                IndividualMobileNumber = "080000000003"
            };


            context.Individuals.Add(individual1);
            context.Individuals.Add(individual2);
            context.Individuals.Add(individual3);

            var individualLab1 = new IndividualLab
            {
                IndividualLabId = 1,
                TestCompleted = false,
                TestOutCome = string.Empty,
                TestType = "pcrtest",
                IndividualId = 1,
            };
            var individualLab2 = new IndividualLab
            {
                IndividualLabId = 2,
                TestCompleted = true,
                TestOutCome = "negative",
                TestType = "rapidtest",
                IndividualId = 2,
            };

            var individualLab3 = new IndividualLab
            {
                IndividualLabId = 3,
                TestCompleted = true,
                TestOutCome = "Positive",
                TestType = "rapidtest",
                IndividualId = 3,
            };
            #endregion


            context.IndividualLabs.Add(individualLab1);
            context.IndividualLabs.Add(individualLab2);
            context.IndividualLabs.Add(individualLab3);


            context.SaveChanges();

        }
    }
}
