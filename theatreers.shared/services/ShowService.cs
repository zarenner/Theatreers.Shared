using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theatreers.shared.Models;
using theatreers.shared.Interfaces;

namespace theatreers.shared.Services
{
    public class ShowService : IShowService
    {
        public IQueryable<Show> GetAll()
        {
            throw new NotImplementedException();
        }
        
        public Show GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Show Create(Show item)
        {
            throw new NotImplementedException();
        }
        public void Update(Show item)
        {
            throw new NotImplementedException();
        }
    
        public void Delete(Show item)
        {
            throw new NotImplementedException();
        }
    }
}