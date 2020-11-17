#pragma checksum "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d3939c669da02da113ba3390c7c50bc9e621cc2"
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
#line 6 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
using BlazingComponents;

#line default
#line hidden
#line 7 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
using BlazingPizza.Client;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "pizza-cards");
#line 11 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
         if (specials != null)
        {
            

#line default
#line hidden
#line 13 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
             foreach (var special in specials)
            {

#line default
#line hidden
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 15 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                                () => OrderState.ShowConfigurePizzaDialog(special)

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "style", "background-image:" + " url(\'" + (
#line 15 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                                                                                                                    special.ImageUrl

#line default
#line hidden
            ) + "\')");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "pizza-info");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "title");
            __builder.AddContent(11, 
#line 17 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                                             special.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                        ");
            __builder.AddContent(13, 
#line 18 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                         special.Description

#line default
#line hidden
            );
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", "price");
            __builder.AddContent(17, 
#line 19 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                                             special.GetFormattedBasePrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#line 22 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
            }

#line default
#line hidden
#line 22 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
             
        }

#line default
#line hidden
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "sidebar");
#line 28 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
     if (OrderState.Order.Pizzas.Any())
    {

#line default
#line hidden
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "order-contents");
            __builder.AddMarkupContent(23, "<h2>Your order</h2>\r\n            ");
            __builder.OpenElement(24, "h1");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 32 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                            () => count101++

#line default
#line hidden
            ));
            __builder.AddContent(26, 
#line 32 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                                                count101

#line default
#line hidden
            );
            __builder.CloseElement();
#line 34 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
             foreach (var configuredPizza in OrderState.Order.Pizzas)
            {

#line default
#line hidden
            __builder.OpenComponent<BlazingPizza.Client.Shared.ConfiguredPizzaItem>(27);
            __builder.AddAttribute(28, "Pizza", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Pizza>(
#line 36 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                                            configuredPizza

#line default
#line hidden
            ));
            __builder.AddAttribute(29, "OnRemoved", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 36 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                                                                          () => RemovePizza(configuredPizza)

#line default
#line hidden
            )));
            __builder.CloseComponent();
#line 37 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
            }

#line default
#line hidden
            __builder.CloseElement();
#line 39 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
            __builder.AddMarkupContent(30, "<div class=\"empty-cart\">Choose a pizza<br>to get started</div>");
#line 43 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
    }

#line default
#line hidden
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "order-total" + " " + (
#line 45 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                              OrderState.Order.Pizzas.Any() ? "" : "hidden"

#line default
#line hidden
            ));
            __builder.AddMarkupContent(33, "\r\n        Total:\r\n        ");
            __builder.OpenElement(34, "span");
            __builder.AddAttribute(35, "class", "total-price");
            __builder.AddContent(36, 
#line 47 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                                   OrderState.Order.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "checkout");
            __builder.AddAttribute(40, "class", "btn btn-warning");
            __builder.AddAttribute(41, "disabled", 
#line 48 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                                                               OrderState.Order.Pizzas.Count == 0

#line default
#line hidden
            );
            __builder.AddMarkupContent(42, "\r\n            Order \r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n");
            __builder.OpenComponent<BlazingComponents.TemplatedDialog>(44);
            __builder.AddAttribute(45, "Show", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 54 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                       OrderState.ShowingConfigureDialog

#line default
#line hidden
            ));
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazingPizza.Client.ConfigurePizzaDialog>(47);
                __builder2.AddAttribute(48, "Pizza", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Pizza>(
#line 55 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                                 OrderState.ConfiguringPizza

#line default
#line hidden
                ));
                __builder2.AddAttribute(49, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 56 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                                    OrderState.CancelConfigurePizzaDialog

#line default
#line hidden
                )));
                __builder2.AddAttribute(50, "OnConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 57 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
                                     OrderState.ConfirmConfigurePizzaDialog

#line default
#line hidden
                )));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 61 "C:\Users\ricar\source\repos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Index.razor"
       
    List<PizzaSpecial> specials;
    int count101 = 101;


    protected async override Task OnInitializedAsync()
    {
        specials = await HttpClient.GetJsonAsync<List<PizzaSpecial>>("specials");
    }

    async Task RemovePizza(Pizza configuredPizza)
    {
        if (await JS.Confirm($"Remove {configuredPizza.Special.Name} pizza from the order?"))
        {
            OrderState.RemoveConfiguredPizza(configuredPizza);
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderState OrderState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
