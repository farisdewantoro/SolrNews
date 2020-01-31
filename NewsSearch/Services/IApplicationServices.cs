using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSearch.Services
{
    public interface IApplicationServices<T> where T:class
    {
 
        T Get(Guid id);
        T Insert(T dto);
        T Delete(Guid id);
        T Update(T dto);
        IEnumerable<T> GetAll();
    }
}
