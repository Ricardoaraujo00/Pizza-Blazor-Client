#pragma checksum "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9168e3573eadf9a52f3dd6095b1f67c39c5106dd"
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
#line 1 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 9 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#line 10 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkout")]
    public partial class Checkout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 8 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
                         OrderState.Order.DeliveryAddress

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 8 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
                                                                          PlaceOrder

#line default
#line hidden
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "checkout-cols");
                __builder2.AddMarkupContent(10, "\r\n                ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "checkout-order-details");
                __builder2.AddMarkupContent(13, "\r\n                    ");
                __builder2.AddMarkupContent(14, "<h4>Review order</h4>\r\n                    ");
                __builder2.OpenComponent<BlazingPizza.Client.Shared.OrderReview>(15);
                __builder2.AddAttribute(16, "Order", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Order>(
#line 12 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
                                        OrderState.Order

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "checkout-delivery-address");
                __builder2.AddMarkupContent(21, "\r\n                    ");
                __builder2.AddMarkupContent(22, "<h4>Deliver to...</h4>\r\n                    ");
                __builder2.OpenComponent<BlazingPizza.Client.Shared.AddressEditor>(23);
                __builder2.AddAttribute(24, "Address", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Address>(
#line 16 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
                                             OrderState.Order.DeliveryAddress

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n            ");
                __builder2.OpenElement(28, "button");
                __builder2.AddAttribute(29, "class", "checkout-button btn btn-warning");
                __builder2.AddAttribute(30, "Disabled", 
#line 20 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
                                                                       isSubmitting

#line default
#line hidden
                );
                __builder2.AddAttribute(31, "type", "submit");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.AddContent(33, 
#line 21 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
                 sumbitButtonText

#line default
#line hidden
                );
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(36);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 28 "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
       

    public bool isSubmitting = false;
    public string sumbitButtonText = "Place order";
    async Task PlaceOrder()
    {
        await DisableSave();
        var newOrderId = await HttpClient.PostJsonAsync<int>("orders", OrderState.Order);
        OrderState.ResetOrder();


        NavigationManager.NavigateTo($"myorders/{newOrderId}");
    }

    async Task DisableSave()
    {
        isSubmitting = true;
        sumbitButtonText = "Saving...";
        await Task.Delay(1);
    }



#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderState OrderState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
