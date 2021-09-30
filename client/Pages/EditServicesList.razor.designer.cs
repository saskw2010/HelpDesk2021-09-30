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
    public partial class EditServicesListComponent : ComponentBase
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
        public dynamic ServiceID { get; set; }

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

        Testauth.Models.Authenticationconn.ServicesList _serviceslist;
        protected Testauth.Models.Authenticationconn.ServicesList serviceslist
        {
            get
            {
                return _serviceslist;
            }
            set
            {
                if (!object.Equals(_serviceslist, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "serviceslist", NewValue = value, OldValue = _serviceslist };
                    _serviceslist = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Testauth.Models.Authenticationconn.ServiceCatglist _getByServiceCatglistsForServiceCatgIDResult;
        protected Testauth.Models.Authenticationconn.ServiceCatglist getByServiceCatglistsForServiceCatgIDResult
        {
            get
            {
                return _getByServiceCatglistsForServiceCatgIDResult;
            }
            set
            {
                if (!object.Equals(_getByServiceCatglistsForServiceCatgIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getByServiceCatglistsForServiceCatgIDResult", NewValue = value, OldValue = _getByServiceCatglistsForServiceCatgIDResult };
                    _getByServiceCatglistsForServiceCatgIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Testauth.Models.Authenticationconn.ServiceCatglist> _getServiceCatglistsForServiceCatgIDResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.ServiceCatglist> getServiceCatglistsForServiceCatgIDResult
        {
            get
            {
                return _getServiceCatglistsForServiceCatgIDResult;
            }
            set
            {
                if (!object.Equals(_getServiceCatglistsForServiceCatgIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getServiceCatglistsForServiceCatgIDResult", NewValue = value, OldValue = _getServiceCatglistsForServiceCatgIDResult };
                    _getServiceCatglistsForServiceCatgIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getServiceCatglistsForServiceCatgIDCount;
        protected int getServiceCatglistsForServiceCatgIDCount
        {
            get
            {
                return _getServiceCatglistsForServiceCatgIDCount;
            }
            set
            {
                if (!object.Equals(_getServiceCatglistsForServiceCatgIDCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getServiceCatglistsForServiceCatgIDCount", NewValue = value, OldValue = _getServiceCatglistsForServiceCatgIDCount };
                    _getServiceCatglistsForServiceCatgIDCount = value;
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

            var authenticationconnGetServicesListByServiceIdResult = await Authenticationconn.GetServicesListByServiceId(serviceId:Convert.ChangeType(ServiceID, Type.GetTypeCode(typeof(Int64))));
            serviceslist = authenticationconnGetServicesListByServiceIdResult;

            canEdit = authenticationconnGetServicesListByServiceIdResult != null;

            if (this.serviceslist.ServiceCatgID != null)
            {
                var authenticationconnGetServiceCatglistByServiceCatgIdResult = await Authenticationconn.GetServiceCatglistByServiceCatgId(serviceCatgId:this.serviceslist.ServiceCatgID);
                getByServiceCatglistsForServiceCatgIDResult = authenticationconnGetServiceCatglistByServiceCatgIdResult;
            }
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            UriHelper.NavigateTo("services-lists");
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            await this.Load();
        }

        protected async System.Threading.Tasks.Task Form0Submit(Testauth.Models.Authenticationconn.ServicesList args)
        {
            try
            {
                var authenticationconnUpdateServicesListResult = await Authenticationconn.UpdateServicesList(serviceId:Convert.ChangeType(ServiceID, Type.GetTypeCode(typeof(Int64))), servicesList:serviceslist);
                if (authenticationconnUpdateServicesListResult.StatusCode != System.Net.HttpStatusCode.PreconditionFailed) {
                UriHelper.NavigateTo("services-lists");
                }

                hasChanges = authenticationconnUpdateServicesListResult.StatusCode == System.Net.HttpStatusCode.PreconditionFailed;
            }
            catch (System.Exception authenticationconnUpdateServicesListException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to update ServicesList" });
            }
        }

        protected async System.Threading.Tasks.Task ServiceCatgIdLoadData(LoadDataArgs args)
        {
            var authenticationconnGetServiceCatglistsResult = await Authenticationconn.GetServiceCatglists(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:true);
            getServiceCatglistsForServiceCatgIDResult = authenticationconnGetServiceCatglistsResult.Value.AsODataEnumerable();

            getServiceCatglistsForServiceCatgIDCount = authenticationconnGetServiceCatglistsResult.Count;
        }

        protected async System.Threading.Tasks.Task Button4Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("services-lists");
        }
    }
}
