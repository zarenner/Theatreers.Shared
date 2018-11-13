using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theatreers.shared.Models;

namespace theatreers.shared.Interfaces
{
    public interface IProductionService : IService<Production>
    {
        IQueryable<Production> FindWithVenue(Func<Production, bool> predicate);
    }
}