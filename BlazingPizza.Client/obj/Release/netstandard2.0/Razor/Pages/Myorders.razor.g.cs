#pragma checksum "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Myorders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b66c5baf90dacff5d0af127f58f8b96b053182c6"
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
#line 1 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 9 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#line 10 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
#line 11 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary.Map;

#line default
#line hidden
#line 12 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingComponents;

#line default
#line hidden
#line 1 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Myorders.razor"
           [Authorize]

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
            __Blazor.BlazingPizza.Client.Pages.Myorders.TypeInference.CreateTemplatedList_0(__builder, 3, 4, 
#line 7 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Myorders.razor"
                        LoadOrders

#line default
#line hidden
            , 5, "orders-list", 6, (__builder2) => {
                __builder2.AddContent(7, "Loading...");
            }
            , 8, (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<h2>No orders placed</h2>\r\n            ");
                __builder2.AddMarkupContent(11, "<a class=\"btn btn-success\" href>Order some pizza</a>\r\n        ");
            }
            , 12, (item) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenElement(17, "h5");
                __builder2.AddContent(18, 
#line 15 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Myorders.razor"
                     item.Order.CreatedTime.ToLongDateString()

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                Items:\r\n                ");
                __builder2.OpenElement(20, "strong");
                __builder2.AddContent(21, 
#line 17 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Myorders.razor"
                         item.Order.Pizzas.Count()

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, ";\r\n                Total price:\r\n                ");
                __builder2.OpenElement(23, "strong");
                __builder2.AddMarkupContent(24, "£");
                __builder2.AddContent(25, 
#line 19 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Myorders.razor"
                          item.Order.GetFormattedTotalPrice()

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col");
                __builder2.AddMarkupContent(30, "\r\n                Status: ");
                __builder2.OpenElement(31, "strong");
                __builder2.AddContent(32, 
#line 22 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Myorders.razor"
                                 item.StatusText

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col flex-grow-0");
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenElement(38, "a");
                __builder2.AddAttribute(39, "href", "myorders/" + (
#line 25 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Myorders.razor"
                                   item.Order.OrderId

#line default
#line hidden
                ));
                __builder2.AddAttribute(40, "class", "btn btn-success");
                __builder2.AddMarkupContent(41, "\r\n                    Track &gt;\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 33 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Myorders.razor"
       
    Task<List<OrderWithStatus>> LoadOrders()
    {
        return HttpClient.GetJsonAsync<List<OrderWithStatus>>("orders");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
namespace __Blazor.BlazingPizza.Client.Pages.Myorders
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTemplatedList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<TItem>>> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg4)
        {
        __builder.OpenComponent<global::BlazingComponents.TemplatedList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Loader", __arg0);
        __builder.AddAttribute(__seq1, "ListGroupClass", __arg1);
        __builder.AddAttribute(__seq2, "Loading", __arg2);
        __builder.AddAttribute(__seq3, "Empty", __arg3);
        __builder.AddAttribute(__seq4, "Item", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591