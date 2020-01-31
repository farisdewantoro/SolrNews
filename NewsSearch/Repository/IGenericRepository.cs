using System.Collections.Generic;

namespace NewsSearch.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        void Delete(object id);
        T Get(object id);
        IEnumerable<T> GetAll();
        void Insert(T obj);
        int Save();
        void Update(T obj);
        void Rollback();
        void CreateTransaction();
        void Commit();
    }
}