using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System.Net.Http.Json;

namespace ShopOnline.Web.Services;

public class CProductService : IProductService
{
    private readonly HttpClient _httpClient;

    public CProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<CProductDto> GetItem(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<CProductDto>> GetItems()
    {
        try
        {
            // Send get request using httpclient
            var products = await _httpClient.GetFromJsonAsync<IEnumerable<CProductDto>>("api/product");
            return products;
        }
        catch (Exception)
        {

            throw;
        }
    }
}
