using COVID_19PCR.TestManagement.Application.Contracts.Cache;
using Moq;
using System.Collections.Generic;

namespace COVID_19PCR.TestManagement.UnitTests.Mocks
{
    public class CacheApplicationServiceMock<T> where T : class
    {
        public static Mock<ICacheApplicationService<T>> GetCacheApplicationService()
        {
            var mockCacheApplicationService = new Mock<ICacheApplicationService<T>>();
            mockCacheApplicationService.Setup(repo => repo.GetCachedItems(It.IsAny<string>()));
            mockCacheApplicationService.Setup(repo => repo.GetCachedItemsList(It.IsAny<string>()));
            mockCacheApplicationService.Setup(repo => repo.SetCachedItems(It.IsAny<T>(), It.IsAny<string>()));
            mockCacheApplicationService.Setup(repo => repo.SetListCachedItems(It.IsAny<List<T>>(), It.IsAny<string>()));
            return mockCacheApplicationService;
        }
    }
}
