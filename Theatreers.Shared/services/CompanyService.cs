using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Theatreers.Shared.Models;
using Theatreers.Shared.Interfaces;

namespace Theatreers.Shared.Services
{
    public class CompanyService : ICompanyService
    {
        public IEnumerable<CompanyModel> GetAll()
        {
            return Enumerable.Empty<CompanyModel>();
        }
        
        public CompanyModel GetById(int id)
        {
            throw new NotImplementedException();
        }
        public CompanyModel Create(CompanyModel item)
        {
            throw new NotImplementedException();
        }
        public CompanyModel Update(CompanyModel item)
        {
            throw new NotImplementedException();
        }
    
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}