#pragma checksum "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65e515808cc0891eeff41d510c97bc08e67257f2"
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
#line 2 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.RoleClaims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Identity.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Preferences;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Catalog.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Catalog.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Communication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Audit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Misc.Document;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Managers.Misc.DocumentType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Shared.Constants.Permission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Shared.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Application.Requests.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Infrastructure.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
using FlexMoney.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\FlexMoneyCSJ\FlexMoney\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class NotFoundLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 4 "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor"
                         BlazorHeroTheme.DefaultTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<MudBlazor.MudContainer>(5);
            __builder.AddAttribute(6, "MaxWidth", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 6 "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor"
                        MaxWidth.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "d-flex flex-column");
                __builder2.AddMarkupContent(10, "<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 569 384.7\" width=\"550\" height=\"371.84\" style=\"margin-top:25%;\"><path d=\"M600.18,328.75v60.74L705.4,450.24V389.5Z\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#0069c0\"></path>\r\n            <path d=\"M600.18,450.24V511L705.4,450.24V389.5Z\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#1E88E5\"></path>\r\n            <path d=\"M495.15,389.5v60.74l105-60.75V328.75Z\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#1E88E5\"></path>\r\n            <path d=\"M495.15,389.49v60.75l105,60.74V450.24Z\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#0069c0\"></path>\r\n            <path d=\"M419.18,327.71l52.06,30.05L500,341.17l-52.06-30.05Z\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#1E88E5\"></path>\r\n            <path d=\"M471.24,276.38V436.64l-52.07-30.06V126.28l52.06,30.06\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#0069c0\"></path>\r\n            <path d=\"M315.12,387.83l52.06,30.05,104.06-60.12L419.17,327.7Z\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#1E88E5\"></path>\r\n            <path d=\"M415.43,188.31l-52.06-30.05L315.12,387.82l52.06,30.06Z\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#0069c0\"></path>\r\n            <path d=\"M363.37,158.26l52.06,30.05,55.8-32-52.06-30Z\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#1E88E5\"></path>\r\n            <path d=\"M751.3,311.12l-52.06,30.05L728,357.76l52.06-30.05Z\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#0069c0\"></path>\r\n            <path d=\"M728,156.34l52.06-30V406.58L728,436.64V276.39\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#1E88E5\"></path>\r\n            <path d=\"M780.06,327.7,728,357.76l104.06,60.12,52.06-30.05Z\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#0069c0\"></path>\r\n            <path d=\"M832.06,417.88l52.06-30.06L835.87,158.26l-52.06,30.05Z\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#1E88E5\"></path>\r\n            <path d=\"M780.07,126.29,728,156.34l55.8,32,52.06-30.05Z\" transform=\"translate(-315.12 -126.28)\" style=\"fill:#0069c0\"></path></svg>\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudText>(11);
                __builder2.AddAttribute(12, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 24 "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor"
                       Typo.h5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Class", "mt-6");
                __builder2.AddAttribute(14, "Align", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 24 "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor"
                                                    Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 24 "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor"
__builder3.AddContent(16, _localizer["Message"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudItem>(18);
                __builder2.AddAttribute(19, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor"
                     12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor"
                             12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "md", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor"
                                     12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(23, "div");
                    __builder3.AddAttribute(24, "class", "pa-4 justify-center my-4 mud-text-align-center");
                    __builder3.OpenComponent<MudBlazor.MudButton>(25);
                    __builder3.AddAttribute(26, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 27 "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor"
                                    Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 27 "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor"
                                                           Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 27 "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor"
                                                                                Size.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Link", "/");
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 27 "D:\FlexMoneyCSJ\FlexMoney\src\Client\Shared\NotFoundLayout.razor"
__builder4.AddContent(31, _localizer["GoHome"]);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<NotFoundLayout> _localizer { get; set; }
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