#pragma checksum "C:\Users\HP\source\repos\LoginTestWeb\LoginTestWeb\Views\Employee\Filter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3de90d2302237dc115127a987549b830f683402"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Filter), @"mvc.1.0.view", @"/Views/Employee/Filter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Filter.cshtml", typeof(AspNetCore.Views_Employee_Filter))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\HP\source\repos\LoginTestWeb\LoginTestWeb\Views\_ViewImports.cshtml"
using LoginTestWeb;

#line default
#line hidden
#line 2 "C:\Users\HP\source\repos\LoginTestWeb\LoginTestWeb\Views\_ViewImports.cshtml"
using LoginTestWeb.Models;

#line default
#line hidden
#line 3 "C:\Users\HP\source\repos\LoginTestWeb\LoginTestWeb\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3de90d2302237dc115127a987549b830f683402", @"/Views/Employee/Filter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"995c00e45f3b0dc5899e7a2e803174acb6f6f6d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Filter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LoginTestWeb.Models.Employees>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 317, true);
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th>
                <h4>Name</h4>
            </th>
            <th>
                Salary
            </th>
            <th>
                Photopath
            </th>
            
            
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\HP\source\repos\LoginTestWeb\LoginTestWeb\Views\Employee\Filter.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(400, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(449, 42, false);
#line 24 "C:\Users\HP\source\repos\LoginTestWeb\LoginTestWeb\Views\Employee\Filter.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmpName));

#line default
#line hidden
            EndContext();
            BeginContext(491, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(547, 44, false);
#line 27 "C:\Users\HP\source\repos\LoginTestWeb\LoginTestWeb\Views\Employee\Filter.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmpSalary));

#line default
#line hidden
            EndContext();
            BeginContext(591, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(647, 44, false);
#line 30 "C:\Users\HP\source\repos\LoginTestWeb\LoginTestWeb\Views\Employee\Filter.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhotoPath));

#line default
#line hidden
            EndContext();
            BeginContext(691, 60, true);
            WriteLiteral("\r\n            </td>          \r\n            \r\n        </tr>\r\n");
            EndContext();
#line 34 "C:\Users\HP\source\repos\LoginTestWeb\LoginTestWeb\Views\Employee\Filter.cshtml"
}

#line default
#line hidden
            BeginContext(754, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LoginTestWeb.Models.Employees>> Html { get; private set; }
    }
}
#pragma warning restore 1591
