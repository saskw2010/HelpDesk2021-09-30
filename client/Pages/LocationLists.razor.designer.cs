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
    public partial class LocationListsComponent : ComponentBase
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
        protected RadzenDataGrid<Testauth.Models.Authenticationconn.LocationList> grid0;

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

        IEnumerable<Testauth.Models.Authenticationconn.LocationList> _getLocationListsResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.LocationList> getLocationListsResult
        {
            get
            {
                return _getLocationListsResult;
            }
            set
            {
                if (!object.Equals(_getLocationListsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getLocationListsResult", NewValue = value, OldValue = _getLocationListsResult };
                    _getLocationListsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getLocationListsCount;
        protected int getLocationListsCount
        {
            get
            {
                return _getLocationListsCount;
            }
            set
            {
                if (!object.Equals(_getLocationListsCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getLocationListsCount", NewValue = value, OldValue = _getLocationListsCount };
                    _getLocationListsCount = value;
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
            UriHelper.NavigateTo("add-location-list");
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Authenticationconn.ExportLocationListsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "locationID,locationDesc,locationDesc1" }, $"Location Lists");

            }

            if (args == null || args.Value == "xlsx")
            {
                await Authenticationconn.ExportLocationListsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "locationID,locationDesc,locationDesc1" }, $"Location Lists");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var authenticationconnGetLocationListsResult = await Authenticationconn.GetLocationLists(filter:$@"(contains(locationDesc,""{search}"") or contains(locationDesc1,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getLocationListsResult = authenticationconnGetLocationListsResult.Value.AsODataEnumerable();

                getLocationListsCount = authenticationconnGetLocationListsResult.Count;
            }
            catch (System.Exception authenticationconnGetLocationListsException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load LocationLists" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Testauth.Models.Authenticationconn.LocationList args)
        {
            UriHelper.NavigateTo($"edit-location-list/{args.locationID}");
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var authenticationconnDeleteLocationListResult = await Authenticationconn.DeleteLocationList(locationId:data.locationID);
                    if (authenticationconnDeleteLocationListResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception authenticationconnDeleteLocationListException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete LocationList" });
            }
        }
    }
}
