#pragma checksum "C:\Users\Ajay Choudhary\source\repos\FirstCoreMVCWebApplication\Views\Student\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ff2e032146fbb2f2ce9b3acf3a6abfd3827c01b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentList), @"mvc.1.0.view", @"/Views/Student/StudentList.cshtml")]
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
#line 1 "C:\Users\Ajay Choudhary\source\repos\FirstCoreMVCWebApplication\Views\_ViewImports.cshtml"
using FirstCoreMVCWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ajay Choudhary\source\repos\FirstCoreMVCWebApplication\Views\_ViewImports.cshtml"
using FirstCoreMVCWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff2e032146fbb2f2ce9b3acf3a6abfd3827c01b", @"/Views/Student/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c36a3ccb4712d301da74a3200d311ee6ae93bd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestStudentRepository>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Ajay Choudhary\source\repos\FirstCoreMVCWebApplication\Views\Student\StudentList.cshtml"
Write(Html.Partial("_Student", Model.Students));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestStudentRepository> Html { get; private set; }
    }
}
#pragma warning restore 1591