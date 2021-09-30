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
    public partial class EditTicketRequesterUsersListComponent : ComponentBase
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

        [Parameter]
        public dynamic TicketRequesterUser { get; set; }

        bool _hasChanges;
        protected bool hasChanges
        {
            get
            {
                return _hasChanges;
            }
            set
            {
                if (!object.Equals(_hasChanges, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "hasChanges", NewValue = value, OldValue = _hasChanges };
                    _hasChanges = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if (!object.Equals(_canEdit, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "canEdit", NewValue = value, OldValue = _canEdit };
                    _canEdit = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

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
            hasChanges = false;

            canEdit = true;

            var authenticationconnGetTicketRequesterUsersListByTicketRequesterUserResult = await Authenticationconn.GetTicketRequesterUsersListByTicketRequesterUser(ticketRequesterUser:$"{TicketRequesterUser}");
            ticketrequesteruserslist = authenticationconnGetTicketRequesterUsersListByTicketRequesterUserResult;

            canEdit = authenticationconnGetTicketRequesterUsersListByTicketRequesterUserResult != null;
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            UriHelper.NavigateTo("ticket-requester-users-lists");
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            await this.Load();
        }

        protected async System.Threading.Tasks.Task Form0Submit(Testauth.Models.Authenticationconn.TicketRequesterUsersList args)
        {
            try
            {
                var authenticationconnUpdateTicketRequesterUsersListResult = await Authenticationconn.UpdateTicketRequesterUsersList(ticketRequesterUser:$"{TicketRequesterUser}", ticketRequesterUsersList:ticketrequesteruserslist);
                if (authenticationconnUpdateTicketRequesterUsersListResult.StatusCode != System.Net.HttpStatusCode.PreconditionFailed) {
                UriHelper.NavigateTo("ticket-requester-users-lists");
                }

                hasChanges = authenticationconnUpdateTicketRequesterUsersListResult.StatusCode == System.Net.HttpStatusCode.PreconditionFailed;
            }
            catch (System.Exception authenticationconnUpdateTicketRequesterUsersListException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to update TicketRequesterUsersList" });
            }
        }

        protected async System.Threading.Tasks.Task Button4Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("ticket-requester-users-lists");
        }
    }
}
