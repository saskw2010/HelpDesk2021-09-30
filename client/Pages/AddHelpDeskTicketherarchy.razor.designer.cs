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
    public partial class AddHelpDeskTicketherarchyComponent : ComponentBase
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
            helpdeskticket = new Testauth.Models.Authenticationconn.HelpDeskTicket(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Testauth.Models.Authenticationconn.HelpDeskTicket args)
        {
            try
            {
                var authenticationconnCreateHelpDeskTicketResult = await Authenticationconn.CreateHelpDeskTicket(helpDeskTicket:helpdeskticket);
                DialogService.Close(helpdeskticket);
            }
            catch (System.Exception authenticationconnCreateHelpDeskTicketException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new HelpDeskTicket!" });
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

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
