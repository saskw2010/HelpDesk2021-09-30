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
    public partial class HelpDeskTicketDetailsComponent : ComponentBase
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
        protected RadzenDataGrid<Testauth.Models.Authenticationconn.HelpDeskTicketDetail> grid0;

        string _search;
        protected string search
        {
            get
            {
                return _search;
            }
            set
            {
                if (!object.Equals(_search, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "search", NewValue = value, OldValue = _search };
                    _search = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicketDetail> _getHelpDeskTicketDetailsResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicketDetail> getHelpDeskTicketDetailsResult
        {
            get
            {
                return _getHelpDeskTicketDetailsResult;
            }
            set
            {
                if (!object.Equals(_getHelpDeskTicketDetailsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskTicketDetailsResult", NewValue = value, OldValue = _getHelpDeskTicketDetailsResult };
                    _getHelpDeskTicketDetailsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getHelpDeskTicketDetailsCount;
        protected int getHelpDeskTicketDetailsCount
        {
            get
            {
                return _getHelpDeskTicketDetailsCount;
            }
            set
            {
                if (!object.Equals(_getHelpDeskTicketDetailsCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskTicketDetailsCount", NewValue = value, OldValue = _getHelpDeskTicketDetailsCount };
                    _getHelpDeskTicketDetailsCount = value;
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
            if (string.IsNullOrEmpty(search)) {
                search = "";
            }
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("add-help-desk-ticket-detail");
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Authenticationconn.ExportHelpDeskTicketDetailsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "HelpDeskTicket", Select = "Id,HelpDeskTicket.TicketGUID,TicketDetailDate,TicketDescription" }, $"Help Desk Ticket Details");

            }

            if (args == null || args.Value == "xlsx")
            {
                await Authenticationconn.ExportHelpDeskTicketDetailsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "HelpDeskTicket", Select = "Id,HelpDeskTicket.TicketGUID,TicketDetailDate,TicketDescription" }, $"Help Desk Ticket Details");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var authenticationconnGetHelpDeskTicketDetailsResult = await Authenticationconn.GetHelpDeskTicketDetails(filter:$@"(contains(TicketDescription,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", expand:$"HelpDeskTicket", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getHelpDeskTicketDetailsResult = authenticationconnGetHelpDeskTicketDetailsResult.Value.AsODataEnumerable();

                getHelpDeskTicketDetailsCount = authenticationconnGetHelpDeskTicketDetailsResult.Count;
            }
            catch (System.Exception authenticationconnGetHelpDeskTicketDetailsException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load HelpDeskTicketDetails" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Testauth.Models.Authenticationconn.HelpDeskTicketDetail args)
        {
            UriHelper.NavigateTo($"edit-help-desk-ticket-detail/{args.Id}");
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var authenticationconnDeleteHelpDeskTicketDetailResult = await Authenticationconn.DeleteHelpDeskTicketDetail(id:data.Id);
                    if (authenticationconnDeleteHelpDeskTicketDetailResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception authenticationconnDeleteHelpDeskTicketDetailException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete HelpDeskTicketDetail" });
            }
        }
    }
}
