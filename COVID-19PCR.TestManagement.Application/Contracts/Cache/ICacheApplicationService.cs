using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Contracts.Cache
{
    public interface ICacheApplicationService<T> where T : class
    {
        T GetCachedItems(string key);
        void DeleteCachedItems(string key);
        void SetCachedItems(T entry, string key);
        void SetListCachedItems(IEnumerable<T> entry, string key);
        IEnumerable<T> GetCachedItemsList(string key);
    }
}
