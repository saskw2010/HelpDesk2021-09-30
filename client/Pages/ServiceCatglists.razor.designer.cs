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
    public partial class ServiceCatglistsComponent : ComponentBase
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
        protected RadzenDataGrid<Testauth.Models.Authenticationconn.ServiceCatglist> grid0;

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

        IEnumerable<Testauth.Models.Authenticationconn.ServiceCatglist> _getServiceCatglistsResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.ServiceCatglist> getServiceCatglistsResult
        {
            get
            {
                return _getServiceCatglistsResult;
            }
            set
            {
                if (!object.Equals(_getServiceCatglistsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getServiceCatglistsResult", NewValue = value, OldValue = _getServiceCatglistsResult };
                    _getServiceCatglistsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getServiceCatglistsCount;
        protected int getServiceCatglistsCount
        {
            get
            {
                return _getServiceCatglistsCount;
            }
            set
            {
                if (!object.Equals(_getServiceCatglistsCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getServiceCatglistsCount", NewValue = value, OldValue = _getServiceCatglistsCount };
                    _getServiceCatglistsCount = value;
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
            UriHelper.NavigateTo("add-service-catglist");
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Authenticationconn.ExportServiceCatglistsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "ServiceCatgID,ServiceCatgDesc,ServiceCatgDesc1" }, $"Service Catglists");

            }

            if (args == null || args.Value == "xlsx")
            {
                await Authenticationconn.ExportServiceCatglistsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "ServiceCatgID,ServiceCatgDesc,ServiceCatgDesc1" }, $"Service Catglists");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var authenticationconnGetServiceCatglistsResult = await Authenticationconn.GetServiceCatglists(filter:$@"(contains(ServiceCatgDesc,""{search}"") or contains(ServiceCatgDesc1,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getServiceCatglistsResult = authenticationconnGetServiceCatglistsResult.Value.AsODataEnumerable();

                getServiceCatglistsCount = authenticationconnGetServiceCatglistsResult.Count;
            }
            catch (System.Exception authenticationconnGetServiceCatglistsException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load ServiceCatglists" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Testauth.Models.Authenticationconn.ServiceCatglist args)
        {
            UriHelper.NavigateTo($"edit-service-catglist/{args.ServiceCatgID}");
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var authenticationconnDeleteServiceCatglistResult = await Authenticationconn.DeleteServiceCatglist(serviceCatgId:data.ServiceCatgID);
                    if (authenticationconnDeleteServiceCatglistResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception authenticationconnDeleteServiceCatglistException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete ServiceCatglist" });
            }
        }
    }
}
