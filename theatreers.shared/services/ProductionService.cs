using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Theatreers.Shared.Models;
using Theatreers.Shared.Interfaces;

namespace Theatreers.Shared.Services
{
    public class ProductionService : IProductionService
    {
        public IEnumerable<ProductionModel> GetAll()
        {
            throw new NotImplementedException();
        }
        
        public ProductionModel GetById(int id)
        {
            throw new NotImplementedException();
        }
        public ProductionModel Create(ProductionModel item)
        {
            throw new NotImplementedException();
        }
        public ProductionModel Update(ProductionModel item)
        {
            throw new NotImplementedException();
        }
    
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}