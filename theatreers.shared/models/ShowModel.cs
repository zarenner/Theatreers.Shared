using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;


namespace Theatreers.Shared.Models
{
        public class ShowModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime ReleaseDate { get; set; }
    }
}