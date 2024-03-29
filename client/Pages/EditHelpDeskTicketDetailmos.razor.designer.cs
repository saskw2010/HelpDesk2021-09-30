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
using Testauth.Client.Pages;

namespace Testauth.Pages
{
    public partial class EditHelpDeskTicketDetailmosComponent : ComponentBase
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

        [Parameter]
        public dynamic HelpDeskTicketId { get; set; }

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

        Testauth.Models.Authenticationconn.HelpDeskTicketDetail _helpdeskticketdetail;
        protected Testauth.Models.Authenticationconn.HelpDeskTicketDetail helpdeskticketdetail
        {
            get
            {
                return _helpdeskticketdetail;
            }
            set
            {
                if (!object.Equals(_helpdeskticketdetail, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "helpdeskticketdetail", NewValue = value, OldValue = _helpdeskticketdetail };
                    _helpdeskticketdetail = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Testauth.Models.Authenticationconn.HelpDeskTicket _getByHelpDeskTicketsForHelpDeskTicketIdResult;
        protected Testauth.Models.Authenticationconn.HelpDeskTicket getByHelpDeskTicketsForHelpDeskTicketIdResult
        {
            get
            {
                return _getByHelpDeskTicketsForHelpDeskTicketIdResult;
            }
            set
            {
                if (!object.Equals(_getByHelpDeskTicketsForHelpDeskTicketIdResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getByHelpDeskTicketsForHelpDeskTicketIdResult", NewValue = value, OldValue = _getByHelpDeskTicketsForHelpDeskTicketIdResult };
                    _getByHelpDeskTicketsForHelpDeskTicketIdResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicket> _getHelpDeskTicketsForHelpDeskTicketIdResult;
        protected IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicket> getHelpDeskTicketsForHelpDeskTicketIdResult
        {
            get
            {
                return _getHelpDeskTicketsForHelpDeskTicketIdResult;
            }
            set
            {
                if (!object.Equals(_getHelpDeskTicketsForHelpDeskTicketIdResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskTicketsForHelpDeskTicketIdResult", NewValue = value, OldValue = _getHelpDeskTicketsForHelpDeskTicketIdResult };
                    _getHelpDeskTicketsForHelpDeskTicketIdResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getHelpDeskTicketsForHelpDeskTicketIdCount;
        protected int getHelpDeskTicketsForHelpDeskTicketIdCount
        {
            get
            {
                return _getHelpDeskTicketsForHelpDeskTicketIdCount;
            }
            set
            {
                if (!object.Equals(_getHelpDeskTicketsForHelpDeskTicketIdCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getHelpDeskTicketsForHelpDeskTicketIdCount", NewValue = value, OldValue = _getHelpDeskTicketsForHelpDeskTicketIdCount };
                    _getHelpDeskTicketsForHelpDeskTicketIdCount = value;
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
                UriHelper.NavigateTo("", true);
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

            var authenticationconnGetHelpDeskTicketDetailByIdResult = await Authenticationconn.GetHelpDeskTicketDetailById(id:Id);
            helpdeskticketdetail = authenticationconnGetHelpDeskTicketDetailByIdResult;

            canEdit = authenticationconnGetHelpDeskTicketDetailByIdResult != null;

            if (this.helpdeskticketdetail.HelpDeskTicketId != null)
            {
                var authenticationconnGetHelpDeskTicketByIdResult = await Authenticationconn.GetHelpDeskTicketById(id:this.helpdeskticketdetail.HelpDeskTicketId);
                getByHelpDeskTicketsForHelpDeskTicketIdResult = authenticationconnGetHelpDeskTicketByIdResult;
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

        protected async System.Threading.Tasks.Task Form0Submit(Testauth.Models.Authenticationconn.HelpDeskTicketDetail args)
        {
            try
            {
                var authenticationconnUpdateHelpDeskTicketDetailResult = await Authenticationconn.UpdateHelpDeskTicketDetail(id:Id, helpDeskTicketDetail:helpdeskticketdetail);
                if (authenticationconnUpdateHelpDeskTicketDetailResult.StatusCode != System.Net.HttpStatusCode.PreconditionFailed) {
                  DialogService.Close(helpdeskticketdetail);
                }

                hasChanges = authenticationconnUpdateHelpDeskTicketDetailResult.StatusCode == System.Net.HttpStatusCode.PreconditionFailed;
            }
            catch (System.Exception authenticationconnUpdateHelpDeskTicketDetailException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to update HelpDeskTicketDetail" });
            }
        }

        protected async System.Threading.Tasks.Task HelpDeskTicketIdLoadData(LoadDataArgs args)
        {
            var authenticationconnGetHelpDeskTicketsResult = await Authenticationconn.GetHelpDeskTickets(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:true);
            getHelpDeskTicketsForHelpDeskTicketIdResult = authenticationconnGetHelpDeskTicketsResult.Value.AsODataEnumerable();

            getHelpDeskTicketsForHelpDeskTicketIdCount = authenticationconnGetHelpDeskTicketsResult.Count;
        }

        protected async System.Threading.Tasks.Task Button4Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
