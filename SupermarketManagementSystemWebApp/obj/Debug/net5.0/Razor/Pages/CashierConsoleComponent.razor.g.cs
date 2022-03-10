#pragma checksum "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\CashierConsoleComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b46eb5217cbc8aafdd346aeb33e948d3d44dad1"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/cashier_console")]
    public partial class CashierConsoleComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cashier\'s\' Console</h3>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-4");
            __builder.OpenComponent<SupermarketManagementSystemWebApp.Controls.SelectProductForSellingComponent>(5);
            __builder.AddAttribute(6, "OnProductSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CoreBusiness.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CoreBusiness.Product>(this, 
#nullable restore
#line 7 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\CashierConsoleComponent.razor"
                                                             SelectProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n        <br>\r\n        ");
            __builder.OpenComponent<SupermarketManagementSystemWebApp.Controls.SellProductComponent>(8);
            __builder.AddAttribute(9, "SelectedProduct", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CoreBusiness.Product>(
#nullable restore
#line 9 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\CashierConsoleComponent.razor"
                                               selectedProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnProductSold", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CoreBusiness.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CoreBusiness.Product>(this, 
#nullable restore
#line 9 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\CashierConsoleComponent.razor"
                                                                               SellProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.AddMarkupContent(12, "<div class=\"col\">\r\n        Place holder\r\n    </div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\radee\source\repos\SupermarketManagementSystem\SupermarketManagementSystemWebApp\Pages\CashierConsoleComponent.razor"
       
    private Product selectedProduct;

    private void SelectProduct(Product product)
    {
        selectedProduct = product;
    }

    private void SellProduct(Product product)
    {

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
