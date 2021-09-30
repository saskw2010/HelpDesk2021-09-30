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
    public partial class AddHelpDeskTicketDetailComponent : ComponentBase
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
        public dynamic HelpDeskTicketId { get; set; }

        Testauth.Models.Authenticationconn.HelpDeskTicketDetail _helpdeskticketdetail;
        protected Testauth.Models.Authenticationconn.HelpDeskTicketDetail helpdeskticketdetail
        {
            get
            {
                return _helpdeskticketdetail;
            }
            set
            {
                if (!object.Equals(_helpdeskticketdetail, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "helpdeskticketdetail", NewValue = value, OldValue = _helpdeskticketdetail };
                    _helpdeskticketdetail = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicket> _getHelpDeskTicketsForHelpDeskTicketIdResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicket> getHelpDeskTicketsForHelpDeskTicketIdResult
        {
            get
            {
                return _getHelpDeskTicketsForHelpDeskTicketIdResult;
            }
            set
            {
                if (!object.Equals(_getHelpDeskTicketsForHelpDeskTicketIdResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskTicketsForHelpDeskTicketIdResult", NewValue = value, OldValue = _getHelpDeskTicketsForHelpDeskTicketIdResult };
                    _getHelpDeskTicketsForHelpDeskTicketIdResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getHelpDeskTicketsForHelpDeskTicketIdCount;
        protected int getHelpDeskTicketsForHelpDeskTicketIdCount
        {
            get
            {
                return _getHelpDeskTicketsForHelpDeskTicketIdCount;
            }
            set
            {
                if (!object.Equals(_getHelpDeskTicketsForHelpDeskTicketIdCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskTicketsForHelpDeskTicketIdCount", NewValue = value, OldValue = _getHelpDeskTicketsForHelpDeskTicketIdCount };
                    _getHelpDeskTicketsForHelpDeskTicketIdCount = value;
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
            helpdeskticketdetail = new Testauth.Models.Authenticationconn.HelpDeskTicketDetail(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Testauth.Models.Authenticationconn.HelpDeskTicketDetail args)
        {
            try
            {
                var authenticationconnCreateHelpDeskTicketDetailResult = await Authenticationconn.CreateHelpDeskTicketDetail(helpDeskTicketDetail:helpdeskticketdetail);
                UriHelper.NavigateTo("help-desk-ticket-details");
            }
            catch (System.Exception authenticationconnCreateHelpDeskTicketDetailException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new HelpDeskTicketDetail!" });
            }
        }

        protected async System.Threading.Tasks.Task HelpDeskTicketIdLoadData(LoadDataArgs args)
        {
            var authenticationconnGetHelpDeskTicketsResult = await Authenticationconn.GetHelpDeskTickets(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:true);
            getHelpDeskTicketsForHelpDeskTicketIdResult = authenticationconnGetHelpDeskTicketsResult.Value.AsODataEnumerable();

            getHelpDeskTicketsForHelpDeskTicketIdCount = authenticationconnGetHelpDeskTicketsResult.Count;
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("help-desk-ticket-details");
        }
    }
}
