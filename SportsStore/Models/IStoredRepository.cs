using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SportsStore.Models
{
    public interface IStoredRepository
    {
        IQueryable<Product> Products { get; }
    }
}
