#pragma checksum "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c112bbfcec95a8caa5e7a5268cfe5682ffe4254"
// <auto-generated/>
#pragma warning disable 1591
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
using SupermarketManagementSystemWebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class ProductsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Products</h3>\r\n<br>");
#nullable restore
#line 10 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor"
 if (products != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Product Category</th>\r\n                <th>Product Name</th>\r\n                <th>Price</th>\r\n                <th>Quantity</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 23 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 26 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor"
                         GetCategoryByIdUseCase.Execute(product.CategoryId).Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 27 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor"
                         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 28 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor"
                          Math.Round(product.Price, 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 29 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor"
                         product.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "class", "btn btn-link");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor"
                                                                               ()=>OnEditProduct(product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        &nbsp;\r\n                        ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "btn btn-link");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor"
                                                                               ()=>OnDeleteProduct(product.ProductId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<br>\r\n");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor"
                                OnClickAddProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddContent(35, "Add Product");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\ProductsComponent.razor"
       

    private IEnumerable<Product> products;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        products = ViewProductsUseCase.Execute();
    }

    private void OnClickAddProduct()
    {
        NavigationManager.NavigateTo("/addproduct");
    }

    private void OnEditProduct(Product product)
    {
        NavigationManager.NavigateTo($"/editproduct/{product.ProductId}");
    }

    private void OnDeleteProduct(int productId)
    {
        DeleteProductUseCase.Execute(productId);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IDeleteProductUseCase DeleteProductUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IGetCategoryByIdUseCase GetCategoryByIdUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IViewProductsUseCase ViewProductsUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
