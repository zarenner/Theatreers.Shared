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
            listOfShows = new list<ShowModel>();

            listOfShows.Add(new ShowModel() { 
                Id = 1,
                Name = "Phantom of the Opera",
                ReleaseDate = DateTime.Parse("09/10/1986")
            });

            listOfShows.Add(new ShowModel() { 
                Id = 2,
                Name = "Hamilton",
                ReleaseDate = DateTime.Parse("17/02/2015")
            });

            listOfShows.Add(new ShowModel() { 
                Id = 3,
                Name = "Les Misérables",
                ReleaseDate = DateTime.Parse("08/10/1985")
            });

            return listOfShows;           
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