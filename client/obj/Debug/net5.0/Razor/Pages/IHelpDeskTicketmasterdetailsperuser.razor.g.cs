#pragma checksum "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f36c3214b3d045036497318ae1e7cbb76e68565"
// <auto-generated/>
#pragma warning disable 1591
namespace Testauth.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\RadZenstock\authentication\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\RadZenstock\authentication\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\RadZenstock\authentication\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\RadZenstock\authentication\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\RadZenstock\authentication\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\RadZenstock\authentication\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\RadZenstock\authentication\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\RadZenstock\authentication\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\RadZenstock\authentication\client\_Imports.razor"
using Testauth.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\RadZenstock\authentication\client\_Imports.razor"
using Testauth.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
using Testauth.Models.Authenticationconn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
using Testauth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WidelayoutLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/i-help-desk-ticketmasterdetailsperuser")]
    public partial class IHelpDeskTicketmasterdetailsperuser : Testauth.Pages.IHelpDeskTicketmasterdetailsperuserComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                    L["pageTitle.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(11);
                __builder2.AddAttribute(12, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                     L["textbox0.Placeholder"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(14, "Name", "Textbox0");
                __builder2.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                     async(args) => {search = $"{args.Value}";await grid0.GoToPage(0);await grid0.Reload();}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Testauth.Models.Authenticationconn.HelpDeskTicket>>(17);
                __builder2.AddAttribute(18, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                     false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "AllowGrouping", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                           false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "AllowVirtualization", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Count", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                             getHelpDeskTicketsCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicket>>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                             getHelpDeskTicketsResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ExpandMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DataGridExpandMode>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                                   DataGridExpandMode.Multiple

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                                                                            FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "SelectionMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DataGridSelectionMode>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                                                                                                                                                                          DataGridSelectionMode.Multiple

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "LoadData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                                                                                                                                                                                                                     Grid0LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(29, "RowExpand", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Testauth.Models.Authenticationconn.HelpDeskTicket>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Testauth.Models.Authenticationconn.HelpDeskTicket>(this, 
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                                                                                                                                                                                                                                                Grid0RowExpand

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(30, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicket>>(31);
                    __builder3.AddAttribute(32, "Property", "TicketDescription");
                    __builder3.AddAttribute(33, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                 L["grid0.TicketDescription.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicket>>(35);
                    __builder3.AddAttribute(36, "FilterProperty", "HelpDeskStatus.TicketStatusDesc");
                    __builder3.AddAttribute(37, "GroupProperty", "HelpDeskStatus.TicketStatusDesc");
                    __builder3.AddAttribute(38, "Property", "TicketStatus");
                    __builder3.AddAttribute(39, "SortProperty", "HelpDeskStatus.TicketStatusDesc");
                    __builder3.AddAttribute(40, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                                                                            L["grid0.TicketStatus.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Testauth.Models.Authenticationconn.HelpDeskTicket>)((data) => (__builder4) => {
#nullable restore
#line 28 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
__builder4.AddContent(42, data.HelpDeskStatus?.TicketStatusDesc);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicket>>(44);
                    __builder3.AddAttribute(45, "FormatString", "{0:d}");
                    __builder3.AddAttribute(46, "Property", "TicketDate");
                    __builder3.AddAttribute(47, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                               L["grid0.TicketDate.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicket>>(49);
                    __builder3.AddAttribute(50, "FilterProperty", "LocationList.locationDesc");
                    __builder3.AddAttribute(51, "GroupProperty", "LocationList.locationDesc");
                    __builder3.AddAttribute(52, "Property", "locationID");
                    __builder3.AddAttribute(53, "SortProperty", "LocationList.locationDesc");
                    __builder3.AddAttribute(54, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                                                        L["grid0.locationID.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Testauth.Models.Authenticationconn.HelpDeskTicket>)((data) => (__builder4) => {
#nullable restore
#line 35 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
__builder4.AddContent(56, data.LocationList?.locationDesc);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicket>>(58);
                    __builder3.AddAttribute(59, "FilterProperty", "ServiceCatglist.ServiceCatgDesc");
                    __builder3.AddAttribute(60, "GroupProperty", "ServiceCatglist.ServiceCatgDesc");
                    __builder3.AddAttribute(61, "Property", "ServiceCatgID");
                    __builder3.AddAttribute(62, "SortProperty", "ServiceCatglist.ServiceCatgDesc");
                    __builder3.AddAttribute(63, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                                                                             L["grid0.ServiceCatgID.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(64, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Testauth.Models.Authenticationconn.HelpDeskTicket>)((data) => (__builder4) => {
#nullable restore
#line 40 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
__builder4.AddContent(65, data.ServiceCatglist?.ServiceCatgDesc);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicket>>(67);
                    __builder3.AddAttribute(68, "FilterProperty", "ServicesList.ServiceDesc");
                    __builder3.AddAttribute(69, "GroupProperty", "ServicesList.ServiceDesc");
                    __builder3.AddAttribute(70, "Property", "ServiceID");
                    __builder3.AddAttribute(71, "SortProperty", "ServicesList.ServiceDesc");
                    __builder3.AddAttribute(72, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                                                    L["grid0.ServiceID.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Testauth.Models.Authenticationconn.HelpDeskTicket>)((data) => (__builder4) => {
#nullable restore
#line 45 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
__builder4.AddContent(74, data.ServicesList?.ServiceDesc);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicket>>(76);
                    __builder3.AddAttribute(77, "Property", "Id");
                    __builder3.AddAttribute(78, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                  L["grid0.Id.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicket>>(80);
                    __builder3.AddAttribute(81, "Property", "TicketRequesterEmail");
                    __builder3.AddAttribute(82, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                    L["grid0.TicketRequesterEmail.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicket>>(84);
                    __builder3.AddAttribute(85, "Property", "TicketRequesterUser");
                    __builder3.AddAttribute(86, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                   L["grid0.TicketRequesterUser.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(87, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Testauth.Models.Authenticationconn.HelpDeskTicket>)((testauthModelsAuthenticationconnHelpDeskTicket) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGrid<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(88);
                    __builder3.AddAttribute(89, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                         false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(90, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(92, "ColumnWidth", "auto");
                    __builder3.AddAttribute(93, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(
#nullable restore
#line 56 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                  testauthModelsAuthenticationconnHelpDeskTicket.HelpDeskTicketDetails

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(94, "EmptyText", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                     L["grid1.EmptyText"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(95, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 56 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                                                       FilterMode.Advanced

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "style", "height: 754px");
                    __builder3.AddAttribute(97, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(98);
                        __builder4.AddAttribute(99, "FormatString", "{0:d}");
                        __builder4.AddAttribute(100, "Frozen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                   false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(101, "Groupable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                     false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(102, "Property", "TicketDetailDate");
                        __builder4.AddAttribute(103, "Reorderable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                     false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(104, "Resizable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                       true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(105, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                                                                                                                     L["grid1.TicketDetailDate.Title"]

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(106, "Width", "100px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(107, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(108);
                        __builder4.AddAttribute(109, "Property", "TicketDescription");
                        __builder4.AddAttribute(110, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                                                                                                                           L["grid1.TicketDescription.Title"]

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddComponentReferenceCapture(111, (__value) => {
#nullable restore
#line 56 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                                  grid1 = (Radzen.Blazor.RadzenDataGrid<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(112, (__value) => {
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\IHelpDeskTicketmasterdetailsperuser.razor"
                              grid0 = (Radzen.Blazor.RadzenDataGrid<Testauth.Models.Authenticationconn.HelpDeskTicket>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<IHelpDeskTicketmasterdetailsperuser> L { get; set; }
    }
}
#pragma warning restore 1591
