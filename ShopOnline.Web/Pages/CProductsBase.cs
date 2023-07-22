using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages;

public class CProductsBase : ComponentBase
{
    [Inject]
    public IProductService? ProductService { get; set; }

    public IEnumerable<CProductDto>? Products { get; set; }

    protected override async Task OnInitializedAsync() // This method is called when the component is first rendered. Similar to OnInit() in Angular
    {
        Products = await ProductService!.GetItems();
    }
}
