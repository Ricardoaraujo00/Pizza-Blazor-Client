#pragma checksum "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fce8169a46d78405df15f282122b59eb2626eceb"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkout")]
    public partial class Checkout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((authContext) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.AddMarkupContent(6, "<h2>Redirecting you...</h2>\r\n        ");
            }
            ));
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((authContext) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
                __builder2.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 14 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
                             OrderState.Order.DeliveryAddress

#line default
#line hidden
                ));
                __builder2.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 14 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
                                                                              PlaceOrder

#line default
#line hidden
                )));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n                ");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "checkout-cols");
                    __builder3.AddMarkupContent(16, "\r\n                    ");
                    __builder3.OpenElement(17, "div");
                    __builder3.AddAttribute(18, "class", "checkout-order-details");
                    __builder3.AddMarkupContent(19, "\r\n                        ");
                    __builder3.AddMarkupContent(20, "<h4>Review order</h4>\r\n                        ");
                    __builder3.OpenComponent<BlazingPizza.Client.Shared.OrderReview>(21);
                    __builder3.AddAttribute(22, "Order", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Order>(
#line 18 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
                                            OrderState.Order

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(24, "\r\n                    ");
                    __builder3.OpenElement(25, "div");
                    __builder3.AddAttribute(26, "class", "checkout-delivery-address");
                    __builder3.AddMarkupContent(27, "\r\n                        ");
                    __builder3.AddMarkupContent(28, "<h4>Deliver to...</h4>\r\n                        ");
                    __builder3.OpenComponent<BlazingPizza.Client.Shared.AddressEditor>(29);
                    __builder3.AddAttribute(30, "Address", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Address>(
#line 22 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
                                                 OrderState.Order.DeliveryAddress

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(32, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\r\n\r\n                ");
                    __builder3.OpenElement(34, "button");
                    __builder3.AddAttribute(35, "class", "checkout-button btn btn-warning");
                    __builder3.AddAttribute(36, "Disabled", 
#line 26 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
                                                                           isSubmitting

#line default
#line hidden
                    );
                    __builder3.AddAttribute(37, "type", "submit");
                    __builder3.AddMarkupContent(38, "\r\n                    ");
                    __builder3.AddContent(39, 
#line 27 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
                     sumbitButtonText

#line default
#line hidden
                    );
                    __builder3.AddMarkupContent(40, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(42);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 36 "C:\Users\ricar\OneDrive\Pessoal\Área de Trabalho\Projectos\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor"
       
    [CascadingParameter] Task<AuthenticationState> AuthenticationStateTask { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateTask;
        if (!authState.User.Identity.IsAuthenticated)
        {
            await LocalStorage.SetAsync(JSRuntime, "currentorder", OrderState.Order);
            // The server won't accept orders from unauthenticated users, so avoid
            // an error by making them log in at this point
            NavigationManager.NavigateTo("user/signin?redirectUri=/checkout", true);
        }
        // Try to recover any temporary saved order
        if (!OrderState.Order.Pizzas.Any())
        {
            var savedOrder = await LocalStorage.GetAsync<Order>(JSRuntime, "currentorder");
            if (savedOrder != null)
            {
                OrderState.ReplaceOrder(savedOrder);
                await LocalStorage.DeleteAsync(JSRuntime, "currentorder");
            }
            else
            {
                // There's nothing check out - go to home
                NavigationManager.NavigateTo("");
            }
        }
    }

    // Leave PlaceOrder unchanged here
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderState OrderState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591