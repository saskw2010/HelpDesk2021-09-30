using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

using Testauth.Models;

namespace Testauth
{
    public partial class SecurityService
    {
        public event Action Authenticated;

        private ApplicationUser user;

        public ClaimsPrincipal Principal { get; set; }

        public async Task<bool> InitializeAsync(AuthenticationStateProvider authenticationStateProvider)
        {
            var authenticationState = await authenticationStateProvider.GetAuthenticationStateAsync();

            Principal = authenticationState.User;

            if (user == null)
            {
                var name = Principal.Identity.Name;
                user = new ApplicationUser { Name = name };
            }

            var result = IsAuthenticated();

            if (result)
            {
                Authenticated?.Invoke();
            }

            return result;
        }

        public ApplicationUser User
        {
            get
            {
                if (Principal == null)
                {
                    return new ApplicationUser { Name = "Anonymous" };
                }

                return user;
            }
        }

        public bool IsAuthenticated()
        {
            return Principal != null ? Principal.Identity.IsAuthenticated : false;
        }

        public bool IsInRole(params string[] roles)
        {
            if (!IsAuthenticated())
            {
                return false;
            }

            if (roles.Contains("Authenticated"))
            {
                return true;
            }

            return roles.Any(role => Principal.IsInRole(role));
        }
    }
}
