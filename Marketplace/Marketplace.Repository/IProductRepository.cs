using MarketPlace.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Repository
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetProducts();
    }
}
