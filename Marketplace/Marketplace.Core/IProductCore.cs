using MarketPlace.Entities;

namespace Marketplace.Core
{
    public interface IProductCore
    {
        public Task<List<Product>> GetProducts();
    }
}
