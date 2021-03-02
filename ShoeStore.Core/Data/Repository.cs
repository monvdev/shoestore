using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Interfaces;

namespace ShoeStore.Core.Data
{
    public class Repository<T> : IRepository<T>
    {
        public Repository(ShoeStoreContext context) { }
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
