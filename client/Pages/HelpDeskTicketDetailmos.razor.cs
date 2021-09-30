using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;
using Microsoft.AspNetCore.Components;

namespace Testauth.Pages
{
    public partial class HelpDeskTicketDetailmosComponent
    {
        [Parameter]
        public dynamic HelpDeskTicketId { get; set; }
    }
}
