#pragma checksum "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97c6e5384cf93a4be8ae4f24ef94657a0a1fb249"
// <auto-generated/>
#pragma warning disable 1591
namespace Bridgetree.Blazor.Server.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Bridgetree.Blazor.Server.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Bridgetree.Blazor.Server.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Bridgetree.Blazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee")]
    public partial class EditEmployee : EditEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                      Employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                               HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ObjectGraphDataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "h3");
                __builder2.AddContent(8, 
#nullable restore
#line 8 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
             PageHeaderText

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n        <hr>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group row");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.AddMarkupContent(15, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n                First Name\r\n            </label>\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-sm-10");
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "firstName");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "placeholder", "First Name");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                        Employee.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.FirstName = __value, Employee.FirstName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n                ");
                __Blazor.Bridgetree.Blazor.Server.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 18 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                          () => Employee.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group row");
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.AddMarkupContent(35, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n                Last Name\r\n            </label>\r\n            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-sm-10");
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "id", "lastName");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "placeholder", "Last Name");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                        Employee.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.LastName = __value, Employee.LastName))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                ");
                __Blazor.Bridgetree.Blazor.Server.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#nullable restore
#line 28 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                          () => Employee.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group row");
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.AddMarkupContent(55, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n                Email\r\n            </label>\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-sm-10");
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "id", "email");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "placeholder", "Email");
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                        Employee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Email = __value, Employee.Email))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n                ");
                __Blazor.Bridgetree.Blazor.Server.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_2(__builder2, 67, 68, 
#nullable restore
#line 38 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                          () => Employee.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(69, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group row");
                __builder2.AddMarkupContent(74, "\r\n            ");
                __builder2.AddMarkupContent(75, "<label for=\"department\" class=\"col-sm-2 col-form-label\">\r\n                Department\r\n            </label>\r\n            ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col-sm-10");
                __builder2.AddMarkupContent(78, "\r\n                ");
                __Blazor.Bridgetree.Blazor.Server.Web.Pages.EditEmployee.TypeInference.CreateInputSelect_3(__builder2, 79, 80, "department", 81, "form-control", 82, 
#nullable restore
#line 47 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                                          DepartmentId

#line default
#line hidden
#nullable disable
                , 83, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DepartmentId = __value, DepartmentId)), 84, () => DepartmentId, 85, (__builder3) => {
                    __builder3.AddMarkupContent(86, "\r\n");
#nullable restore
#line 48 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                     foreach (var dept in Departments)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(87, "                        ");
                    __builder3.OpenElement(88, "option");
                    __builder3.AddAttribute(89, "value", 
#nullable restore
#line 50 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                        dept.DepartmentId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(90, 
#nullable restore
#line 50 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                                            dept.DepartmentName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\r\n");
#nullable restore
#line 51 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(92, "                ");
                }
                );
                __builder2.AddMarkupContent(93, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n        ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "form-group row");
                __builder2.AddMarkupContent(98, "\r\n            ");
                __builder2.AddMarkupContent(99, "<label for=\"gender\" class=\"col-sm-2 col-form-label\">\r\n                Gender\r\n            </label>\r\n            ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "col-sm-10");
                __builder2.AddMarkupContent(102, "\r\n                ");
                __Blazor.Bridgetree.Blazor.Server.Web.Pages.EditEmployee.TypeInference.CreateInputSelect_4(__builder2, 103, 104, "form-control", 105, 
#nullable restore
#line 60 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                          Employee.Gender

#line default
#line hidden
#nullable disable
                , 106, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Gender = __value, Employee.Gender)), 107, () => Employee.Gender, 108, (__builder3) => {
                    __builder3.AddMarkupContent(109, "\r\n");
#nullable restore
#line 61 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                     foreach (var gender in Enum.GetValues(typeof(Gender)))
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(110, "                        ");
                    __builder3.OpenElement(111, "option");
                    __builder3.AddAttribute(112, "value", 
#nullable restore
#line 63 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                        gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(113, 
#nullable restore
#line 63 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                                 gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\r\n");
#nullable restore
#line 64 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(115, "                ");
                }
                );
                __builder2.AddMarkupContent(116, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n        ");
                __builder2.OpenElement(119, "div");
                __builder2.AddAttribute(120, "class", "form-group row");
                __builder2.AddMarkupContent(121, "\r\n            ");
                __builder2.AddMarkupContent(122, "<label for=\"dateOfBirth\" class=\"col-sm-2 col-form-label\">\r\n                Date Of Birth\r\n            </label>\r\n            ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "col-sm-10");
                __builder2.AddMarkupContent(125, "\r\n                ");
                __Blazor.Bridgetree.Blazor.Server.Web.Pages.EditEmployee.TypeInference.CreateInputDate_5(__builder2, 126, 127, "form-control", 128, 
#nullable restore
#line 73 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                        Employee.DateOfBrith

#line default
#line hidden
#nullable disable
                , 129, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.DateOfBrith = __value, Employee.DateOfBrith)), 130, () => Employee.DateOfBrith);
                __builder2.AddMarkupContent(131, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n\r\n        ");
                __builder2.AddMarkupContent(134, "<button class=\"btn btn-primary\" type=\"submit\">Submit</button>\r\n        ");
                __builder2.OpenElement(135, "button");
                __builder2.AddAttribute(136, "class", "btn btn-danger");
                __builder2.AddAttribute(137, "type", "button");
                __builder2.AddAttribute(138, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\jbehera.BRIDGETREE\Desktop\BlazorServerApp\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EditEmployee.razor"
                                                               Delete_Click

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(139, "\r\n            Delete\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Bridgetree.Blazor.Server.Web.Pages.EditEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
