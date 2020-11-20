﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Twitter;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Security.Claims;

namespace BlazingPizza.Server
{
    [ApiController]
    public class UserController : Controller
    {
        private static UserInfo LoggedOutUser = new UserInfo { IsAuthenticated = false };

        [HttpGet("user")]
        public UserInfo GetUser()
        {
            return User.Identity.IsAuthenticated
                ? new UserInfo { Name = User.Identity.Name, IsAuthenticated = true }
                : LoggedOutUser;
        }

        [HttpGet("user/signin")]
        public async Task SignIn(string redirectUri)
        {
            if (string.IsNullOrEmpty(redirectUri) || !Url.IsLocalUrl(redirectUri))
            {
                redirectUri = "/";
            }

            await HttpContext.ChallengeAsync(
                Microsoft.AspNetCore.Authentication.Google
                .GoogleDefaults.AuthenticationScheme,
                new AuthenticationProperties { RedirectUri = redirectUri });

        }

        [HttpGet("user/picture")]
        public string GetPicture()
        {
            string picurl =  User.FindFirstValue("profilepic");
            return picurl;
        }
        

        [HttpGet("user/signout")]
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("~/");
        }
    }
}
