using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Testauth.Models;
using Testauth.Models.Authenticationconn;
using Radzen;
using System.Net.Http.Json;
using System.Net.Http;
using Testauth.Shared;
using Microsoft.Extensions.Configuration;

namespace Testauth
{
    public partial class GlobalsService
    {
        private readonly HttpClient httpClient;
        private readonly Uri baseUri;
        private readonly NavigationManager navigationManager;
        public GlobalsService(NavigationManager navigationManager, HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;

            this.navigationManager = navigationManager;
            this.baseUri = new Uri($"{navigationManager.BaseUri}api/Email");
        }
        public  async Task SaveTicket(string TicketRequesterEmail,string TicketGUID)
        {

            

            // Send Email
            HelpDeskEmail objHelpDeskEmail = new HelpDeskEmail();
            objHelpDeskEmail.EmailType = "Help Desk Ticket Updated";
            objHelpDeskEmail.EmailAddress = TicketRequesterEmail;
            objHelpDeskEmail.TicketGuid = TicketGUID;
            

        //await httpClient.PostAsJsonAsync("Email", objHelpDeskEmail);
        await httpClient.PostAsJsonAsync(baseUri, objHelpDeskEmail);

            return;
        }
    }

   
}
