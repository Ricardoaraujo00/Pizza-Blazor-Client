#pragma checksum "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cd40482dde8e133997d35ff5dcdb44e762b66ed"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 9 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#line 10 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/Myorders")]
    public partial class Myorders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n");
#line 6 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor"
     if (ordersWithStatus == null)
    {
        

#line default
#line hidden
            __builder.AddContent(3, "Loading...");
#line 8 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor"
                               
    }
    else if (ordersWithStatus.Count == 0)
    {

#line default
#line hidden
            __builder.AddContent(4, "        ");
            __builder.AddMarkupContent(5, "<h2>No orders placed</h2>\r\n        ");
            __builder.AddMarkupContent(6, "<a class=\"btn btn-success\" href>Order some pizza</a>\r\n");
#line 14 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor"
    }
    else
    {

#line default
#line hidden
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "list-group orders-list");
            __builder.AddMarkupContent(10, "\r\n");
#line 18 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor"
         foreach (var item in ordersWithStatus)
        {

#line default
#line hidden
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "list-group-item");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "h5");
            __builder.AddContent(19, 
#line 22 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor"
                         item.Order.CreatedTime.ToLongDateString()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    Items:\r\n                    ");
            __builder.OpenElement(21, "strong");
            __builder.AddContent(22, 
#line 24 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor"
                             item.Order.Pizzas.Count()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, ";\r\n                    Total price:\r\n                    ");
            __builder.OpenElement(24, "strong");
            __builder.AddMarkupContent(25, "£");
            __builder.AddContent(26, 
#line 26 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor"
                              item.Order.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col");
            __builder.AddMarkupContent(31, "\r\n                    Status: ");
            __builder.OpenElement(32, "strong");
            __builder.AddContent(33, 
#line 29 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor"
                                     item.StatusText

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col flex-grow-0");
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "href", "myorders/" + (
#line 32 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor"
                                       item.Order.OrderId

#line default
#line hidden
            ));
            __builder.AddAttribute(41, "class", "btn btn-success");
            __builder.AddMarkupContent(42, "\r\n                        Track &gt;\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#line 37 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor"
        }

#line default
#line hidden
            __builder.AddContent(46, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#line 39 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 42 "C:\Users\User\Desktop\Estágio\blazor-workshop\save-points\01-Components-and-layout\BlazingPizza.Client\Pages\Myorders.razor"
       
    List<OrderWithStatus> ordersWithStatus;

    protected override async Task OnParametersSetAsync()
    {
        ordersWithStatus = await HttpClient.GetJsonAsync<List<OrderWithStatus>>("orders");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
