using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Core.Interfaces
{
    public interface IRepository<T>
    {
        T Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IList<T> GetAll();
        T GetById(int id);
    }
}
