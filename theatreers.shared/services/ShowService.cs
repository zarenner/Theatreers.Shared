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
        public IEnumerable<ShowModel> GetAll()
        {
            throw new NotImplementedException();
        }
        
        public Show GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Show Create(ShowModel item)
        {
            throw new NotImplementedException();
        }
        public Show Update(ShowModel item)
        {
            throw new NotImplementedException();
        }
    
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}