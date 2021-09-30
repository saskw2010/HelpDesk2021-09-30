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
    public partial class HelpDeskStatusesComponent : ComponentBase
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
        protected RadzenDataGrid<Testauth.Models.Authenticationconn.HelpDeskStatus> grid0;

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

        IEnumerable<Testauth.Models.Authenticationconn.HelpDeskStatus> _getHelpDeskStatusesResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.HelpDeskStatus> getHelpDeskStatusesResult
        {
            get
            {
                return _getHelpDeskStatusesResult;
            }
            set
            {
                if (!object.Equals(_getHelpDeskStatusesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskStatusesResult", NewValue = value, OldValue = _getHelpDeskStatusesResult };
                    _getHelpDeskStatusesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getHelpDeskStatusesCount;
        protected int getHelpDeskStatusesCount
        {
            get
            {
                return _getHelpDeskStatusesCount;
            }
            set
            {
                if (!object.Equals(_getHelpDeskStatusesCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskStatusesCount", NewValue = value, OldValue = _getHelpDeskStatusesCount };
                    _getHelpDeskStatusesCount = value;
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
            UriHelper.NavigateTo("add-help-desk-status");
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Authenticationconn.ExportHelpDeskStatusesToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "TicketStatus,TicketStatusDesc" }, $"Help Desk Statuses");

            }

            if (args == null || args.Value == "xlsx")
            {
                await Authenticationconn.ExportHelpDeskStatusesToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "TicketStatus,TicketStatusDesc" }, $"Help Desk Statuses");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var authenticationconnGetHelpDeskStatusesResult = await Authenticationconn.GetHelpDeskStatuses(filter:$@"(contains(TicketStatus,""{search}"") or contains(TicketStatusDesc,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getHelpDeskStatusesResult = authenticationconnGetHelpDeskStatusesResult.Value.AsODataEnumerable();

                getHelpDeskStatusesCount = authenticationconnGetHelpDeskStatusesResult.Count;
            }
            catch (System.Exception authenticationconnGetHelpDeskStatusesException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load HelpDeskStatuses" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Testauth.Models.Authenticationconn.HelpDeskStatus args)
        {
            UriHelper.NavigateTo($"edit-help-desk-status/{args.TicketStatus}");
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var authenticationconnDeleteHelpDeskStatusResult = await Authenticationconn.DeleteHelpDeskStatus(ticketStatus:$"{data.TicketStatus}");
                    if (authenticationconnDeleteHelpDeskStatusResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception authenticationconnDeleteHelpDeskStatusException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete HelpDeskStatus" });
            }
        }
    }
}
