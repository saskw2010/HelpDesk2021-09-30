#pragma checksum "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5147398f9306563462f5ff7ac73cbe47b59fc33b"
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
#line 5 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
using Testauth.Models.Authenticationconn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
using Testauth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-ticket-requester-users-list/{TicketRequesterUser}")]
    public partial class EditTicketRequesterUsersList : Testauth.Pages.EditTicketRequesterUsersListComponent
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
#line 16 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
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
                __builder2.AddAttribute(10, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(11);
                __builder2.AddAttribute(12, "style", "font-weight: bold");
                __builder2.AddAttribute(13, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                      L["closeLabel.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                       !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\n      ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(18);
                __builder2.AddAttribute(19, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 24 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(21, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                             L["closeButton.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                                                               !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                                                                                  CloseButtonClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "row");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(29);
                __builder2.AddAttribute(30, "style", "font-weight: bold");
                __builder2.AddAttribute(31, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                      L["label0.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                  hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n      ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(36);
                __builder2.AddAttribute(37, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 34 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Icon", "autorenew");
                __builder2.AddAttribute(39, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(40, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                                              L["button0.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                                                                           hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "row");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Testauth.Models.Authenticationconn.TicketRequesterUsersList>>(48);
                __builder2.AddAttribute(49, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Testauth.Models.Authenticationconn.TicketRequesterUsersList>(
#nullable restore
#line 40 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                                       ticketrequesteruserslist

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                                                                            ticketrequesteruserslist != null && canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "Submit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Testauth.Models.Authenticationconn.TicketRequesterUsersList>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Testauth.Models.Authenticationconn.TicketRequesterUsersList>(this, 
#nullable restore
#line 40 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                                                                                                                                   Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(53, "div");
                    __builder3.AddAttribute(54, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(55, "class", "row");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(58);
                    __builder3.AddAttribute(59, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                    L["TicketRequesterUserLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "Component", "TicketRequesterUser");
                    __builder3.AddAttribute(61, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(62, "\n              ");
                    __builder3.OpenElement(63, "div");
                    __builder3.AddAttribute(64, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(65);
                    __builder3.AddAttribute(66, "MaxLength", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 48 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                          250

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(68, "Name", "TicketRequesterUser");
                    __builder3.AddAttribute(69, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                                  ticketrequesteruserslist.TicketRequesterUser

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticketrequesteruserslist.TicketRequesterUser = __value, ticketrequesteruserslist.TicketRequesterUser))));
                    __builder3.AddAttribute(71, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticketrequesteruserslist.TicketRequesterUser));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(73);
                    __builder3.AddAttribute(74, "Component", "TicketRequesterUser");
                    __builder3.AddAttribute(75, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                L["TicketRequesterUserRequiredValidator.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(80, "class", "row");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(83);
                    __builder3.AddAttribute(84, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                    L["TicketRequesterEmailLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "Component", "TicketRequesterEmail");
                    __builder3.AddAttribute(86, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\n              ");
                    __builder3.OpenElement(88, "div");
                    __builder3.AddAttribute(89, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(90);
                    __builder3.AddAttribute(91, "MaxLength", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 60 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                          500

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(92, "style", "width: 100%");
                    __builder3.AddAttribute(93, "Name", "TicketRequesterEmail");
                    __builder3.AddAttribute(94, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                  ticketrequesteruserslist.TicketRequesterEmail

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(95, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticketrequesteruserslist.TicketRequesterEmail = __value, ticketrequesteruserslist.TicketRequesterEmail))));
                    __builder3.AddAttribute(96, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticketrequesteruserslist.TicketRequesterEmail));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\n            ");
                    __builder3.OpenElement(98, "div");
                    __builder3.AddAttribute(99, "class", "row");
                    __builder3.OpenElement(100, "div");
                    __builder3.AddAttribute(101, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(102);
                    __builder3.AddAttribute(103, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 66 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(104, "Icon", "save");
                    __builder3.AddAttribute(105, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                L["button3.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(106, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 66 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                                                ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(108);
                    __builder3.AddAttribute(109, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 68 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(110, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(111, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                               L["button4.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(112, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "E:\RadZenstock\authentication\client\Pages\EditTicketRequesterUsersList.razor"
                                                                                                                          Button4Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<EditTicketRequesterUsersList> L { get; set; }
    }
}
#pragma warning restore 1591
