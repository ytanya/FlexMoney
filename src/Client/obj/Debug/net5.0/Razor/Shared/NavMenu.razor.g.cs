#pragma checksum "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11aec46ce139ecd3076a1c5a75b8b2ca700cb593"
// <auto-generated/>
#pragma warning disable 1591
namespace FlexMoney.Client.Shared
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
#line 2 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::FlexMoney.Client.Shared.Components.UserCard>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<global::MudBlazor.MudNavMenu>(2);
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(4);
                __builder2.AddAttribute(5, "Href", "/");
                __builder2.AddAttribute(6, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 6 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
                                NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 6 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                         Icons.Material.Outlined.Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 6 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(9, _localizer["Home"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 52 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
     if (_canViewUsers || _canViewRoles)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudListSubheader>(10);
                __builder2.AddAttribute(11, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(12, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 54 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(13, _localizer["Administrator"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 55 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewUsers)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(14);
                __builder2.AddAttribute(15, "Href", "/identity/users");
                __builder2.AddAttribute(16, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 57 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.Person

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 58 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(18, _localizer["Users"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 60 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewRoles)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(19);
                __builder2.AddAttribute(20, "Href", "/identity/roles");
                __builder2.AddAttribute(21, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 63 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.Person

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 63 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(23, _localizer["Roles"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 64 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
     if (_canViewMembers || _canViewTypes || _canViewTransactions || _canViewMoneyLines)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudListSubheader>(24);
                __builder2.AddAttribute(25, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(26, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 68 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(27, _localizer["Catalog Management"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 69 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewMembers)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(28);
                __builder2.AddAttribute(29, "Href", "/catalog/members");
                __builder2.AddAttribute(30, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 71 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                       Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 72 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(32, _localizer["Members"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 74 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewTypes)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(33);
                __builder2.AddAttribute(34, "Href", "/catalog/types");
                __builder2.AddAttribute(35, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 77 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                     Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 78 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(37, _localizer["Types"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 80 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewMoneyLines)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(38);
                __builder2.AddAttribute(39, "Href", "/catalog/moneylines");
                __builder2.AddAttribute(40, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 83 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                          Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 84 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(42, _localizer["Money Lines"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 86 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewTransactions)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(43);
                __builder2.AddAttribute(44, "Href", "/catalog/transactions");
                __builder2.AddAttribute(45, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 89 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                            Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 90 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(47, _localizer["Transactions"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 92 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
         
        
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
     if (_canViewReports)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudListSubheader>(48);
                __builder2.AddAttribute(49, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(50, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 97 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(51, _localizer["Report Management"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(53);
                __builder2.AddAttribute(54, "Href", "/catalog/reports/allmembers");
                __builder2.AddAttribute(55, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 98 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                              Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 99 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(57, _localizer["All Members"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(59);
                __builder2.AddAttribute(60, "Href", "/catalog/reports/singlemember");
                __builder2.AddAttribute(61, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 101 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                                Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 102 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(63, _localizer["Single Member"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(65);
                __builder2.AddAttribute(66, "Href", "/catalog/reports/thankmoney");
                __builder2.AddAttribute(67, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 104 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                              Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 105 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(69, _localizer["Thank Money"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 107 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "G:\TienPhong\main\FlexMoney\src\Client\Shared\NavMenu.razor"
           
    private ClaimsPrincipal _authenticationStateProviderUser;

    private bool _canViewHangfire;
    private bool _canViewDashboards;
    private bool _canViewDocuments;
    private bool _canViewDocumentTypes;
    private bool _canViewAuditTrails;
    private bool _canViewRoles;
    private bool _canViewUsers;
    private bool _canViewChat;
    private bool _canViewProducts;
    private bool _canViewBrands;
    private bool _canViewMembers;
    private bool _canViewTypes;
    private bool _canViewTransactions;
    private bool _canViewMoneyLines;
    private bool _canViewReports;

    protected override async Task OnParametersSetAsync()
    {
        _authenticationStateProviderUser = await _stateProvider.GetAuthenticationStateProviderUserAsync();
        _canViewHangfire = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Hangfire.View)).Succeeded;
        _canViewDashboards = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Dashboards.View)).Succeeded;
        _canViewDocuments = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Documents.View)).Succeeded;
        _canViewDocumentTypes = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.DocumentTypes.View)).Succeeded;
        _canViewAuditTrails = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.AuditTrails.View)).Succeeded;
        _canViewRoles = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Roles.View)).Succeeded;
        _canViewUsers = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Users.View)).Succeeded;
        _canViewChat = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Communication.Chat)).Succeeded;
        _canViewProducts = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Products.View)).Succeeded;
        _canViewBrands = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Brands.View)).Succeeded;
        _canViewMembers = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Members.View)).Succeeded;
        _canViewTypes = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Types.View)).Succeeded;
        _canViewTransactions = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.MoneyLines.View)).Succeeded;
        _canViewMoneyLines = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Transactions.View)).Succeeded;
        _canViewReports = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Reports.View)).Succeeded;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<NavMenu> _localizer { get; set; }
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
#pragma warning restore 1591
