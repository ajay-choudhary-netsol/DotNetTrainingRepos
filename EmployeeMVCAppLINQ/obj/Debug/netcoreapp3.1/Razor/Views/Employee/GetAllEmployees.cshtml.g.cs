#pragma checksum "C:\Users\Ajay Choudhary\source\repos\EmployeeMVCAppLINQ\Views\Employee\GetAllEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bcc5d71b8f10eba9ff30fcc7e5e70bab0bf3d1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetAllEmployees), @"mvc.1.0.view", @"/Views/Employee/GetAllEmployees.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Ajay Choudhary\source\repos\EmployeeMVCAppLINQ\Views\_ViewImports.cshtml"
using EmployeeMVCAppLINQ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ajay Choudhary\source\repos\EmployeeMVCAppLINQ\Views\Employee\GetAllEmployees.cshtml"
using EmployeeMVCAppLINQ.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bcc5d71b8f10eba9ff30fcc7e5e70bab0bf3d1d", @"/Views/Employee/GetAllEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24b8e5351fc0af5a08dc8fb1be5df08f101e8e0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_GetAllEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ajay Choudhary\source\repos\EmployeeMVCAppLINQ\Views\Employee\GetAllEmployees.cshtml"
  
    ViewData["Title"] = "Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Employee Details</h2>
<hr />
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Employee ID</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Branch</th>
            <th scope=""col"">Address</th>
            <
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\Ajay Choudhary\source\repos\EmployeeMVCAppLINQ\Views\Employee\GetAllEmployees.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>");
#nullable restore
#line 24 "C:\Users\Ajay Choudhary\source\repos\EmployeeMVCAppLINQ\Views\Employee\GetAllEmployees.cshtml"
               Write(Html.ActionLink(item.EmployeeId.ToString(),"EmployeeDetails","Employee",new { id = @item.EmployeeId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Ajay Choudhary\source\repos\EmployeeMVCAppLINQ\Views\Employee\GetAllEmployees.cshtml"
               Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Ajay Choudhary\source\repos\EmployeeMVCAppLINQ\Views\Employee\GetAllEmployees.cshtml"
               Write(item.Emailid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Ajay Choudhary\source\repos\EmployeeMVCAppLINQ\Views\Employee\GetAllEmployees.cshtml"
               Write(item.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Ajay Choudhary\source\repos\EmployeeMVCAppLINQ\Views\Employee\GetAllEmployees.cshtml"
               Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Ajay Choudhary\source\repos\EmployeeMVCAppLINQ\Views\Employee\GetAllEmployees.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
