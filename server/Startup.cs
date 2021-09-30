using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Testauth.Data;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Builder;
namespace Testauth
{
    public partial class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        partial void OnConfigureServices(IServiceCollection services);

        partial void OnConfiguringServices(IServiceCollection services);

        public void ConfigureServices(IServiceCollection services)
        {
            OnConfiguringServices(services);

            services.AddHttpContextAccessor();
            services.AddCors(options =>
            {
                options.AddPolicy(
                    "AllowAny",
                    x =>
                    {
                        x.AllowAnyHeader()
                        .AllowAnyMethod()
                        .SetIsOriginAllowed(isOriginAllowed: _ => true)
                        .AllowCredentials();
                    });
            });
            services.AddOData();
            services.AddODataQueryFilter();
            services.AddAuthorization(options =>
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
            }).AddApiAuthorization();
            services.AddAuthentication(NegotiateDefaults.AuthenticationScheme).AddNegotiate();
            services.AddScoped<SecurityService>();

            services.AddDbContext<Testauth.Data.AuthenticationconnContext>(options =>
            {
              options.UseSqlServer(Configuration.GetConnectionString("authenticationconnConnection"));
            });

            services.AddRazorPages();
            services.AddLocalization();

            var supportedCultures = new[]
            {
                new System.Globalization.CultureInfo("ar-KW"),
                new System.Globalization.CultureInfo("en-US"),
                new System.Globalization.CultureInfo("fr-CA"),
            };

            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en-US");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            OnConfigureServices(services);
        }

        partial void OnConfigure(IApplicationBuilder app, IWebHostEnvironment env);
        partial void OnConfigureOData(ODataConventionModelBuilder builder);
        partial void OnConfiguring(IApplicationBuilder app, IWebHostEnvironment env);

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            OnConfiguring(app, env);

            var supportedCultures = new[]
            {
                new System.Globalization.CultureInfo("ar-KW"),
                new System.Globalization.CultureInfo("en-US"),
                new System.Globalization.CultureInfo("fr-CA"),
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en-US"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            if (env.IsDevelopment())
            {
                Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.Use((ctx, next) =>
                {
                    ctx.Request.Scheme = "https";
                    return next();
                });
            }
            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            IServiceProvider provider = app.ApplicationServices.GetRequiredService<IServiceProvider>();
            app.UseCors("AllowAny");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
                endpoints.Count().Filter().OrderBy().Expand().Select().MaxTop(null).SetTimeZoneInfo(TimeZoneInfo.Utc);

                var oDataBuilder = new ODataConventionModelBuilder(provider);

                oDataBuilder.EntitySet<Testauth.Models.Authenticationconn.DeviceCode>("DeviceCodes");
                oDataBuilder.EntitySet<Testauth.Models.Authenticationconn.HelpDeskStatus>("HelpDeskStatuses");
                oDataBuilder.EntitySet<Testauth.Models.Authenticationconn.HelpDeskTicket>("HelpDeskTickets");
                oDataBuilder.EntitySet<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>("HelpDeskTicketDetails");
                oDataBuilder.EntitySet<Testauth.Models.Authenticationconn.LocationList>("LocationLists");
                oDataBuilder.EntitySet<Testauth.Models.Authenticationconn.PersistedGrant>("PersistedGrants");
                oDataBuilder.EntitySet<Testauth.Models.Authenticationconn.ServiceCatglist>("ServiceCatglists");
                oDataBuilder.EntitySet<Testauth.Models.Authenticationconn.ServicesList>("ServicesLists");
                oDataBuilder.EntitySet<Testauth.Models.Authenticationconn.TicketRequesterUsersList>("TicketRequesterUsersLists");

                this.OnConfigureOData(oDataBuilder);

                var model = oDataBuilder.GetEdmModel();

                endpoints.MapODataRoute("odata", "odata/authenticationconn", model);

            });

            OnConfigure(app, env);
        }
    }


}
