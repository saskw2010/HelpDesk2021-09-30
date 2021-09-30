using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Testauth.Models.Authenticationconn;
using Testauth.Models;
using Testauth.Client.Pages;

namespace Testauth.Pages
{
    public partial class AddTicketRequesterUsersListComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected SecurityService Security { get; set; }

        [Inject]
        protected AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        protected AuthenticationconnService Authenticationconn { get; set; }

        Testauth.Models.Authenticationconn.TicketRequesterUsersList _ticketrequesteruserslist;
        protected Testauth.Models.Authenticationconn.TicketRequesterUsersList ticketrequesteruserslist
        {
            get
            {
                return _ticketrequesteruserslist;
            }
            set
            {
                if (!object.Equals(_ticketrequesteruserslist, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "ticketrequesteruserslist", NewValue = value, OldValue = _ticketrequesteruserslist };
                    _ticketrequesteruserslist = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Security.InitializeAsync(AuthenticationStateProvider);
            if (!Security.IsAuthenticated())
            {
                UriHelper.NavigateTo("Login", true);
            }
            else
            {
                await Load();
            }
        }
        protected async System.Threading.Tasks.Task Load()
        {
            ticketrequesteruserslist = new Testauth.Models.Authenticationconn.TicketRequesterUsersList(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Testauth.Models.Authenticationconn.TicketRequesterUsersList args)
        {
            try
            {
                var authenticationconnCreateTicketRequesterUsersListResult = await Authenticationconn.CreateTicketRequesterUsersList(ticketRequesterUsersList:ticketrequesteruserslist);
                UriHelper.NavigateTo("ticket-requester-users-lists");
            }
            catch (System.Exception authenticationconnCreateTicketRequesterUsersListException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new TicketRequesterUsersList!" });
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("ticket-requester-users-lists");
        }
    }
}
