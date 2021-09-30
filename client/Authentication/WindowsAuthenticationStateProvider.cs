using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Text.Json;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components.Authorization;

namespace Testauth.Authentication
{
    public class WindowsAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly Uri baseAddress;
        private readonly IJSRuntime jsRuntime;

        public WindowsAuthenticationStateProvider(string baseAddress, IJSRuntime jsRuntime)
        {
            this.baseAddress = new Uri(baseAddress);
            this.jsRuntime = jsRuntime;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            // Next line needed to prevent: https://github.com/mono/linker/issues/870
            var payload = new JwtPayload();

            var token = await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "TestauthToken");

            if (string.IsNullOrWhiteSpace(token))
            {
                var httpClient = new HttpClient();

                token = await httpClient.GetStringAsync(new Uri(baseAddress, "account/login"));

                await jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "TestauthToken", token);
            }

            if (string.IsNullOrWhiteSpace(token))
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }

            var json = JsonSerializer.Deserialize<Dictionary<string, object>>(token);

            var jwt = new JwtSecurityTokenHandler().ReadJwtToken(json["access_token"].ToString());

            var principal = new ClaimsPrincipal(new ClaimsIdentity(jwt.Claims, "jwt", "unique_name", "role"));

            return new AuthenticationState(principal);
        }
    }
}
