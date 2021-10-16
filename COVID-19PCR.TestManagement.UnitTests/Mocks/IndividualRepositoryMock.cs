using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Domain.Entites;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.UnitTests.Mocks
{
    public class IndividualRepositoryMock
    {
        public static Mock<IIndividualRepository> GetIndividualRepository()
        {
            #region IndividualMockData
            var locationId1 = new Location
            {
                LocationID = 1,
                LocationName = "Lagos, Nigeria"
            };
            var locationId2 = new Location
            {
                LocationID = 2,
                LocationName = "Abuja, Nigeria"
            };

            var AdminBookingAllocationId1 = new AdminBookingAllocation
            {
                AdminBookingAllocationId = 1,
                SpaceAllocated = 50,
                BookingDates = DateTimeOffset.UtcNow.AddDays(2),
                Capacity = 30,
                LocationID = 1,
                Location = locationId1
            };
            var AdminBookingAllocationId2 = new AdminBookingAllocation
            {
                AdminBookingAllocationId = 2,
                SpaceAllocated = 20,
                BookingDates = DateTimeOffset.UtcNow.AddDays(1),
                Capacity = 20,
                LocationID = 2,
                Location = locationId2
            };

            var AdminBookingAllocationId3 = new AdminBookingAllocation
            {
                AdminBookingAllocationId = 3,
                SpaceAllocated = 5,
                BookingDates = DateTimeOffset.UtcNow.AddDays(1),
                Capacity = 20,
                LocationID = 1,
                Location = locationId1


            };
            var individualLists = new List<Individual>
            {
                new Individual
                {
                    IndividualId = 1,
                    IndividualBookingStatus = true,
                    IndividualEmailAddress = "Test@test.com",
                    IndividualFirstName = "TestFirstName",
                    IndividualLastName = "TestLastName",
                    IndividualMobileNumber = "08000000000"
                },
                new Individual
                {
                    IndividualId = 2,
                    IndividualBookingStatus = false,
                    IndividualEmailAddress = "Test2@test.com",
                    IndividualFirstName = "Test2FirstName",
                    IndividualLastName = "Test2LastName",
                    IndividualMobileNumber = "08000000002"
                },
                new Individual
                {
                    IndividualId = 3,
                    IndividualBookingStatus = true,
                    IndividualEmailAddress = "Test3@test.com",
                    IndividualFirstName = "Test3FirstName",
                    IndividualLastName = "Test3LastName",
                    IndividualMobileNumber = "080000000003"
                }
            };
            #endregion

            var mockindividualRepository = new Mock<IIndividualRepository>();
            mockindividualRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(individualLists);
            mockindividualRepository.Setup(repo => repo.AddAsync(It.IsAny<Individual>())).ReturnsAsync(
                (Individual individual) =>
                {
                    individualLists.Add(individual);
                    return individual;
                });
            mockindividualRepository.Setup(repo => repo.DoesIndividualExist(It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync((string emailAddress, string mobilenumber) =>
                {
                    var IndividualExist = individualLists.Any(x => x.IndividualEmailAddress == emailAddress.Trim() &&
                    x.IndividualMobileNumber == mobilenumber.Trim() && x.IndividualBookingStatus == true);
                    return IndividualExist;
                });
            mockindividualRepository.Setup(repo => repo.GetIndividualBookingByEmailAndMobileNo(It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync((string emailAddress, string mobilenumber) =>
                {
                    var Individual = individualLists.Where(x => x.IndividualEmailAddress == emailAddress.Trim() &&
                    x.IndividualMobileNumber == mobilenumber).FirstOrDefault();
                    return Individual;
                });

            return mockindividualRepository;

        }
    }
}
