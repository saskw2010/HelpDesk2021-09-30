#pragma checksum "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3790e3cdae0b5ecfa33bc2499fd5ec495d42cfe3"
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
#line 5 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
using Testauth.Models.Authenticationconn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
using Testauth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WidelayoutLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-help-desk-ticket-detailmos/{Id}/{HelpDeskTicketId}")]
    public partial class EditHelpDeskTicketDetailmos : Testauth.Pages.EditHelpDeskTicketDetailmosComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(7);
                __builder2.AddAttribute(8, "style", "font-weight: bold");
                __builder2.AddAttribute(9, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                      L["closeLabel.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                       !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\n      ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(17, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                             L["closeButton.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                               !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                                                  CloseButtonClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "row");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(25);
                __builder2.AddAttribute(26, "style", "font-weight: bold");
                __builder2.AddAttribute(27, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                      L["label0.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                  hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n      ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(32);
                __builder2.AddAttribute(33, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Icon", "autorenew");
                __builder2.AddAttribute(35, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(36, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                              L["button0.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                                           hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(44);
                __builder2.AddAttribute(45, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>(
#nullable restore
#line 38 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                   helpdeskticketdetail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                                    helpdeskticketdetail != null && canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>(this, 
#nullable restore
#line 38 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                                                                                       Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(49, "div");
                    __builder3.AddAttribute(50, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(51, "class", "row");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                    __builder3.AddAttribute(55, "Component", "HelpDeskTicketId");
                    __builder3.AddAttribute(56, "style", "width: 100%");
                    __builder3.AddAttribute(57, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                     L["HelpDeskTicketIdLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __Blazor.Testauth.Client.Pages.EditHelpDeskTicketDetailmos.TypeInference.CreateRadzenDropDownDataGrid_0(__builder3, 61, 62, 
#nullable restore
#line 46 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                getHelpDeskTicketsForHelpDeskTicketIdCount

#line default
#line hidden
#nullable disable
                    , 63, 
#nullable restore
#line 46 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                   getHelpDeskTicketsForHelpDeskTicketIdResult

#line default
#line hidden
#nullable disable
                    , 64, 
#nullable restore
#line 46 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                                                          true

#line default
#line hidden
#nullable disable
                    , 65, 
#nullable restore
#line 46 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                                                                              L["HelpDeskTicketId.Placeholder"]

#line default
#line hidden
#nullable disable
                    , 66, 
#nullable restore
#line 46 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                                                                                                                                 getByHelpDeskTicketsForHelpDeskTicketIdResult

#line default
#line hidden
#nullable disable
                    , 67, 
#nullable restore
#line 46 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                                                                                                                                                                                            false

#line default
#line hidden
#nullable disable
                    , 68, "display: block; width: 100%", 69, "TicketGUID", 70, "Id", 71, "HelpDeskTicketId", 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 46 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              HelpDeskTicketIdLoadData

#line default
#line hidden
#nullable disable
                    ), 73, 
#nullable restore
#line 46 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                                                                                                                                                                                                                                                                                helpdeskticketdetail.HelpDeskTicketId

#line default
#line hidden
#nullable disable
                    , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => helpdeskticketdetail.HelpDeskTicketId = __value, helpdeskticketdetail.HelpDeskTicketId)), 75, () => helpdeskticketdetail.HelpDeskTicketId);
                    __builder3.AddMarkupContent(76, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(77);
                    __builder3.AddAttribute(78, "Component", "HelpDeskTicketId");
                    __builder3.AddAttribute(79, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 48 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                    0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "style", "position: absolute");
                    __builder3.AddAttribute(81, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                         L["HelpDeskTicketIdRequiredValidator.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\n            ");
                    __builder3.OpenElement(83, "div");
                    __builder3.AddAttribute(84, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(85, "class", "row");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(88);
                    __builder3.AddAttribute(89, "Component", "TicketDetailDate");
                    __builder3.AddAttribute(90, "style", "width: 100%");
                    __builder3.AddAttribute(91, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                     L["TicketDetailDateLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\n              ");
                    __builder3.OpenElement(93, "div");
                    __builder3.AddAttribute(94, "class", "col-md-9");
                    __Blazor.Testauth.Client.Pages.EditHelpDeskTicketDetailmos.TypeInference.CreateRadzenDatePicker_1(__builder3, 95, 96, 
#nullable restore
#line 58 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                            true

#line default
#line hidden
#nullable disable
                    , 97, "width: 209.5px", 98, "TicketDetailDate", 99, 
#nullable restore
#line 58 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                        helpdeskticketdetail.TicketDetailDate

#line default
#line hidden
#nullable disable
                    , 100, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => helpdeskticketdetail.TicketDetailDate = __value, helpdeskticketdetail.TicketDetailDate)), 101, () => helpdeskticketdetail.TicketDetailDate);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\n            ");
                    __builder3.OpenElement(103, "div");
                    __builder3.AddAttribute(104, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(105, "class", "row");
                    __builder3.OpenElement(106, "div");
                    __builder3.AddAttribute(107, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(108);
                    __builder3.AddAttribute(109, "Component", "TicketDescription");
                    __builder3.AddAttribute(110, "style", "width: 100%");
                    __builder3.AddAttribute(111, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                      L["TicketDescriptionLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\n              ");
                    __builder3.OpenElement(113, "div");
                    __builder3.AddAttribute(114, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(115);
                    __builder3.AddAttribute(116, "style", "display: block; height: 184px; width: 100%");
                    __builder3.AddAttribute(117, "Name", "TicketDescription");
                    __builder3.AddAttribute(118, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                 helpdeskticketdetail.TicketDescription

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(119, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => helpdeskticketdetail.TicketDescription = __value, helpdeskticketdetail.TicketDescription))));
                    __builder3.AddAttribute(120, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => helpdeskticketdetail.TicketDescription));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(121, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(122);
                    __builder3.AddAttribute(123, "Component", "TicketDescription");
                    __builder3.AddAttribute(124, "style", "position: absolute");
                    __builder3.AddAttribute(125, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 70 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                         L["TicketDescriptionRequiredValidator.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(126, "\n            ");
                    __builder3.OpenElement(127, "div");
                    __builder3.AddAttribute(128, "class", "row");
                    __builder3.OpenElement(129, "div");
                    __builder3.AddAttribute(130, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(131);
                    __builder3.AddAttribute(132, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 76 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(133, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 76 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(134, "Icon", "save");
                    __builder3.AddAttribute(135, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 76 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                                                  L["button3.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(136, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(137);
                    __builder3.AddAttribute(138, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 78 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(139, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(140, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 78 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
                                                                                               L["button4.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(141, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "E:\RadZenstock\authentication\client\Pages\EditHelpDeskTicketDetailmos.razor"
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<EditHelpDeskTicketDetailmos> L { get; set; }
    }
}
namespace __Blazor.Testauth.Client.Pages.EditHelpDeskTicketDetailmos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDownDataGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Int32 __arg0, int __seq1, global::System.Collections.IEnumerable __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Object __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, System.Object __arg6, int __seq7, global::System.String __arg7, int __seq8, global::System.String __arg8, int __seq9, global::System.String __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<global::Radzen.LoadDataArgs> __arg10, int __seq11, global::System.Object __arg11, int __seq12, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg12, int __seq13, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg13)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Count", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "Disabled", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "SelectedValue", __arg4);
        __builder.AddAttribute(__seq5, "ShowSearch", __arg5);
        __builder.AddAttribute(__seq6, "style", __arg6);
        __builder.AddAttribute(__seq7, "TextProperty", __arg7);
        __builder.AddAttribute(__seq8, "ValueProperty", __arg8);
        __builder.AddAttribute(__seq9, "Name", __arg9);
        __builder.AddAttribute(__seq10, "LoadData", __arg10);
        __builder.AddAttribute(__seq11, "Value", __arg11);
        __builder.AddAttribute(__seq12, "ValueChanged", __arg12);
        __builder.AddAttribute(__seq13, "ValueExpression", __arg13);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Disabled", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
