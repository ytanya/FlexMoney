// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "D:\FlexMoneyTanya\FlexMoney\src\Client\Shared\NavMenu.razor"
       
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

    private bool _canViewMembers;
    private bool _canViewTypes;
    private bool _canViewTransactions;


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
        _canViewMemberships = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Members.View)).Succeeded;
        _canViewFlexMoneyTypes = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Types.View)).Succeeded;
        _canViewMembers = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Members.View)).Succeeded;
        _canViewTypes = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Types.View)).Succeeded;
        _canViewTransactions = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Transactions.View)).Succeeded;

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
