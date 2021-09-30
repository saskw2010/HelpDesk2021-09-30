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
    public partial class HelpDeskTicketherarchyComponent : ComponentBase
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
        protected RadzenDataGrid<Testauth.Models.Authenticationconn.HelpDeskTicket> grid0;
        protected RadzenDataGrid<Testauth.Models.Authenticationconn.HelpDeskTicketDetail> grid1;

        IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicket> _getHelpDeskTicketsResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicket> getHelpDeskTicketsResult
        {
            get
            {
                return _getHelpDeskTicketsResult;
            }
            set
            {
                if (!object.Equals(_getHelpDeskTicketsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskTicketsResult", NewValue = value, OldValue = _getHelpDeskTicketsResult };
                    _getHelpDeskTicketsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getHelpDeskTicketsCount;
        protected int getHelpDeskTicketsCount
        {
            get
            {
                return _getHelpDeskTicketsCount;
            }
            set
            {
                if (!object.Equals(_getHelpDeskTicketsCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskTicketsCount", NewValue = value, OldValue = _getHelpDeskTicketsCount };
                    _getHelpDeskTicketsCount = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        dynamic _master;
        protected dynamic master
        {
            get
            {
                return _master;
            }
            set
            {
                if (!object.Equals(_master, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "master", NewValue = value, OldValue = _master };
                    _master = value;
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

        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddHelpDeskTicketherarchy>("Add Help Desk Ticketherarchy", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var authenticationconnGetHelpDeskTicketsResult = await Authenticationconn.GetHelpDeskTickets(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", expand:$"LocationList,ServiceCatglist,ServicesList,HelpDeskStatus", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getHelpDeskTicketsResult = authenticationconnGetHelpDeskTicketsResult.Value.AsODataEnumerable();

                getHelpDeskTicketsCount = authenticationconnGetHelpDeskTicketsResult.Count;
            }
            catch (System.Exception authenticationconnGetHelpDeskTicketsException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load HelpDeskTickets" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowExpand(Testauth.Models.Authenticationconn.HelpDeskTicket args)
        {
            master = args;

            var authenticationconnGetHelpDeskTicketDetailsResult = await Authenticationconn.GetHelpDeskTicketDetails(filter:$"HelpDeskTicketId eq {args.Id}");
            args.HelpDeskTicketDetails = authenticationconnGetHelpDeskTicketDetailsResult.Value;
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Testauth.Models.Authenticationconn.HelpDeskTicket args)
        {
            var dialogResult = await DialogService.OpenAsync<EditHelpDeskTicketherarchy>("Edit Help Desk Ticketherarchy", new Dictionary<string, object>() { {"Id", args.Id} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var authenticationconnDeleteHelpDeskTicketResult = await Authenticationconn.DeleteHelpDeskTicket(id:data.Id);
                    if (authenticationconnDeleteHelpDeskTicketResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception authenticationconnDeleteHelpDeskTicketException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete HelpDeskTicket" });
            }
        }

        protected async System.Threading.Tasks.Task HelpDeskTicketDetailAddButtonClick(MouseEventArgs args, dynamic data)
        {
            var dialogResult = await DialogService.OpenAsync<AddHelpDeskTicketDetail>("Add Help Desk Ticket Detail", new Dictionary<string, object>() { {"HelpDeskTicketId", data.Id} });
            await Grid0RowExpand(master);

            await grid1.Reload();
        }

        protected async System.Threading.Tasks.Task Grid1RowSelect(Testauth.Models.Authenticationconn.HelpDeskTicketDetail args, dynamic data)
        {
            var dialogResult = await DialogService.OpenAsync<EditHelpDeskTicketDetail>("Edit Help Desk Ticket Detail", new Dictionary<string, object>() { {"Id", args.Id} });
            await Grid0RowExpand(master);

            await grid1.Reload();
        }

        protected async System.Threading.Tasks.Task HelpDeskTicketDetailDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var authenticationconnDeleteHelpDeskTicketDetailResult = await Authenticationconn.DeleteHelpDeskTicketDetail(id:data.Id);
                    await Grid0RowExpand(master);

                    if (authenticationconnDeleteHelpDeskTicketDetailResult != null)
                    {
                        await grid1.Reload();
                    }
                }
            }
            catch (System.Exception authenticationconnDeleteHelpDeskTicketDetailException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete HelpDeskTicket" });
            }
        }
    }
}
