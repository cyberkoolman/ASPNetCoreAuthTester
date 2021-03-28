using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SimpleWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogonController : Controller
    {
        [AllowAnonymous]
        public async Task<IActionResult> Index(string returnUrl = "/")
        {
            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, "000000001"));
            identity.AddClaim(new Claim(ClaimTypes.Name, "admin"));

            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal,
                new AuthenticationProperties { IsPersistent = true });

            return Redirect(returnUrl);
        }
    }
}