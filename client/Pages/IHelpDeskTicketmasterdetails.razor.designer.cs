﻿using System;
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
    public partial class IHelpDeskTicketmasterdetailsComponent : ComponentBase
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
        protected RadzenDataGrid<Testauth.Models.Authenticationconn.HelpDeskTicketDetail> grid1;

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

        dynamic _master;
        protected dynamic master
        {
            get
            {
                return _master;
            }
            set
            {
                if (!object.Equals(_master, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "master", NewValue = value, OldValue = _master };
                    _master = value;
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

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var authenticationconnGetHelpDeskTicketsResult = await Authenticationconn.GetHelpDeskTickets(orderby:$"{args.OrderBy}", expand:$"HelpDeskStatus,LocationList,ServiceCatglist,ServicesList", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getHelpDeskTicketsResult = authenticationconnGetHelpDeskTicketsResult.Value.AsODataEnumerable();

                getHelpDeskTicketsCount = authenticationconnGetHelpDeskTicketsResult.Count;
            }
            catch (System.Exception authenticationconnGetHelpDeskTicketsException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load HelpDeskTickets" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowExpand(Testauth.Models.Authenticationconn.HelpDeskTicket args)
        {
            master = args;

            var authenticationconnGetHelpDeskTicketDetailsResult = await Authenticationconn.GetHelpDeskTicketDetails(filter:$"HelpDeskTicketId eq {args.Id}");
            args.HelpDeskTicketDetails = authenticationconnGetHelpDeskTicketDetailsResult.Value;
        }
    }
}
