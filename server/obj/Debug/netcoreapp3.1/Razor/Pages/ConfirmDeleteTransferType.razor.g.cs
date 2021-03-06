#pragma checksum "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteTransferType.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f062248320558ba7d48a9c49c169af5d7798945e"
// <auto-generated/>
#pragma warning disable 1591
namespace SoccerLeagueTransferApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using SoccerLeagueTransferApp.Shared;

#line default
#line hidden
#line 5 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteTransferType.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteTransferType.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteTransferType.razor"
using SoccerLeagueTransferApp.Models.ConData;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/confirm-delete-transfer-type/{TransferTypeID}")]
    public partial class ConfirmDeleteTransferType : SoccerLeagueTransferApp.Pages.ConfirmDeleteTransferTypeComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<SoccerLeagueTransferApp.Models.ConData.TransferType>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SoccerLeagueTransferApp.Models.ConData.TransferType>(
#line 12 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteTransferType.razor"
                                   transfertype

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteTransferType.razor"
                                                                                                                        transfertype != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<SoccerLeagueTransferApp.Models.ConData.TransferType>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<SoccerLeagueTransferApp.Models.ConData.TransferType>(this, 
#line 12 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteTransferType.razor"
                                                                                                                                                        Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHeading>(23);
                    __builder3.AddAttribute(24, "Size", "H1");
                    __builder3.AddAttribute(25, "style", "width: 226px");
                    __builder3.AddAttribute(26, "Text", "Transfer Type");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\n            ");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(32, "class", "row");
                    __builder3.AddMarkupContent(33, "\n              ");
                    __builder3.OpenElement(34, "div");
                    __builder3.AddAttribute(35, "class", "col-md-3");
                    __builder3.AddMarkupContent(36, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHeading>(37);
                    __builder3.AddAttribute(38, "Size", "H3");
                    __builder3.AddAttribute(39, "style", "width: 413px");
                    __builder3.AddAttribute(40, "Text", "Confirm If You Want To Delete This Transfer Type");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(46, "class", "row");
                    __builder3.AddMarkupContent(47, "\n              ");
                    __builder3.OpenElement(48, "div");
                    __builder3.AddAttribute(49, "class", "col-md-3");
                    __builder3.AddMarkupContent(50, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(51);
                    __builder3.AddAttribute(52, "Component", "TransferTypeName");
                    __builder3.AddAttribute(53, "style", "width: 100%");
                    __builder3.AddAttribute(54, "Text", "Transfer Type Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\n              ");
                    __builder3.OpenElement(57, "div");
                    __builder3.AddAttribute(58, "class", "col-md-9");
                    __builder3.AddMarkupContent(59, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(60);
                    __builder3.AddAttribute(61, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteTransferType.razor"
                                     $"{(transfertype.TransferTypeName)}"

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\n            ");
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "class", "row");
                    __builder3.AddMarkupContent(67, "\n              ");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(70, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(71);
                    __builder3.AddAttribute(72, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteTransferType.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(73, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteTransferType.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(74, "Icon", "close");
                    __builder3.AddAttribute(75, "Text", "Delete Transfer Type");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(77);
                    __builder3.AddAttribute(78, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 40 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteTransferType.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(79, "Text", "Cancel");
                    __builder3.AddAttribute(80, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 40 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteTransferType.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
