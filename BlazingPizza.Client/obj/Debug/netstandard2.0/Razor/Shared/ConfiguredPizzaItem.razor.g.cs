#pragma checksum "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20f043bc5bc085355bd0e4be0c0d86316ec5a01c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 9 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#line 10 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
#line 11 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary.Map;

#line default
#line hidden
#line 12 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingComponents;

#line default
#line hidden
    public partial class ConfiguredPizzaItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "cart-item");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 2 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                  OnRemoved

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", "delete-item");
            __builder.AddContent(5, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "title");
            __builder.AddContent(9, 
#line 3 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                         Pizza.Size

#line default
#line hidden
            );
            __builder.AddContent(10, "\" ");
            __builder.AddContent(11, 
#line 3 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                                       Pizza.Special.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "ul");
#line 5 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
         foreach (var topping in Pizza.Toppings)
        {

#line default
#line hidden
            __builder.OpenElement(14, "li");
            __builder.AddContent(15, "+ ");
            __builder.AddContent(16, 
#line 7 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                   topping.Topping.Name

#line default
#line hidden
            );
            __builder.CloseElement();
#line 8 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
        }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "item-price");
            __builder.AddContent(20, 
#line 11 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
         Pizza.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 15 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
       
    [Parameter] public Pizza Pizza { get; set; }
    [Parameter] public EventCallback OnRemoved { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
