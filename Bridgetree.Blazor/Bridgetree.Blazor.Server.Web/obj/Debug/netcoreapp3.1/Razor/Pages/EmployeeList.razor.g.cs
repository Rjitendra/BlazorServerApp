#pragma checksum "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e41cd16d6356140eaa6167bba40d3c9eaa3ffd6"
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
#line 1 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Bridgetree.Blazor.Server.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Bridgetree.Blazor.Server.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\_Imports.razor"
using Bridgetree.Blazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeesListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee List</h3>\r\n");
            __builder.OpenElement(1, "h5");
            __builder.AddContent(2, "Selected Employees Count - ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EmployeeList.razor"
                                SelectedEmployeesCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<Bridgetree.Blazor.Server.Web.Pages.DisplayEmployee>(5);
            __builder.AddAttribute(6, "Employees", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Bridgetree.Blazor.Models.Employee>>(
#nullable restore
#line 8 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EmployeeList.razor"
                            Employees

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnEmployeeSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 8 "C:\Workspace\Jitendra Personal\My Project\Bridgetree.Training\Bridgetree.Blazor\Bridgetree.Blazor.Server.Web\Pages\EmployeeList.razor"
                                                            EmployeeSelectionChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591