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
    public partial class EditHelpDeskTicketherarchyComponent : ComponentBase
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
        public dynamic Id { get; set; }

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

        Testauth.Models.Authenticationconn.HelpDeskTicket _helpdeskticket;
        protected Testauth.Models.Authenticationconn.HelpDeskTicket helpdeskticket
        {
            get
            {
                return _helpdeskticket;
            }
            set
            {
                if (!object.Equals(_helpdeskticket, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "helpdeskticket", NewValue = value, OldValue = _helpdeskticket };
                    _helpdeskticket = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Testauth.Models.Authenticationconn.HelpDeskStatus _getByHelpDeskStatusesForTicketStatusResult;
        protected Testauth.Models.Authenticationconn.HelpDeskStatus getByHelpDeskStatusesForTicketStatusResult
        {
            get
            {
                return _getByHelpDeskStatusesForTicketStatusResult;
            }
            set
            {
                if (!object.Equals(_getByHelpDeskStatusesForTicketStatusResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getByHelpDeskStatusesForTicketStatusResult", NewValue = value, OldValue = _getByHelpDeskStatusesForTicketStatusResult };
                    _getByHelpDeskStatusesForTicketStatusResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Testauth.Models.Authenticationconn.LocationList _getByLocationListsForlocationIDResult;
        protected Testauth.Models.Authenticationconn.LocationList getByLocationListsForlocationIDResult
        {
            get
            {
                return _getByLocationListsForlocationIDResult;
            }
            set
            {
                if (!object.Equals(_getByLocationListsForlocationIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getByLocationListsForlocationIDResult", NewValue = value, OldValue = _getByLocationListsForlocationIDResult };
                    _getByLocationListsForlocationIDResult = value;
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

        Testauth.Models.Authenticationconn.ServicesList _getByServicesListsForServiceIDResult;
        protected Testauth.Models.Authenticationconn.ServicesList getByServicesListsForServiceIDResult
        {
            get
            {
                return _getByServicesListsForServiceIDResult;
            }
            set
            {
                if (!object.Equals(_getByServicesListsForServiceIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getByServicesListsForServiceIDResult", NewValue = value, OldValue = _getByServicesListsForServiceIDResult };
                    _getByServicesListsForServiceIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Testauth.Models.Authenticationconn.HelpDeskStatus> _getHelpDeskStatusesForTicketStatusResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.HelpDeskStatus> getHelpDeskStatusesForTicketStatusResult
        {
            get
            {
                return _getHelpDeskStatusesForTicketStatusResult;
            }
            set
            {
                if (!object.Equals(_getHelpDeskStatusesForTicketStatusResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskStatusesForTicketStatusResult", NewValue = value, OldValue = _getHelpDeskStatusesForTicketStatusResult };
                    _getHelpDeskStatusesForTicketStatusResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getHelpDeskStatusesForTicketStatusCount;
        protected int getHelpDeskStatusesForTicketStatusCount
        {
            get
            {
                return _getHelpDeskStatusesForTicketStatusCount;
            }
            set
            {
                if (!object.Equals(_getHelpDeskStatusesForTicketStatusCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskStatusesForTicketStatusCount", NewValue = value, OldValue = _getHelpDeskStatusesForTicketStatusCount };
                    _getHelpDeskStatusesForTicketStatusCount = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Testauth.Models.Authenticationconn.LocationList> _getLocationListsForlocationIDResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.LocationList> getLocationListsForlocationIDResult
        {
            get
            {
                return _getLocationListsForlocationIDResult;
            }
            set
            {
                if (!object.Equals(_getLocationListsForlocationIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getLocationListsForlocationIDResult", NewValue = value, OldValue = _getLocationListsForlocationIDResult };
                    _getLocationListsForlocationIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getLocationListsForlocationIDCount;
        protected int getLocationListsForlocationIDCount
        {
            get
            {
                return _getLocationListsForlocationIDCount;
            }
            set
            {
                if (!object.Equals(_getLocationListsForlocationIDCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getLocationListsForlocationIDCount", NewValue = value, OldValue = _getLocationListsForlocationIDCount };
                    _getLocationListsForlocationIDCount = value;
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

        IEnumerable<Testauth.Models.Authenticationconn.ServicesList> _getServicesListsForServiceIDResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.ServicesList> getServicesListsForServiceIDResult
        {
            get
            {
                return _getServicesListsForServiceIDResult;
            }
            set
            {
                if (!object.Equals(_getServicesListsForServiceIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getServicesListsForServiceIDResult", NewValue = value, OldValue = _getServicesListsForServiceIDResult };
                    _getServicesListsForServiceIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getServicesListsForServiceIDCount;
        protected int getServicesListsForServiceIDCount
        {
            get
            {
                return _getServicesListsForServiceIDCount;
            }
            set
            {
                if (!object.Equals(_getServicesListsForServiceIDCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getServicesListsForServiceIDCount", NewValue = value, OldValue = _getServicesListsForServiceIDCount };
                    _getServicesListsForServiceIDCount = value;
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

            var authenticationconnGetHelpDeskTicketByIdResult = await Authenticationconn.GetHelpDeskTicketById(id:Id);
            helpdeskticket = authenticationconnGetHelpDeskTicketByIdResult;

            canEdit = authenticationconnGetHelpDeskTicketByIdResult != null;

            if (this.helpdeskticket.TicketStatus != null)
            {
                var authenticationconnGetHelpDeskStatusByTicketStatusResult = await Authenticationconn.GetHelpDeskStatusByTicketStatus(ticketStatus:$"{this.helpdeskticket.TicketStatus}");
                getByHelpDeskStatusesForTicketStatusResult = authenticationconnGetHelpDeskStatusByTicketStatusResult;
            }

            if (this.helpdeskticket.locationID != null)
            {
                var authenticationconnGetLocationListBylocationIdResult = await Authenticationconn.GetLocationListBylocationId(locationId:this.helpdeskticket.locationID);
                getByLocationListsForlocationIDResult = authenticationconnGetLocationListBylocationIdResult;
            }

            if (this.helpdeskticket.ServiceCatgID != null)
            {
                var authenticationconnGetServiceCatglistByServiceCatgIdResult = await Authenticationconn.GetServiceCatglistByServiceCatgId(serviceCatgId:this.helpdeskticket.ServiceCatgID);
                getByServiceCatglistsForServiceCatgIDResult = authenticationconnGetServiceCatglistByServiceCatgIdResult;
            }

            if (this.helpdeskticket.ServiceID != null)
            {
                var authenticationconnGetServicesListByServiceIdResult = await Authenticationconn.GetServicesListByServiceId(serviceId:this.helpdeskticket.ServiceID);
                getByServicesListsForServiceIDResult = authenticationconnGetServicesListByServiceIdResult;
            }
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            await this.Load();
        }

        protected async System.Threading.Tasks.Task Form0Submit(Testauth.Models.Authenticationconn.HelpDeskTicket args)
        {
            try
            {
                var authenticationconnUpdateHelpDeskTicketResult = await Authenticationconn.UpdateHelpDeskTicket(id:Id, helpDeskTicket:helpdeskticket);
                if (authenticationconnUpdateHelpDeskTicketResult.StatusCode != System.Net.HttpStatusCode.PreconditionFailed) {
                  DialogService.Close(helpdeskticket);
                }

                hasChanges = authenticationconnUpdateHelpDeskTicketResult.StatusCode == System.Net.HttpStatusCode.PreconditionFailed;
            }
            catch (System.Exception authenticationconnUpdateHelpDeskTicketException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to update HelpDeskTicket" });
            }
        }

        protected async System.Threading.Tasks.Task TicketStatusLoadData(LoadDataArgs args)
        {
            var authenticationconnGetHelpDeskStatusesResult = await Authenticationconn.GetHelpDeskStatuses(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:true);
            getHelpDeskStatusesForTicketStatusResult = authenticationconnGetHelpDeskStatusesResult.Value.AsODataEnumerable();

            getHelpDeskStatusesForTicketStatusCount = authenticationconnGetHelpDeskStatusesResult.Count;
        }

        protected async System.Threading.Tasks.Task LocationIdLoadData(LoadDataArgs args)
        {
            var authenticationconnGetLocationListsResult = await Authenticationconn.GetLocationLists(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:true);
            getLocationListsForlocationIDResult = authenticationconnGetLocationListsResult.Value.AsODataEnumerable();

            getLocationListsForlocationIDCount = authenticationconnGetLocationListsResult.Count;
        }

        protected async System.Threading.Tasks.Task ServiceCatgIdLoadData(LoadDataArgs args)
        {
            var authenticationconnGetServiceCatglistsResult = await Authenticationconn.GetServiceCatglists(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:true);
            getServiceCatglistsForServiceCatgIDResult = authenticationconnGetServiceCatglistsResult.Value.AsODataEnumerable();

            getServiceCatglistsForServiceCatgIDCount = authenticationconnGetServiceCatglistsResult.Count;
        }

        protected async System.Threading.Tasks.Task ServiceIdLoadData(LoadDataArgs args)
        {
            var authenticationconnGetServicesListsResult = await Authenticationconn.GetServicesLists(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:true);
            getServicesListsForServiceIDResult = authenticationconnGetServicesListsResult.Value.AsODataEnumerable();

            getServicesListsForServiceIDCount = authenticationconnGetServicesListsResult.Count;
        }

        protected async System.Threading.Tasks.Task Button4Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
