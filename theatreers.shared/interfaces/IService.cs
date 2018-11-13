using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theatreers.shared.Interfaces
{
    public interface IService<T> where T : class
    {
        IQueryable<T> GetAll();

        //IQueryable<T> Find(Func<T, bool> predicate);

        T GetById(int id);

        T Create(T entity);

       // void Update(T entity);

        void Delete(T entity);

        //int Count(Func<T, bool> predicate);
    }
}