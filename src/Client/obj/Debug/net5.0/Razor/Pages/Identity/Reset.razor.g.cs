#pragma checksum "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ccd5ad87dc9a1410bbafdcf9d14e8bb5b15f2c3"
// <auto-generated/>
#pragma warning disable 1591
namespace FlexMoney.Client.Pages.Identity
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
#line 49 "G:\TienPhong\main\FlexMoney\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
           [AllowAnonymous]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/account/reset-password/")]
    public partial class Reset : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 6 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                  _resetPasswordModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                      SubmitAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Blazored.FluentValidation.FluentValidationValidator>(4);
                __builder2.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 7 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                     _fluentValidationValidator = (Blazored.FluentValidation.FluentValidationValidator)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenComponent<global::MudBlazor.MudGrid>(7);
                __builder2.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudItem>(9);
                    __builder3.AddAttribute(10, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 9 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(12, "div");
                        __builder4.AddAttribute(13, "class", "d-flex justify-center");
                        __builder4.OpenComponent<global::MudBlazor.MudIcon>(14);
                        __builder4.AddAttribute(15, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 11 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                CustomIcons.BlazorHero

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 11 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                               Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 11 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                    Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(18, "ViewBox", "0 0 500 500");
                        __builder4.AddAttribute(19, "Style", "width: 100px; height: 100px;");
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudItem>(21);
                    __builder3.AddAttribute(22, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 14 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(24, "div");
                        __builder4.AddAttribute(25, "class", "d-flex justify-center");
                        __builder4.OpenComponent<global::MudBlazor.MudText>(26);
                        __builder4.AddAttribute(27, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 16 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                               Typo.h4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 16 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
__builder5.AddContent(29, _localizer["Reset password"]);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudItem>(31);
                    __builder3.AddAttribute(32, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 19 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(34, "div");
                        __builder4.AddAttribute(35, "class", "d-flex justify-center");
                        __builder4.OpenComponent<global::MudBlazor.MudText>(36);
                        __builder4.AddAttribute(37, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 21 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                               Typo.subtitle2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "Class", "mb-n4");
                        __builder4.AddAttribute(39, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 21 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
__builder5.AddContent(40, _localizer["Enter email for password reset"]);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudItem>(42);
                    __builder3.AddAttribute(43, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 24 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudTextField<string>>(45);
                        __builder4.AddAttribute(46, "Label", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 25 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                             _localizer["E-mail"]

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(47, "For", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<global::System.Func<string>>>(
#nullable restore
#line 25 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                  () => _resetPasswordModel.Email

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(48, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 25 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                                                             Variant.Outlined

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(49, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 25 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                _resetPasswordModel.Email

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(50, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<string>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _resetPasswordModel.Email = __value, _resetPasswordModel.Email))));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudItem>(52);
                    __builder3.AddAttribute(53, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 27 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudTextField<string>>(55);
                        __builder4.AddAttribute(56, "Label", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 28 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                             _localizer["Password"]

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(57, "For", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<global::System.Func<string>>>(
#nullable restore
#line 28 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                       () => _resetPasswordModel.Password

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(58, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 28 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                                                                     Variant.Outlined

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(59, "InputType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.InputType>(
#nullable restore
#line 28 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                                                                                                   _passwordInput

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(60, "Adornment", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Adornment>(
#nullable restore
#line 28 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                                                                                                                              Adornment.End

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(61, "AdornmentIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 28 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                                                                                                                                                             _passwordInputIcon

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(62, "OnAdornmentClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                                                                                                                                                                                                   TogglePasswordVisibility

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(63, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 28 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                  _resetPasswordModel.Password

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(64, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<string>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _resetPasswordModel.Password = __value, _resetPasswordModel.Password))));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudItem>(66);
                    __builder3.AddAttribute(67, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 30 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudTextField<string>>(69);
                        __builder4.AddAttribute(70, "Label", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 31 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                             _localizer["Confirm Password"]

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(71, "For", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<global::System.Func<string>>>(
#nullable restore
#line 31 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                                      () => _resetPasswordModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(72, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 31 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                                                                                           Variant.Outlined

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(73, "InputType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.InputType>(
#nullable restore
#line 31 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                                                                                                                        InputType.Password

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(74, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 31 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                          _resetPasswordModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(75, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<string>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _resetPasswordModel.ConfirmPassword = __value, _resetPasswordModel.ConfirmPassword))));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudItem>(77);
                    __builder3.AddAttribute(78, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 33 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "Class", "d-flex justify-center");
                    __builder3.AddAttribute(80, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudButton>(81);
                        __builder4.AddAttribute(82, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 34 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(83, "Disabled", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 34 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                            !Validated

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(84, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 34 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(85, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.ButtonType>(
#nullable restore
#line 34 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                           ButtonType.Submit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(86, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 34 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                                    Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(87, "FullWidth", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 34 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
                                                                                                                                                           true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(88, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 34 "G:\TienPhong\main\FlexMoney\src\Client\Pages\Identity\Reset.razor"
__builder5.AddContent(89, _localizer["Reset Password"]);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<Reset> _localizer { get; set; }
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
