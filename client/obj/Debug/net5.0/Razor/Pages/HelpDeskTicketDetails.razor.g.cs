#pragma checksum "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2fb72ee7344c5242f6f9efcc1f36db28533a918"
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
#line 5 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
using Testauth.Models.Authenticationconn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
using Testauth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/help-desk-ticket-details")]
    public partial class HelpDeskTicketDetails : Testauth.Pages.HelpDeskTicketDetailsComponent
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
#line 16 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(11);
                __builder2.AddAttribute(12, "Icon", "add_circle_outline");
                __builder2.AddAttribute(13, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(14, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                   L["button0.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                              Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(17);
                __builder2.AddAttribute(18, "Icon", "get_app");
                __builder2.AddAttribute(19, "style", "margin-left: 10px; margin-bottom: 10px");
                __builder2.AddAttribute(20, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                L["splitbutton0.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                                Splitbutton0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(23);
                    __builder3.AddAttribute(24, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                          L["splitbutton0.excel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "Value", "xlsx");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(27);
                    __builder3.AddAttribute(28, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                          L["splitbutton0.csv.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Value", "csv");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(31);
                __builder2.AddAttribute(32, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                     L["textbox0.Placeholder"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(34, "Name", "Textbox0");
                __builder2.AddAttribute(35, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                                                     async(args) => {search = $"{args.Value}";await grid0.GoToPage(0);await grid0.Reload();}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(37);
                __builder2.AddAttribute(38, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                       FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                                          getHelpDeskTicketDetailsResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Count", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                                                                                  getHelpDeskTicketDetailsCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "LoadData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                                                                                                                                                                                            Grid0LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(45, "RowSelect", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>(this, 
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                                                                                                                                                                                                                       Grid0RowSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(46, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(47);
                    __builder3.AddAttribute(48, "Property", "Id");
                    __builder3.AddAttribute(49, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                        L["grid0.Id.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(51);
                    __builder3.AddAttribute(52, "Property", "HelpDeskTicketId");
                    __builder3.AddAttribute(53, "SortProperty", "HelpDeskTicket.TicketGUID");
                    __builder3.AddAttribute(54, "FilterProperty", "HelpDeskTicket.TicketGUID");
                    __builder3.AddAttribute(55, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                                                                                                                          L["grid0.HelpDeskTicketId.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>)((data) => (__builder4) => {
#nullable restore
#line 38 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
__builder4.AddContent(57, data.HelpDeskTicket?.TicketGUID);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(59);
                    __builder3.AddAttribute(60, "Property", "TicketDetailDate");
                    __builder3.AddAttribute(61, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(62, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                                                                    L["grid0.TicketDetailDate.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(64);
                    __builder3.AddAttribute(65, "Property", "TicketDescription");
                    __builder3.AddAttribute(66, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                                       L["grid0.TicketDescription.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(68);
                    __builder3.AddAttribute(69, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                              false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                               false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "Width", "70px");
                    __builder3.AddAttribute(72, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 45 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                                                              TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>)((testauthModelsAuthenticationconnHelpDeskTicketDetail) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(74);
                        __builder4.AddAttribute(75, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 47 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(76, "Icon", "close");
                        __builder4.AddAttribute(77, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 47 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(78, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, testauthModelsAuthenticationconnHelpDeskTicketDetail)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(79, "onclick", 
#nullable restore
#line 47 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                                                                                                                                                                                                                                    true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(80, (__value) => {
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\HelpDeskTicketDetails.razor"
                              grid0 = (Radzen.Blazor.RadzenDataGrid<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>)__value;

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<HelpDeskTicketDetails> L { get; set; }
    }
}
#pragma warning restore 1591
