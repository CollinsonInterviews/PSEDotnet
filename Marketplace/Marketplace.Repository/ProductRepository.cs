using MarketPlace.Entities;

namespace Marketplace.Repository
{
    public class ProductRepository : IProductRepository
    {
        public async Task<List<Product>> GetProducts()
        {
            return await Task.FromResult(
                 new List<Product> { new Product { Id = 1, Name = "SSD" } }
                );
        }
    }
}