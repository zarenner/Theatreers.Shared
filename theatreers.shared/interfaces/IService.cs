using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theatreers.shared.Interfaces
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();

        //IQueryable<T> Find(Func<T, bool> predicate);

        T GetById(int id);

        T Create(T entity);

        T Update(T entity);

        void Delete(int id);

        //int Count(Func<T, bool> predicate);
    }
}