#pragma checksum "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43d923ff3804b25cd8d318cab92cd737e93bd573"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_AddStudent), @"mvc.1.0.view", @"/Views/Student/AddStudent.cshtml")]
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
#line 1 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\_ViewImports.cshtml"
using StudentAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\_ViewImports.cshtml"
using StudentAssignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d923ff3804b25cd8d318cab92cd737e93bd573", @"/Views/Student/AddStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46bbc377d4c27e483a4eef7ea61260bd34a8f47d", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_AddStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentAssignment.Models.StudentModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43d923ff3804b25cd8d318cab92cd737e93bd5733329", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Create</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43d923ff3804b25cd8d318cab92cd737e93bd5734393", async() => {
                WriteLiteral("\r\n\r\n    <h4>Student</h4>\r\n    <hr />\r\n");
#nullable restore
#line 15 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
     using (Html.BeginForm("AddStudent", "Student"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"form-horizontal\">\r\n");
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 22 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
   Write(Html.LabelFor(model => model.StudentId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
       Write(Html.EditorFor(model => model.StudentId, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
       Write(Html.ValidationMessageFor(model => model.StudentId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 30 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
   Write(Html.LabelFor(model => model.StudentName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
       Write(Html.EditorFor(model => model.StudentName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
       Write(Html.ValidationMessageFor(model => model.StudentName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 38 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
   Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 41 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 45 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
   Write(Html.LabelFor(model => model.Branch, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
       Write(Html.EditorFor(model => model.Branch, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 48 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
       Write(Html.ValidationMessageFor(model => model.Branch, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 55 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
   Write(Html.LabelFor(model => model.Address, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
       Write(Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 58 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
       Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <button type=\"submit\" class=\"btn btn-primary\" value=\"Add Student\">Add Student</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 70 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div>\r\n        ");
#nullable restore
#line 73 "C:\Users\Ajay Choudhary\source\repos\StudentAssignment\Views\Student\AddStudent.cshtml"
   Write(Html.ActionLink("Back to List", "GetAllStudents"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n       \r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentAssignment.Models.StudentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591