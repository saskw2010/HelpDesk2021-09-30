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
    public partial class HelpDeskTicketwithformComponent : ComponentBase
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
        protected RadzenDataGrid<Testauth.Models.Authenticationconn.HelpDeskTicket> grid0;

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

        bool _isEdit;
        protected bool isEdit
        {
            get
            {
                return _isEdit;
            }
            set
            {
                if (!object.Equals(_isEdit, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "isEdit", NewValue = value, OldValue = _isEdit };
                    _isEdit = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicket> _getHelpDeskTicketsResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicket> getHelpDeskTicketsResult
        {
            get
            {
                return _getHelpDeskTicketsResult;
            }
            set
            {
                if (!object.Equals(_getHelpDeskTicketsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskTicketsResult", NewValue = value, OldValue = _getHelpDeskTicketsResult };
                    _getHelpDeskTicketsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getHelpDeskTicketsCount;
        protected int getHelpDeskTicketsCount
        {
            get
            {
                return _getHelpDeskTicketsCount;
            }
            set
            {
                if (!object.Equals(_getHelpDeskTicketsCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskTicketsCount", NewValue = value, OldValue = _getHelpDeskTicketsCount };
                    _getHelpDeskTicketsCount = value;
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

            var authenticationconnGetHelpDeskStatusesResult = await Authenticationconn.GetHelpDeskStatuses();
            getHelpDeskStatusesResult = authenticationconnGetHelpDeskStatusesResult.Value.AsODataEnumerable();

            var authenticationconnGetLocationListsResult = await Authenticationconn.GetLocationLists();
            getLocationListsResult = authenticationconnGetLocationListsResult.Value.AsODataEnumerable();

            var authenticationconnGetServiceCatglistsResult = await Authenticationconn.GetServiceCatglists();
            getServiceCatglistsResult = authenticationconnGetServiceCatglistsResult.Value.AsODataEnumerable();

            var authenticationconnGetServicesListsResult = await Authenticationconn.GetServicesLists();
            getServicesListsResult = authenticationconnGetServicesListsResult.Value.AsODataEnumerable();
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            helpdeskticket = new Testauth.Models.Authenticationconn.HelpDeskTicket();

            isEdit = false;
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var authenticationconnGetHelpDeskTicketsResult = await Authenticationconn.GetHelpDeskTickets(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", expand:$"HelpDeskTicketDetails,HelpDeskStatus,LocationList,ServiceCatglist,ServicesList", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getHelpDeskTicketsResult = authenticationconnGetHelpDeskTicketsResult.Value.AsODataEnumerable();

                getHelpDeskTicketsCount = authenticationconnGetHelpDeskTicketsResult.Count;
            }
            catch (System.Exception authenticationconnGetHelpDeskTicketsException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load HelpDeskTickets" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Testauth.Models.Authenticationconn.HelpDeskTicket args)
        {
            isEdit = true;

            helpdeskticket = args;
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var authenticationconnDeleteHelpDeskTicketResult = await Authenticationconn.DeleteHelpDeskTicket(id:data.Id);
                    if (authenticationconnDeleteHelpDeskTicketResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception authenticationconnDeleteHelpDeskTicketException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete HelpDeskTicket" });
            }
        }

        protected async System.Threading.Tasks.Task Form0Submit(Testauth.Models.Authenticationconn.HelpDeskTicket args)
        {
            try
            {
                if (isEdit)
                {
                    var authenticationconnUpdateHelpDeskTicketResult = await Authenticationconn.UpdateHelpDeskTicket(id:helpdeskticket.Id, helpDeskTicket:helpdeskticket);
                        NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Success,Summary = $"Success",Detail = $"HelpDeskTicket updated!" });



                    hasChanges = authenticationconnUpdateHelpDeskTicketResult.StatusCode == System.Net.HttpStatusCode.PreconditionFailed;
                }
            }
            catch (System.Exception authenticationconnUpdateHelpDeskTicketException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to update HelpDeskTicket" });
            }

            try
            {
                if (!this.isEdit)
                {
                    var authenticationconnCreateHelpDeskTicketResult = await Authenticationconn.CreateHelpDeskTicket(helpDeskTicket:args);
                    helpdeskticket = new Testauth.Models.Authenticationconn.HelpDeskTicket();

                        NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Success,Summary = $"Success",Detail = $"HelpDeskTicket created!" });
                }
            }
            catch (System.Exception authenticationconnCreateHelpDeskTicketException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new HelpDeskTicket!" });
            }
        }
    }
}
