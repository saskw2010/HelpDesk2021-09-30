using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;
using Microsoft.AspNetCore.Components;

namespace Testauth.Pages
{
    public partial class IEditHelpDeskTicketComponent
    {
        [Inject]
        protected GlobalsService GlobalsService { get; set; }
    }
}
