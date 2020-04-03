using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace BlazingPizza.Client.Auth
{
    public class AuthStateProvider1 : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync() 
        {
            var identity = new ClaimsIdentity();
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity)));
        }
    }
}
