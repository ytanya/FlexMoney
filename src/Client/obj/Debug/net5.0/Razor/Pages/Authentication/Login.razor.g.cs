#pragma checksum "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1af0ecd4481b437935780de647f54297883f7d"
// <auto-generated/>
#pragma warning disable 1591
namespace FlexMoney.Client.Pages.Authentication
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
#line 49 "D:\FlexMoneyTanya\FlexMoney\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
           [AllowAnonymous]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                  _tokenModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                              SubmitAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(4);
                __builder2.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 7 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                     _fluentValidationValidator = (Blazored.FluentValidation.FluentValidationValidator)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(7);
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(9);
                    __builder3.AddAttribute(10, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(12, "div");
                        __builder4.AddAttribute(13, "class", "d-flex justify-center");
                        __builder4.OpenComponent<MudBlazor.MudIcon>(14);
                        __builder4.AddAttribute(15, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                CustomIcons.BlazorHero

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                               Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 11 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
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
                    __builder3.AddMarkupContent(20, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(21);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(23);
                    __builder3.AddAttribute(24, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(26, "div");
                        __builder4.AddAttribute(27, "class", "d-flex justify-center");
                        __builder4.OpenComponent<MudBlazor.MudText>(28);
                        __builder4.AddAttribute(29, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 17 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                               Typo.h4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 17 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
__builder5.AddContent(31, _localizer["Title"]);

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
                    __builder3.AddMarkupContent(32, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(33);
                    __builder3.AddAttribute(34, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(36, "div");
                        __builder4.AddAttribute(37, "class", "d-flex justify-center");
                        __builder4.OpenComponent<MudBlazor.MudText>(38);
                        __builder4.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 22 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
__builder5.AddContent(40, _localizer["Description"]);

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
                    __builder3.AddMarkupContent(41, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(42);
                    __builder3.AddAttribute(43, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(45, "div");
                        __builder4.AddAttribute(46, "class", "d-flex justify-center");
                        __builder4.OpenComponent<MudBlazor.MudText>(47);
                        __builder4.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 27 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
__builder5.AddContent(49, _localizer["Don't have an account?"]);

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(50, " ");
                            __builder5.OpenComponent<MudBlazor.MudLink>(51);
                            __builder5.AddAttribute(52, "Href", "/register");
                            __builder5.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
#nullable restore
#line 27 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
__builder6.AddContent(54, _localizer["Register here"]);

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(56);
                    __builder3.AddAttribute(57, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 30 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(59);
                        __builder4.AddAttribute(60, "Label", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                             _localizer["E-mail"]

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(61, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 31 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                                            Variant.Outlined

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(62, "For", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 32 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                                 () => _tokenModel.Email

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(63, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 32 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                       _tokenModel.Email

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(64, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _tokenModel.Email = __value, _tokenModel.Email))));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(66);
                    __builder3.AddAttribute(67, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.FlexMoney.Client.Pages.Authentication.Login.TypeInference.CreateMudTextField_0(__builder4, 69, 70, 
#nullable restore
#line 35 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                  _localizer["Password"]

#line default
#line hidden
#nullable disable
                        , 71, 
#nullable restore
#line 35 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 72, 
#nullable restore
#line 36 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                                    () => _tokenModel.Password

#line default
#line hidden
#nullable disable
                        , 73, 
#nullable restore
#line 37 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                      _passwordInput

#line default
#line hidden
#nullable disable
                        , 74, 
#nullable restore
#line 37 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                                 Adornment.End

#line default
#line hidden
#nullable disable
                        , 75, 
#nullable restore
#line 37 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                                                                _passwordInputIcon

#line default
#line hidden
#nullable disable
                        , 76, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                                                                                                      TogglePasswordVisibility

#line default
#line hidden
#nullable disable
                        ), 77, 
#nullable restore
#line 36 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                       _tokenModel.Password

#line default
#line hidden
#nullable disable
                        , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _tokenModel.Password = __value, _tokenModel.Password)));
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(80);
                    __builder3.AddAttribute(81, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(82, "Class", "d-flex justify-space-between align-center");
                    __builder3.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCheckBox<bool>>(84);
                        __builder4.AddAttribute(85, "Label", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                          _localizer["Remember me?"]

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(86, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 40 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                                             Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(87, "Class", "ml-n1");
                        __builder4.CloseComponent();
                        __builder4.AddContent(88, " ");
                        __builder4.OpenComponent<MudBlazor.MudLink>(89);
                        __builder4.AddAttribute(90, "Href", "/account/forgot-password");
                        __builder4.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 40 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
__builder5.AddContent(92, _localizer["Forgot password?"]);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(94);
                    __builder3.AddAttribute(95, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "Class", "d-flex justify-center");
                    __builder3.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudButton>(98);
                        __builder4.AddAttribute(99, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 43 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                   ButtonType.Submit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(100, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 43 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                               Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(101, "Disabled", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                                                           !Validated

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(102, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 43 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                                                                               Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(103, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 43 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                                                                                                                    Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(104, "Style", "width: 100%;");
                        __builder4.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 43 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
__builder5.AddContent(106, _localizer["Sign In"]);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(108);
                    __builder3.AddAttribute(109, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 45 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(110, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudButton>(111);
                        __builder4.AddAttribute(112, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                FillAdministratorCredentials

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 46 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
__builder5.AddContent(114, _localizer["Fill Administrator Credentials"]);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(116);
                    __builder3.AddAttribute(117, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 48 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudButton>(119);
                        __builder4.AddAttribute(120, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
                                FillBasicUserCredentials

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 49 "D:\FlexMoneyTanya\FlexMoney\src\Client\Pages\Authentication\Login.razor"
__builder5.AddContent(122, _localizer["Fill Basic User Credentials"]);

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<Login> _localizer { get; set; }
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
namespace __Blazor.FlexMoney.Client.Pages.Authentication.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, global::MudBlazor.InputType __arg3, int __seq4, global::MudBlazor.Adornment __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs> __arg6, int __seq7, T __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg8)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "InputType", __arg3);
        __builder.AddAttribute(__seq4, "Adornment", __arg4);
        __builder.AddAttribute(__seq5, "AdornmentIcon", __arg5);
        __builder.AddAttribute(__seq6, "OnAdornmentClick", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
