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
    public partial class DeviceCodesComponent : ComponentBase
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
        protected RadzenDataGrid<Testauth.Models.Authenticationconn.DeviceCode> grid0;

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

        IEnumerable<Testauth.Models.Authenticationconn.DeviceCode> _getDeviceCodesResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.DeviceCode> getDeviceCodesResult
        {
            get
            {
                return _getDeviceCodesResult;
            }
            set
            {
                if (!object.Equals(_getDeviceCodesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getDeviceCodesResult", NewValue = value, OldValue = _getDeviceCodesResult };
                    _getDeviceCodesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getDeviceCodesCount;
        protected int getDeviceCodesCount
        {
            get
            {
                return _getDeviceCodesCount;
            }
            set
            {
                if (!object.Equals(_getDeviceCodesCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getDeviceCodesCount", NewValue = value, OldValue = _getDeviceCodesCount };
                    _getDeviceCodesCount = value;
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
            UriHelper.NavigateTo("add-device-code");
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Authenticationconn.ExportDeviceCodesToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "UserCode,DeviceCode1,SubjectId,ClientId,CreationTime,Expiration,Data" }, $"Device Codes");

            }

            if (args == null || args.Value == "xlsx")
            {
                await Authenticationconn.ExportDeviceCodesToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "UserCode,DeviceCode1,SubjectId,ClientId,CreationTime,Expiration,Data" }, $"Device Codes");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var authenticationconnGetDeviceCodesResult = await Authenticationconn.GetDeviceCodes(filter:$@"(contains(UserCode,""{search}"") or contains(DeviceCode1,""{search}"") or contains(SubjectId,""{search}"") or contains(ClientId,""{search}"") or contains(Data,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getDeviceCodesResult = authenticationconnGetDeviceCodesResult.Value.AsODataEnumerable();

                getDeviceCodesCount = authenticationconnGetDeviceCodesResult.Count;
            }
            catch (System.Exception authenticationconnGetDeviceCodesException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load DeviceCodes" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Testauth.Models.Authenticationconn.DeviceCode args)
        {
            UriHelper.NavigateTo($"edit-device-code/{args.UserCode}");
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var authenticationconnDeleteDeviceCodeResult = await Authenticationconn.DeleteDeviceCode(userCode:$"{data.UserCode}");
                    if (authenticationconnDeleteDeviceCodeResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception authenticationconnDeleteDeviceCodeException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete DeviceCode" });
            }
        }
    }
}
