using System;
using System.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

using Testauth.Authentication;

namespace Testauth.Controllers
{
    public partial class AccountController : Controller
    {
        [HttpGet("account/login")]
        public IActionResult Login()
        {
            var handler = new JwtSecurityTokenHandler();
            var subject = new ClaimsIdentity();

            var identity = User.Identity as WindowsIdentity;

            subject.AddClaim(new Claim(ClaimTypes.Name, identity.Name));

            var groups = identity.Groups.Translate(typeof(NTAccount));

            foreach (var group in groups)
            {
                subject.AddClaim(new Claim(ClaimTypes.Role, group.Value.Split("\\").Last()));
                subject.AddClaim(new Claim(ClaimTypes.Role, group.Value));
            }

            var token = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = TokenProviderOptions.Issuer,
                Audience = TokenProviderOptions.Audience,
                SigningCredentials = TokenProviderOptions.SigningCredentials,
                Subject = subject,
                Expires = DateTime.UtcNow.Add(TokenProviderOptions.Expiration)
            });

            return Json(new
            {
                access_token = handler.WriteToken(token),
                expires_in = TokenProviderOptions.Expiration.TotalSeconds
            });
        }
    }
}
