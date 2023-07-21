using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositries.Contracts;

namespace ShopOnline.Api.Repositries
{
    public class CProductRepository : IProductRepository
    {
        private readonly CShopOnlineDbContext _shopOnlineDbContext;

        public CProductRepository(CShopOnlineDbContext shopOnlineDbContext)
        {
            _shopOnlineDbContext = shopOnlineDbContext;
        }
        public async Task<IEnumerable<CProductCategory>> GetCategories()
        {
            var categories = await _shopOnlineDbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public Task<CProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CProduct> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CProduct>> GetItems()
        {
            var products = await _shopOnlineDbContext.Products.ToListAsync();
            return products;
        }
    }
}
