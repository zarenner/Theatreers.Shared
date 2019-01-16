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
            List<ShowModel> listOfShows = new List<ShowModel>();

            listOfShows.Add(new ShowModel() { 
                Id = 1,
                Name = "Phantom of the Opera",
                ReleaseDate = DateTime.Parse("1986-10-09")
            });

            listOfShows.Add(new ShowModel() { 
                Id = 2,
                Name = "Hamilton",
                ReleaseDate = DateTime.Parse("2015-02-17")
            });

            listOfShows.Add(new ShowModel() { 
                Id = 3,
                Name = "Les Misérables",
                ReleaseDate = DateTime.Parse("1985-10-08")
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