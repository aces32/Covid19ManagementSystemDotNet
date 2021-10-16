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
    public class LocationRepositoryMock
    {
        public static Mock<ILocationRepository> GetLocationRepository()
        {
            var locationLists = new List<Location>
            {
                new Location
                {
                    LocationID = 1,
                    LocationName = "Lagos, Nigeria"
                },
                new Location
                {
                    LocationID = 2,
                    LocationName = "Abuja, Nigeria"
                }
            };

            var mockGasSizeRepository = new Mock<ILocationRepository>();
            mockGasSizeRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(locationLists);
            mockGasSizeRepository.Setup(repo => repo.DoesLocationExist(It.IsAny<int>()))
                .ReturnsAsync((int locationID) =>
                {
                    var locationExist = locationLists.Any(x => x.LocationID == locationID);
                    return locationExist;
                });
            return mockGasSizeRepository;
        }
    }
}

