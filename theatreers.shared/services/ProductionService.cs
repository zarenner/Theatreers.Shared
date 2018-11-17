using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theatreers.shared.Models;
using theatreers.shared.Interfaces;

namespace theatreers.shared.Services
{
    public class ProductionService : IProductionService
    {
        public IEnumerable<Production> GetAll()
        {
            throw new NotImplementedException();
        }
        
        public Production GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Production Create(Production item)
        {
            throw new NotImplementedException();
        }
        public Production Update(Production item)
        {
            throw new NotImplementedException();
        }
    
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}