#pragma checksum "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a3957953d7c5de8d5e4c0e374089c7f8593b6f6"
// <auto-generated/>
#pragma warning disable 1591
namespace FlexMoney.Client.Pages.Report
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.RoleClaims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Preferences;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Catalog.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Catalog.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Communication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Audit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Misc.Document;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Misc.DocumentType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Shared.Constants.Permission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Shared.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Application.Requests.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
using FlexMoney.Application.Features.Reports.Queries.GetAll;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
           [Authorize(Policy = Permissions.Reports.View)]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/catalog/reports/allmembers")]
    public partial class AllMembersReport : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    .mud-table-container {\n        overflow: auto;\n    }\n</style>\n");
            __builder.OpenComponent<global::FlexMoney.Client.Shared.Components.HeroTitle>(1);
            __builder.AddAttribute(2, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 10 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                   _localizer["All Members Report"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Description", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 10 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                                                   _localizer["Manage Reports."]

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
 if (!_loaded)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::MudBlazor.MudProgressCircular>(4);
            __builder.AddAttribute(5, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 13 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Indeterminate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 13 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 14 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
}
else
{

#line default
#line hidden
#nullable disable
            global::__Blazor.FlexMoney.Client.Pages.Report.AllMembersReport.TypeInference.CreateMudTable_0(__builder, 7, 8, 
#nullable restore
#line 17 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                     true

#line default
#line hidden
#nullable disable
            , 9, 
#nullable restore
#line 17 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                      25

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line 17 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                                 _allMemberReportList

#line default
#line hidden
#nullable disable
            , 11, 
#nullable restore
#line 17 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                                                               _dense

#line default
#line hidden
#nullable disable
            , 12, 
#nullable restore
#line 17 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                                                                                  _bordered

#line default
#line hidden
#nullable disable
            , 13, 
#nullable restore
#line 17 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                                                                                                       _striped

#line default
#line hidden
#nullable disable
            , 14, 
#nullable restore
#line 17 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                                                                                                                         new Func<GetAllMembersReportResponse, bool>(Search)

#line default
#line hidden
#nullable disable
            , 15, 
#nullable restore
#line 17 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                                                                                                                                                                                            _allMemberReport

#line default
#line hidden
#nullable disable
            , 16, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _allMemberReport = __value, _allMemberReport), 17, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudToolBarSpacer>(18);
                __builder2.CloseComponent();
            }
            , 19, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(20);
                __builder2.AddAttribute(21, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    global::__Blazor.FlexMoney.Client.Pages.Report.AllMembersReport.TypeInference.CreateMudTableSortLabel_1(__builder3, 22, 23, 
#nullable restore
#line 26 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                              new Func<GetAllMembersReportResponse, object>(x => x.MemberName)

#line default
#line hidden
#nullable disable
                    , 24, (__builder4) => {
#nullable restore
#line 26 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
__builder4.AddContent(25, _localizer["MemberName"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(27);
                __builder2.AddAttribute(28, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    global::__Blazor.FlexMoney.Client.Pages.Report.AllMembersReport.TypeInference.CreateMudTableSortLabel_2(__builder3, 29, 30, 
#nullable restore
#line 27 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                              new Func<GetAllMembersReportResponse, object>(x => x.Earn)

#line default
#line hidden
#nullable disable
                    , 31, (__builder4) => {
#nullable restore
#line 27 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
__builder4.AddContent(32, _localizer["Earn"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(34);
                __builder2.AddAttribute(35, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    global::__Blazor.FlexMoney.Client.Pages.Report.AllMembersReport.TypeInference.CreateMudTableSortLabel_3(__builder3, 36, 37, 
#nullable restore
#line 28 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                              new Func<GetAllMembersReportResponse, object>(x => x.Pay)

#line default
#line hidden
#nullable disable
                    , 38, (__builder4) => {
#nullable restore
#line 28 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
__builder4.AddContent(39, _localizer["Pay"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(41);
                __builder2.AddAttribute(42, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    global::__Blazor.FlexMoney.Client.Pages.Report.AllMembersReport.TypeInference.CreateMudTableSortLabel_4(__builder3, 43, 44, 
#nullable restore
#line 29 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                              new Func<GetAllMembersReportResponse, object>(x => x.ThankMoney)

#line default
#line hidden
#nullable disable
                    , 45, (__builder4) => {
#nullable restore
#line 29 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
__builder4.AddContent(46, _localizer["ThankMoney"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(48);
                __builder2.AddAttribute(49, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    global::__Blazor.FlexMoney.Client.Pages.Report.AllMembersReport.TypeInference.CreateMudTableSortLabel_5(__builder3, 50, 51, 
#nullable restore
#line 30 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                              new Func<GetAllMembersReportResponse, object>(x => x.Dead)

#line default
#line hidden
#nullable disable
                    , 52, (__builder4) => {
#nullable restore
#line 30 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
__builder4.AddContent(53, _localizer["Dead"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(55);
                __builder2.AddAttribute(56, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    global::__Blazor.FlexMoney.Client.Pages.Report.AllMembersReport.TypeInference.CreateMudTableSortLabel_6(__builder3, 57, 58, 
#nullable restore
#line 31 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                              new Func<GetAllMembersReportResponse, object>(x => x.Alive)

#line default
#line hidden
#nullable disable
                    , 59, (__builder4) => {
#nullable restore
#line 31 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
__builder4.AddContent(60, _localizer["Alive"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            , 61, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(62);
                __builder2.AddAttribute(63, "DataLabel", "Name");
                __builder2.AddAttribute(64, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudHighlighter>(65);
                    __builder3.AddAttribute(66, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 37 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                       context.MemberName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "HighlightedText", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 37 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                                                             _searchString

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(69);
                __builder2.AddAttribute(70, "DataLabel", "Earn");
                __builder2.AddAttribute(71, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudHighlighter>(72);
                    __builder3.AddAttribute(73, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 40 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                        $"{context.Earn}"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(75);
                __builder2.AddAttribute(76, "DataLabel", "Pay");
                __builder2.AddAttribute(77, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudHighlighter>(78);
                    __builder3.AddAttribute(79, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 43 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                        $"{context.Pay}"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(81);
                __builder2.AddAttribute(82, "DataLabel", "Thank Money");
                __builder2.AddAttribute(83, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudHighlighter>(84);
                    __builder3.AddAttribute(85, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 46 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                        $"{context.ThankMoney}"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(87);
                __builder2.AddAttribute(88, "DataLabel", "Dead");
                __builder2.AddAttribute(89, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudHighlighter>(90);
                    __builder3.AddAttribute(91, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 49 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                        $"{context.Dead}"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(93);
                __builder2.AddAttribute(94, "DataLabel", "Alive");
                __builder2.AddAttribute(95, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudHighlighter>(96);
                    __builder3.AddAttribute(97, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 52 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                        $"{context.Alive}"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 98, (__builder2) => {
                global::__Blazor.FlexMoney.Client.Pages.Report.AllMembersReport.TypeInference.CreateMudSwitch_7(__builder2, 99, 100, 
#nullable restore
#line 56 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                                      Color.Secondary

#line default
#line hidden
#nullable disable
                , 101, "margin-left: 5px;", 102, 
#nullable restore
#line 56 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                       _dense

#line default
#line hidden
#nullable disable
                , 103, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _dense = __value, _dense)), 104, (__builder3) => {
#nullable restore
#line 56 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
__builder3.AddContent(105, _localizer["Dense"]);

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(106, "\n            ");
                global::__Blazor.FlexMoney.Client.Pages.Report.AllMembersReport.TypeInference.CreateMudSwitch_8(__builder2, 107, 108, 
#nullable restore
#line 57 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                                        Color.Tertiary

#line default
#line hidden
#nullable disable
                , 109, "margin-left: 5px;", 110, 
#nullable restore
#line 57 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                       _striped

#line default
#line hidden
#nullable disable
                , 111, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _striped = __value, _striped)), 112, (__builder3) => {
#nullable restore
#line 57 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
__builder3.AddContent(113, _localizer["Striped"]);

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(114, "\n            ");
                global::__Blazor.FlexMoney.Client.Pages.Report.AllMembersReport.TypeInference.CreateMudSwitch_9(__builder2, 115, 116, 
#nullable restore
#line 58 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                                         Color.Warning

#line default
#line hidden
#nullable disable
                , 117, "margin-left: 5px;", 118, 
#nullable restore
#line 58 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
                                       _bordered

#line default
#line hidden
#nullable disable
                , 119, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _bordered = __value, _bordered)), 120, (__builder3) => {
#nullable restore
#line 58 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
__builder3.AddContent(121, _localizer["Bordered"]);

#line default
#line hidden
#nullable disable
                }
                );
            }
            , 122, (__builder2) => {
                __builder2.OpenComponent<global::FlexMoney.Client.Shared.Components.TablePager>(123);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 64 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Report\AllMembersReport.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<AllMembersReport> _localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserManager _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientPreferenceManager _clientPreferenceManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpInterceptorManager _interceptor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService _dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorizationService _authorizationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorHeroStateProvider _stateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountManager _accountManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationManager _authenticationManager { get; set; }
    }
}
namespace __Blazor.FlexMoney.Client.Pages.Report.AllMembersReport
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Int32 __arg1, int __seq2, global::System.Collections.Generic.IEnumerable<T> __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Func<T, global::System.Boolean> __arg6, int __seq7, global::System.Object __arg7, int __seq8, global::System.Object __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10, int __seq11, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg11, int __seq12, global::Microsoft.AspNetCore.Components.RenderFragment __arg12, int __seq13, global::Microsoft.AspNetCore.Components.RenderFragment __arg13)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Hover", __arg0);
        __builder.AddAttribute(__seq1, "Elevation", __arg1);
        __builder.AddAttribute(__seq2, "Items", __arg2);
        __builder.AddAttribute(__seq3, "Dense", __arg3);
        __builder.AddAttribute(__seq4, "Bordered", __arg4);
        __builder.AddAttribute(__seq5, "Striped", __arg5);
        __builder.AddAttribute(__seq6, "Filter", __arg6);
        __builder.AddAttribute(__seq7, "member", __arg7);
        __builder.AddAttribute(__seq8, "memberChanged", __arg8);
        __builder.AddAttribute(__seq9, "ToolBarContent", __arg9);
        __builder.AddAttribute(__seq10, "HeaderContent", __arg10);
        __builder.AddAttribute(__seq11, "RowTemplate", __arg11);
        __builder.AddAttribute(__seq12, "FooterContent", __arg12);
        __builder.AddAttribute(__seq13, "PagerContent", __arg13);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSwitch_7<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Color __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudSwitch<T>>(seq);
        __builder.AddAttribute(__seq0, "Color", __arg0);
        __builder.AddAttribute(__seq1, "Style", __arg1);
        __builder.AddAttribute(__seq2, "Checked", __arg2);
        __builder.AddAttribute(__seq3, "CheckedChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudSwitch_8<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Color __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudSwitch<T>>(seq);
        __builder.AddAttribute(__seq0, "Color", __arg0);
        __builder.AddAttribute(__seq1, "Style", __arg1);
        __builder.AddAttribute(__seq2, "Checked", __arg2);
        __builder.AddAttribute(__seq3, "CheckedChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudSwitch_9<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Color __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudSwitch<T>>(seq);
        __builder.AddAttribute(__seq0, "Color", __arg0);
        __builder.AddAttribute(__seq1, "Style", __arg1);
        __builder.AddAttribute(__seq2, "Checked", __arg2);
        __builder.AddAttribute(__seq3, "CheckedChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591