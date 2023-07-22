using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contracts;

public interface IProductService
{
    Task<IEnumerable<CProductDto>> GetItems();
    Task<CProductDto> GetItem(int id);
}
