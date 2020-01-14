#pragma checksum "C:\Users\User\Desktop\Estágio\Pizza-Blazor-Client\BlazingPizza.Client\Pages\Checkout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9168e3573eadf9a52f3dd6095b1f67c39c5106dd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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