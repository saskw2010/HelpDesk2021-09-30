#pragma checksum "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77550c556ce7c4b73a37fe6b017b1ef180928457"
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
#line 5 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
using Testauth.Models.Authenticationconn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
using Testauth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-services-list")]
    public partial class AddServicesList : Testauth.Pages.AddServicesListComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Testauth.Models.Authenticationconn.ServicesList>>(11);
                __builder2.AddAttribute(12, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Testauth.Models.Authenticationconn.ServicesList>(
#nullable restore
#line 20 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                   serviceslist

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                            serviceslist != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Testauth.Models.Authenticationconn.ServicesList>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Testauth.Models.Authenticationconn.ServicesList>(this, 
#nullable restore
#line 20 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                                                                                    Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(21);
                    __builder3.AddAttribute(22, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                    L["ServiceDescLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Component", "ServiceDesc");
                    __builder3.AddAttribute(24, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(25, "\n              ");
                    __builder3.OpenElement(26, "div");
                    __builder3.AddAttribute(27, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(28);
                    __builder3.AddAttribute(29, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 28 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                          250

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "style", "width: 100%");
                    __builder3.AddAttribute(31, "Name", "ServiceDesc");
                    __builder3.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                  serviceslist.ServiceDesc

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => serviceslist.ServiceDesc = __value, serviceslist.ServiceDesc))));
                    __builder3.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => serviceslist.ServiceDesc));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\n            ");
                    __builder3.OpenElement(36, "div");
                    __builder3.AddAttribute(37, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(38, "class", "row");
                    __builder3.OpenElement(39, "div");
                    __builder3.AddAttribute(40, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(41);
                    __builder3.AddAttribute(42, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                    L["ServiceDesc1Label.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "Component", "ServiceDesc1");
                    __builder3.AddAttribute(44, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n              ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(48);
                    __builder3.AddAttribute(49, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 38 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                          250

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "style", "width: 100%");
                    __builder3.AddAttribute(51, "Name", "ServiceDesc1");
                    __builder3.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                  serviceslist.ServiceDesc1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => serviceslist.ServiceDesc1 = __value, serviceslist.ServiceDesc1))));
                    __builder3.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => serviceslist.ServiceDesc1));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(58, "class", "row");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(61);
                    __builder3.AddAttribute(62, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                    L["AuditCCLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "Component", "AuditCC");
                    __builder3.AddAttribute(64, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\n              ");
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(68);
                    __builder3.AddAttribute(69, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 48 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                          250

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "style", "width: 100%");
                    __builder3.AddAttribute(71, "Name", "AuditCC");
                    __builder3.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                  serviceslist.AuditCC

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => serviceslist.AuditCC = __value, serviceslist.AuditCC))));
                    __builder3.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => serviceslist.AuditCC));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(78, "class", "row");
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(81);
                    __builder3.AddAttribute(82, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                    L["assignToLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "Component", "assignTo");
                    __builder3.AddAttribute(84, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\n              ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(88);
                    __builder3.AddAttribute(89, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 58 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                          250

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(90, "style", "width: 100%");
                    __builder3.AddAttribute(91, "Name", "AssignTo");
                    __builder3.AddAttribute(92, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                  serviceslist.assignTo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => serviceslist.assignTo = __value, serviceslist.assignTo))));
                    __builder3.AddAttribute(94, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => serviceslist.assignTo));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(98, "class", "row");
                    __builder3.OpenElement(99, "div");
                    __builder3.AddAttribute(100, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(101);
                    __builder3.AddAttribute(102, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                    L["ServiceCatgIDLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(103, "Component", "ServiceCatgID");
                    __builder3.AddAttribute(104, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(105, "\n              ");
                    __builder3.OpenElement(106, "div");
                    __builder3.AddAttribute(107, "class", "col-md-9");
                    __Blazor.Testauth.Client.Pages.AddServicesList.TypeInference.CreateRadzenDropDownDataGrid_0(__builder3, 108, 109, 
#nullable restore
#line 68 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                               getServiceCatglistsForServiceCatgIDResult

#line default
#line hidden
#nullable disable
                    , 110, "ServiceCatgDesc", 111, "ServiceCatgID", 112, 
#nullable restore
#line 68 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                                                                                                     L["ServiceCatgID.Placeholder"]

#line default
#line hidden
#nullable disable
                    , 113, 
#nullable restore
#line 68 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                                                                                                                                                 false

#line default
#line hidden
#nullable disable
                    , 114, 
#nullable restore
#line 68 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                                                                                                                                                                getServiceCatglistsForServiceCatgIDCount

#line default
#line hidden
#nullable disable
                    , 115, "display: block; width: 100%", 116, "ServiceCatgID", 117, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 68 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                                                                                                                                                                                                                                                                                                                          ServiceCatgIdLoadData

#line default
#line hidden
#nullable disable
                    ), 118, 
#nullable restore
#line 68 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                                                                                                                                                                                                                                                             serviceslist.ServiceCatgID

#line default
#line hidden
#nullable disable
                    , 119, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => serviceslist.ServiceCatgID = __value, serviceslist.ServiceCatgID)), 120, () => serviceslist.ServiceCatgID);
                    __builder3.AddMarkupContent(121, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(122);
                    __builder3.AddAttribute(123, "Component", "ServiceCatgID");
                    __builder3.AddAttribute(124, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 70 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                          L["ServiceCatgIDRequiredValidator.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(125, "style", "position: absolute");
                    __builder3.AddAttribute(126, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 70 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                                                                                             0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(127, "\n            ");
                    __builder3.OpenElement(128, "div");
                    __builder3.AddAttribute(129, "class", "row");
                    __builder3.OpenElement(130, "div");
                    __builder3.AddAttribute(131, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(132);
                    __builder3.AddAttribute(133, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 76 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(134, "Icon", "save");
                    __builder3.AddAttribute(135, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 76 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                L["button1.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(136, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 76 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                                                ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(137, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(138);
                    __builder3.AddAttribute(139, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 78 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(140, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(141, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 78 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                               L["button2.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(142, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "E:\RadZenstock\authentication\client\Pages\AddServicesList.razor"
                                                                                                                          Button2Click

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<AddServicesList> L { get; set; }
    }
}
namespace __Blazor.Testauth.Client.Pages.AddServicesList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDownDataGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Int32 __arg5, int __seq6, System.Object __arg6, int __seq7, global::System.String __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<global::Radzen.LoadDataArgs> __arg8, int __seq9, global::System.Object __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg10, int __seq11, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg11)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "ShowSearch", __arg4);
        __builder.AddAttribute(__seq5, "Count", __arg5);
        __builder.AddAttribute(__seq6, "style", __arg6);
        __builder.AddAttribute(__seq7, "Name", __arg7);
        __builder.AddAttribute(__seq8, "LoadData", __arg8);
        __builder.AddAttribute(__seq9, "Value", __arg9);
        __builder.AddAttribute(__seq10, "ValueChanged", __arg10);
        __builder.AddAttribute(__seq11, "ValueExpression", __arg11);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
