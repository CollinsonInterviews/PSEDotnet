using Marketplace.Repository;
using MarketPlace.Entities;

namespace Marketplace.Core
{
    public class ProductCore : IProductCore
    {
        private readonly IProductRepository _productRepository;
        public ProductCore(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<Product>> GetProducts()
        {
            return await _productRepository.GetProducts();
        }
    }
}