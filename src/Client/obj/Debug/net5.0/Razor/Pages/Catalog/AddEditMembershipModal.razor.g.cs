#pragma checksum "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3842405e6dec9b2e5cee59f6523b4e99cc0ce30"
// <auto-generated/>
#pragma warning disable 1591
namespace FlexMoney.Client.Pages.Catalog
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
    public partial class AddEditMembershipModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                  AddEditMembershipModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                         SaveAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(4);
                __builder2.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 4 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                     _fluentValidationValidator = (Blazored.FluentValidation.FluentValidationValidator)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDialog>(7);
                __builder2.AddAttribute(8, "TitleContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 7 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
              
                if (AddEditMembershipModel.Id == 0)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudText>(9);
                    __builder3.AddAttribute(10, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 10 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                   Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIcon>(12);
                        __builder4.AddAttribute(13, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                        Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(14, "Class", "mr-3 mb-n1");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(15, "\r\n                        ");
                        __builder4.AddContent(16, 
#nullable restore
#line 12 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                         _localizer["Add Membership"]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 14 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudText>(17);
                    __builder3.AddAttribute(18, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 17 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                   Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIcon>(20);
                        __builder4.AddAttribute(21, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                        Icons.Material.Filled.Update

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(22, "Class", "mr-3 mb-n1");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\r\n                        ");
                        __builder4.AddContent(24, 
#nullable restore
#line 19 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                         _localizer["Update Membership"]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 21 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                }
            

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.AddAttribute(25, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(26);
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 26 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                 if (AddEditMembershipModel.Id != 0)
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudItem>(28);
                        __builder4.AddAttribute(29, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                 12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                         6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.FlexMoney.Client.Pages.Catalog.AddEditMembershipModal.TypeInference.CreateMudTextField_0(__builder5, 32, 33, true, 34, 
#nullable restore
#line 29 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                      () => AddEditMembershipModel.Id

#line default
#line hidden
#nullable disable
                            , 35, 
#nullable restore
#line 29 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                                                        _localizer["Id"]

#line default
#line hidden
#nullable disable
                            , 36, 
#nullable restore
#line 29 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                     AddEditMembershipModel.Id

#line default
#line hidden
#nullable disable
                            , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddEditMembershipModel.Id = __value, AddEditMembershipModel.Id)));
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 31 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudItem>(38);
                        __builder4.AddAttribute(39, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                     6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTextField<string>>(42);
                            __builder5.AddAttribute(43, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 33 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                    () => AddEditMembershipModel.Name

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(44, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                                                          _localizer["Name"]

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 33 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                     AddEditMembershipModel.Name

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddEditMembershipModel.Name = __value, AddEditMembershipModel.Name))));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(47, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(48);
                        __builder4.AddAttribute(49, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 35 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(50, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 35 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                     6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.FlexMoney.Client.Pages.Catalog.AddEditMembershipModal.TypeInference.CreateMudTextField_1(__builder5, 52, 53, 
#nullable restore
#line 36 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                         () => AddEditMembershipModel.AccountNumber

#line default
#line hidden
#nullable disable
                            , 54, 
#nullable restore
#line 36 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                                                                 _localizer["AccountNumber"]

#line default
#line hidden
#nullable disable
                            , 55, 
#nullable restore
#line 36 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                   AddEditMembershipModel.AccountNumber

#line default
#line hidden
#nullable disable
                            , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddEditMembershipModel.AccountNumber = __value, AddEditMembershipModel.AccountNumber)));
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(57, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(58);
                        __builder4.AddAttribute(59, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(60, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                     6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.FlexMoney.Client.Pages.Catalog.AddEditMembershipModal.TypeInference.CreateMudTextField_2(__builder5, 62, 63, 
#nullable restore
#line 39 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                         () => AddEditMembershipModel.Note

#line default
#line hidden
#nullable disable
                            , 64, 
#nullable restore
#line 39 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                                               _localizer["Note"]

#line default
#line hidden
#nullable disable
                            , 65, 
#nullable restore
#line 39 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                          AddEditMembershipModel.Note

#line default
#line hidden
#nullable disable
                            , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddEditMembershipModel.Note = __value, AddEditMembershipModel.Note)));
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(67, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(68);
                    __builder3.AddAttribute(69, "DisableElevation", true);
                    __builder3.AddAttribute(70, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 44 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                 Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                          Cancel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(73, 
#nullable restore
#line 44 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                   _localizer["Cancel"]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 45 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
             if (AddEditMembershipModel.Id != 0)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudButton>(74);
                    __builder3.AddAttribute(75, "DisableElevation", true);
                    __builder3.AddAttribute(76, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 47 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                     Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(77, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 47 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                 ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(78, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                                !Validated

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 47 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                                                    Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(81, 
#nullable restore
#line 47 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                                                                      _localizer["Update"]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 48 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudButton>(82);
                    __builder3.AddAttribute(83, "DisableElevation", true);
                    __builder3.AddAttribute(84, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 51 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                     Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 51 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                 ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                                !Validated

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(87, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 51 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                                                    Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(89, 
#nullable restore
#line 51 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
                                                                                                                                                    _localizer["Save"]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 52 "E:\TienPhong\FlexMoney\FlexMoney\src\Client\Pages\Catalog\AddEditMembershipModal.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<AddEditMembershipModal> _localizer { get; set; }
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
namespace __Blazor.FlexMoney.Client.Pages.Catalog.AddEditMembershipModal
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, global::System.String __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Disabled", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Label", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
