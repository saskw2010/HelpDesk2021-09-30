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
    public partial class ServicesListsComponent : ComponentBase
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
        protected RadzenDataGrid<Testauth.Models.Authenticationconn.ServicesList> grid0;

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

        IEnumerable<Testauth.Models.Authenticationconn.ServicesList> _getServicesListsResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.ServicesList> getServicesListsResult
        {
            get
            {
                return _getServicesListsResult;
            }
            set
            {
                if (!object.Equals(_getServicesListsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getServicesListsResult", NewValue = value, OldValue = _getServicesListsResult };
                    _getServicesListsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getServicesListsCount;
        protected int getServicesListsCount
        {
            get
            {
                return _getServicesListsCount;
            }
            set
            {
                if (!object.Equals(_getServicesListsCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getServicesListsCount", NewValue = value, OldValue = _getServicesListsCount };
                    _getServicesListsCount = value;
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
            UriHelper.NavigateTo("add-services-list");
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Authenticationconn.ExportServicesListsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "ServiceCatglist", Select = "ServiceID,ServiceDesc,ServiceDesc1,AuditCC,assignTo,ServiceCatglist.ServiceCatgDesc" }, $"Services Lists");

            }

            if (args == null || args.Value == "xlsx")
            {
                await Authenticationconn.ExportServicesListsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "ServiceCatglist", Select = "ServiceID,ServiceDesc,ServiceDesc1,AuditCC,assignTo,ServiceCatglist.ServiceCatgDesc" }, $"Services Lists");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var authenticationconnGetServicesListsResult = await Authenticationconn.GetServicesLists(filter:$@"(contains(ServiceDesc,""{search}"") or contains(ServiceDesc1,""{search}"") or contains(AuditCC,""{search}"") or contains(assignTo,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", expand:$"ServiceCatglist", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getServicesListsResult = authenticationconnGetServicesListsResult.Value.AsODataEnumerable();

                getServicesListsCount = authenticationconnGetServicesListsResult.Count;
            }
            catch (System.Exception authenticationconnGetServicesListsException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load ServicesLists" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Testauth.Models.Authenticationconn.ServicesList args)
        {
            UriHelper.NavigateTo($"edit-services-list/{args.ServiceID}");
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var authenticationconnDeleteServicesListResult = await Authenticationconn.DeleteServicesList(serviceId:data.ServiceID);
                    if (authenticationconnDeleteServicesListResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception authenticationconnDeleteServicesListException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete ServicesList" });
            }
        }
    }
}
