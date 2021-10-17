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
    public class AdminBookingAllocationRepositoryMock
    {
        public static Mock<IAdminBookingAllocationRepository> GetAdminBookingAllocationRepository()
        {
            #region AdminBookingAllocationMockData
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
                    IndividualBookingStatus = true,
                    IndividualEmailAddress = "Test2@test.com",
                    IndividualFirstName = "Test2FirstName",
                    IndividualLastName = "Test2LastName",
                    IndividualMobileNumber = "08000000002"
                },
                new Individual
                {
                    IndividualId = 3,
                    IndividualBookingStatus = false,
                    IndividualEmailAddress = "Test3@test.com",
                    IndividualFirstName = "Test3FirstName",
                    IndividualLastName = "Test3LastName",
                    IndividualMobileNumber = "080000000003"
                }
            };

            var adminBookingAllocationList = new List<AdminBookingAllocation>
            {
                new AdminBookingAllocation
                {
                    AdminBookingAllocationId = 1,
                    SpaceAllocated = 50,
                    BookingDates = DateTimeOffset.UtcNow.AddDays(2),
                    Capacity = 30,
                    LocationID = 1,
                    Location = locationId1,
                    Individuals = individualLists
                },
                new AdminBookingAllocation
                {
                    AdminBookingAllocationId = 2,
                    SpaceAllocated = 20,
                    BookingDates = DateTimeOffset.UtcNow.AddDays(1),
                    Capacity = 20,
                    LocationID = 2,
                    Location = locationId2,
                    Individuals = individualLists
                },
                new AdminBookingAllocation
                {
                    AdminBookingAllocationId = 3,
                    SpaceAllocated = 5,
                    BookingDates = DateTimeOffset.UtcNow.AddDays(1),
                    Capacity = 20,
                    LocationID = 1,
                    Location = locationId1,
                    Individuals = individualLists
                }
            };
            #endregion

            var mockAdminBookingRepository = new Mock<IAdminBookingAllocationRepository>();
            mockAdminBookingRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(adminBookingAllocationList);
            mockAdminBookingRepository.Setup(repo => repo.UpdateAsync(It.IsAny<AdminBookingAllocation>()));
            mockAdminBookingRepository.Setup(repo => repo.AddAsync(It.IsAny<AdminBookingAllocation>())).ReturnsAsync(
                (AdminBookingAllocation adminBookingAllocation) =>
                {
                    adminBookingAllocationList.Add(adminBookingAllocation);
                    return adminBookingAllocation;
                });
            mockAdminBookingRepository.Setup(repo => repo.GetAllRecentAvailableBookings())
                .ReturnsAsync(() =>
                {
                    return adminBookingAllocationList.Where(x => x.BookingDates > DateTime.Now.AddDays(-1) &&
                                            x.Capacity > x.SpaceAllocated).ToList();
                });

            mockAdminBookingRepository.Setup(repo => repo.GetAdminBookingAllocationByLocationIdandBookingDate(It.IsAny<int>(), It.IsAny<DateTimeOffset>()))
                .ReturnsAsync((int locationID, DateTimeOffset bookingDate) =>
                {
                    return adminBookingAllocationList.Where(x => x.LocationID == locationID &&
                                            x.BookingDates.Date == bookingDate.Date).FirstOrDefault();
                });

            mockAdminBookingRepository.Setup(repo => repo.DoesBookingExist(It.IsAny<int>(), It.IsAny<DateTimeOffset>()))
                .ReturnsAsync((int locationId, DateTimeOffset bookingDate) =>
                {
                    var bookingExist = adminBookingAllocationList.Any(x => x.LocationID == locationId &&
                    x.BookingDates.Date == bookingDate.Date);
                    return bookingExist;
                });


            mockAdminBookingRepository.Setup(repo => repo.GetAdminBookingAllocationHistorybyBookingDates(It.IsAny<DateTimeOffset>(), It.IsAny<DateTimeOffset>(),
                                            It.IsAny<int>(), It.IsAny<int>()))
                .ReturnsAsync((DateTimeOffset StartDate, DateTimeOffset EndDate, int page, int size) =>
                {
                    return adminBookingAllocationList.Where(s => (s.BookingDates >= StartDate && s.BookingDates <= EndDate))
                                        .Skip((page - 1) * size).Take(size).ToList();
                });

            return mockAdminBookingRepository;
        }

    }
}
