#pragma checksum "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "288aebd7d57e5d2a5ceee0197c0463f6d4701b2c"
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
#line 2 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.RoleClaims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Preferences;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Catalog.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Catalog.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Communication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Audit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Misc.Document;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Misc.DocumentType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Shared.Constants.Permission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Shared.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Application.Requests.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<FlexMoney.Client.Shared.Components.UserCard>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MudBlazor.MudNavMenu>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavLink>(4);
                __builder2.AddAttribute(5, "Href", "/");
                __builder2.AddAttribute(6, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 6 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                         Icons.Material.Outlined.Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 6 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(9, _localizer["Home"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudListSubheader>(11);
                __builder2.AddAttribute(12, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 19 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(14, _localizer["Personal"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 20 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
     if (_canViewDashboards)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(15);
                __builder2.AddAttribute(16, "Href", "/dashboard");
                __builder2.AddAttribute(17, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                             Icons.Material.Outlined.Dashboard

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 23 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(19, _localizer["Dashboard"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 25 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(20);
                __builder2.AddAttribute(21, "Href", "/account");
                __builder2.AddAttribute(22, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                       Icons.Material.Outlined.SupervisorAccount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 27 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(24, _localizer["Account"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 29 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
     if (_canViewAuditTrails)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(25);
                __builder2.AddAttribute(26, "Href", "/audit-trails");
                __builder2.AddAttribute(27, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                Icons.Material.Outlined.Security

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 32 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(29, _localizer["Audit Trails"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 34 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
     if (_canViewDocuments || _canViewDocumentTypes)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudListSubheader>(30);
                __builder2.AddAttribute(31, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 37 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(33, _localizer["Document Management"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 38 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewDocuments)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(34);
                __builder2.AddAttribute(35, "Href", "/document-store");
                __builder2.AddAttribute(36, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.AttachFile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 41 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(38, _localizer["Document Store"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 43 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewDocumentTypes)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(39);
                __builder2.AddAttribute(40, "Href", "/document-types");
                __builder2.AddAttribute(41, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.FileCopy

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 47 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(43, _localizer["Document Types"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 49 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
     if (_canViewUsers || _canViewRoles)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudListSubheader>(44);
                __builder2.AddAttribute(45, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 54 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(47, _localizer["Administrator"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 55 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewUsers)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(48);
                __builder2.AddAttribute(49, "Href", "/identity/users");
                __builder2.AddAttribute(50, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.Person

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 58 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(52, _localizer["Users"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 60 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewRoles)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(53);
                __builder2.AddAttribute(54, "Href", "/identity/roles");
                __builder2.AddAttribute(55, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.Person

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 63 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(57, _localizer["Roles"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 64 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
     if (_canViewChat)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudListSubheader>(58);
                __builder2.AddAttribute(59, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 68 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(61, _localizer["Communication"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(63);
                __builder2.AddAttribute(64, "Href", "/chat");
                __builder2.AddAttribute(65, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                        Icons.Material.Outlined.Chat

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 70 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(67, _localizer["Chat"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 72 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
     if (_canViewProducts || _canViewBrands || _canViewMemberships)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudListSubheader>(68);
                __builder2.AddAttribute(69, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 75 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(71, _localizer["Catalog Management"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 76 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewProducts)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(72);
                __builder2.AddAttribute(73, "Href", "/catalog/products");
                __builder2.AddAttribute(74, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 78 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                        Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 79 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(76, _localizer["Products"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 81 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewBrands)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(77);
                __builder2.AddAttribute(78, "Href", "/catalog/brands");
                __builder2.AddAttribute(79, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 84 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 85 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(81, _localizer["Brands"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 87 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewMemberships)
        {   

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(82);
                __builder2.AddAttribute(83, "Href", "/catalog/memberships");
                __builder2.AddAttribute(84, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 90 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                           Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 91 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(86, _localizer["Memberships"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 93 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewFlexMoneyTypes)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(87);
                __builder2.AddAttribute(88, "Href", "/catalog/flexmoneytypes");
                __builder2.AddAttribute(89, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 96 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                              Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 97 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(91, _localizer["Money Types"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 99 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
         if (_canViewFlexMoneyTypes)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(92);
                __builder2.AddAttribute(93, "Href", "/catalog/flexmoneyline");
                __builder2.AddAttribute(94, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 102 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
                                                             Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 103 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(96, _localizer["Money Lines"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 105 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
         
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
#line 109 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
       
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
    private bool _canViewMemberships;
    private bool _canViewFlexMoneyTypes;

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
        _canViewMemberships = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Memberships.View)).Succeeded;
        _canViewFlexMoneyTypes = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.FlexMoneyTypes.View)).Succeeded;
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
