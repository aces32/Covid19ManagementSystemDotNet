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
    public class IndividualLabRepositoryMock
    {
        public static Mock<IIndividualLabRepository> GetIndividualLabRepository()
        {
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
                IndividualBookingStatus = true,
                IndividualEmailAddress = "Test2@test.com",
                IndividualFirstName = "Test2FirstName",
                IndividualLastName = "Test2LastName",
                IndividualMobileNumber = "08000000002"
            };

            var individual3 = new Individual
            {
                IndividualId = 3,
                IndividualBookingStatus = false,
                IndividualEmailAddress = "Test3@test.com",
                IndividualFirstName = "Test3FirstName",
                IndividualLastName = "Test3LastName",
                IndividualMobileNumber = "080000000003"
            };


            var individualLabList = new List<IndividualLab>
            {
                new IndividualLab
                {
                    IndividualLabId = 1,
                    TestCompleted = false,
                    TestOutCome = string.Empty,
                    TestType = "pcrtest",
                    IndividualId = 1,
                    Individual = individual1
                },
                new IndividualLab
                {
                    IndividualLabId = 2,
                    TestCompleted = true,
                    TestOutCome = "negative",
                    TestType = "rapidtest",
                    IndividualId = 2,
                    Individual = individual2
                },
                new IndividualLab
                {
                    IndividualLabId = 3,
                    TestCompleted = true,
                    TestOutCome = "Positive",
                    TestType = "rapidtest",
                    IndividualId = 3,
                    Individual = individual3
                }
            };

            var mockindividualLabRepository = new Mock<IIndividualLabRepository>();
            mockindividualLabRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(individualLabList);

            mockindividualLabRepository.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(
                (int individualLabId) =>
                {
                    return individualLabList.Where(x => x.IndividualId == individualLabId).FirstOrDefault();
                });

            mockindividualLabRepository.Setup(repo => repo.UpdateAsync(It.IsAny<IndividualLab>()));

            return mockindividualLabRepository;

        }
    }
}
