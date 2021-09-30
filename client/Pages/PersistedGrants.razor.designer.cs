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
    public partial class PersistedGrantsComponent : ComponentBase
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
        protected RadzenDataGrid<Testauth.Models.Authenticationconn.PersistedGrant> grid0;

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

        IEnumerable<Testauth.Models.Authenticationconn.PersistedGrant> _getPersistedGrantsResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.PersistedGrant> getPersistedGrantsResult
        {
            get
            {
                return _getPersistedGrantsResult;
            }
            set
            {
                if (!object.Equals(_getPersistedGrantsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getPersistedGrantsResult", NewValue = value, OldValue = _getPersistedGrantsResult };
                    _getPersistedGrantsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getPersistedGrantsCount;
        protected int getPersistedGrantsCount
        {
            get
            {
                return _getPersistedGrantsCount;
            }
            set
            {
                if (!object.Equals(_getPersistedGrantsCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getPersistedGrantsCount", NewValue = value, OldValue = _getPersistedGrantsCount };
                    _getPersistedGrantsCount = value;
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
            UriHelper.NavigateTo("add-persisted-grant");
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Authenticationconn.ExportPersistedGrantsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "Key,Type,SubjectId,ClientId,CreationTime,Expiration,Data" }, $"Persisted Grants");

            }

            if (args == null || args.Value == "xlsx")
            {
                await Authenticationconn.ExportPersistedGrantsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "Key,Type,SubjectId,ClientId,CreationTime,Expiration,Data" }, $"Persisted Grants");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var authenticationconnGetPersistedGrantsResult = await Authenticationconn.GetPersistedGrants(filter:$@"(contains(Key,""{search}"") or contains(Type,""{search}"") or contains(SubjectId,""{search}"") or contains(ClientId,""{search}"") or contains(Data,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getPersistedGrantsResult = authenticationconnGetPersistedGrantsResult.Value.AsODataEnumerable();

                getPersistedGrantsCount = authenticationconnGetPersistedGrantsResult.Count;
            }
            catch (System.Exception authenticationconnGetPersistedGrantsException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load PersistedGrants" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Testauth.Models.Authenticationconn.PersistedGrant args)
        {
            UriHelper.NavigateTo($"edit-persisted-grant/{args.Key}");
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var authenticationconnDeletePersistedGrantResult = await Authenticationconn.DeletePersistedGrant(key:$"{data.Key}");
                    if (authenticationconnDeletePersistedGrantResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception authenticationconnDeletePersistedGrantException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete PersistedGrant" });
            }
        }
    }
}
