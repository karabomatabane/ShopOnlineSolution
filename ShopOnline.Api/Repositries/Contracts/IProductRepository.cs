using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Repositries.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<CProduct>> GetItems();
        Task<IEnumerable<CProductCategory>> GetCategories();
        Task<CProduct> GetItem(int id);
        Task<CProductCategory> GetCategory(int id);
    }
}
