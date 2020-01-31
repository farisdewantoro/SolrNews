using Microsoft.EntityFrameworkCore;
using NewsSearch.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSearch.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext db;
        private DbSet<T> table;
        private bool _disposed;

        public GenericRepository(AppDbContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }
     

        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public T Get(object id)
        {
            return table.Find(id);
        }
        public void Delete(object id)
        {
           T existing = Get(id);
           table.Remove(existing);
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }
        public void CreateTransaction()
        {
            db.Database.BeginTransaction();
        }
        public int Save()
        {
            return db.SaveChanges();
        }
        public void Commit()
        {
            db.Database.CommitTransaction();
        }
        public void Rollback()
        {
            db.Database.RollbackTransaction();
            db.Dispose();
        }

    

    }
}
