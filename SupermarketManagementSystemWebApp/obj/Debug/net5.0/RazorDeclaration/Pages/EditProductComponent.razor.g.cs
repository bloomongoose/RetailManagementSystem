// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SupermarketManagementSystemWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\_Imports.razor"
using SupermarketManagementSystemWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\_Imports.razor"
using SupermarketManagementSystemWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editproduct/{productId}")]
    public partial class EditProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\EditProductComponent.razor"
       
    [Parameter]
    public string ProductId { get; set; }

    private Product product;
    private IEnumerable<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();       
        categories = ViewCategoriesUseCase.Execute();
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        if (int.TryParse(this.ProductId, out int iProductId))
        {
            //line below used when using databases
            //this.product = GetProductByIdUseCase.Execute(iProductId);

            //lines below used when using in-memory storage
            var prod = GetProductByIdUseCase.Execute(iProductId);
            this.product = new Product { 
                ProductId = prod.ProductId, 
                Name = prod.Name,
                CategoryId = prod.CategoryId,
                Price = prod.Price,
                Quantity = prod.Quantity
            };
        }
    }

    private void OnValidSubmit()
    {
        EditProductUseCase.Execute(this.product);
        NavigationManager.NavigateTo("/products");
    }

    private void OnCancel()
    {
        NavigationManager.NavigateTo("/products");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IViewCategoriesUseCase ViewCategoriesUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IEditProductUseCase EditProductUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IGetProductByIdUseCase GetProductByIdUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IAddProductUseCase AddProductUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591