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
    public partial class AddServiceCatglistComponent : ComponentBase
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

        Testauth.Models.Authenticationconn.ServiceCatglist _servicecatglist;
        protected Testauth.Models.Authenticationconn.ServiceCatglist servicecatglist
        {
            get
            {
                return _servicecatglist;
            }
            set
            {
                if (!object.Equals(_servicecatglist, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "servicecatglist", NewValue = value, OldValue = _servicecatglist };
                    _servicecatglist = value;
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
            servicecatglist = new Testauth.Models.Authenticationconn.ServiceCatglist(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Testauth.Models.Authenticationconn.ServiceCatglist args)
        {
            try
            {
                var authenticationconnCreateServiceCatglistResult = await Authenticationconn.CreateServiceCatglist(serviceCatglist:servicecatglist);
                UriHelper.NavigateTo("service-catglists");
            }
            catch (System.Exception authenticationconnCreateServiceCatglistException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new ServiceCatglist!" });
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("service-catglists");
        }
    }
}
