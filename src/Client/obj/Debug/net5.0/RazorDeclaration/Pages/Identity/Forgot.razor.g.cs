// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FlexMoney.Client.Pages.Identity
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.RoleClaims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Preferences;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Catalog.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Catalog.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Communication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Audit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Misc.Document;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Misc.DocumentType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Shared.Constants.Permission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Shared.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Application.Requests.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Identity\Forgot.razor"
           [AllowAnonymous]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/forgot-password")]
    public partial class Forgot : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<Forgot> _localizer { get; set; }
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
