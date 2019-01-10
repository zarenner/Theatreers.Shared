using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Theatreers.Shared.Models;
using Theatreers.Shared.Interfaces;

namespace Theatreers.Shared.Services
{
    public class ShowService : IShowService
    {
        public IEnumerable<ShowModel> GetAll()
        {
            return Enumerable.Empty<ShowModel>();            
        }
        
        public ShowModel GetById(int id)
        {
            throw new NotImplementedException();
        }
        public ShowModel Create(ShowModel item)
        {
            throw new NotImplementedException();
        }
        public ShowModel Update(ShowModel item)
        {
            throw new NotImplementedException();
        }
    
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}