using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theatreers.shared.Models;
using theatreers.shared.Interfaces;

namespace theatreers.shared.Services
{
    public class CompanyService : ICompanyService
    {
        public IEnumerable<CompanyModel> GetAll()
        {
            throw new NotImplementedException();
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