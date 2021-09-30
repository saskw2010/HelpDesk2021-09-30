using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components.Authorization;
using Testauth.Authentication;
using Radzen;

namespace Testauth
{



    
        public partial class Program
    {
        public static string[] args { get; private set; }

        public static async Task Mostafaaddtomain()
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            
            //from here 
            // See: https://docs.microsoft.com/en-us/aspnet/core/security/blazor/webassembly/additional-scenarios?view=aspnetcore-3.1#unauthenticated-or-unauthorized-web-api-requests-in-an-app-with-a-secure-default-client
            builder.Services.AddHttpClient("ServerAPI.NoAuthenticationClient", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

        }
        
    }
}
