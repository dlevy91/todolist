#pragma checksum "C:\Users\student\Code_School\Projects\todolist\TaskTracker\Views\Tracker\_forms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fdbfbe0238bf9be72e35801f5385a48ab199ad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tracker__forms), @"mvc.1.0.view", @"/Views/Tracker/_forms.cshtml")]
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
#line 1 "C:\Users\student\Code_School\Projects\todolist\TaskTracker\Views\_ViewImports.cshtml"
using TaskTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Code_School\Projects\todolist\TaskTracker\Views\_ViewImports.cshtml"
using TaskTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fdbfbe0238bf9be72e35801f5385a48ab199ad5", @"/Views/Tracker/_forms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"776c01f155f852b36c38241ac12f902be7b46999", @"/Views/_ViewImports.cshtml")]
    public class Views_Tracker__forms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskTracker.Models.UserTask>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"form-group\">\r\n    ");
#nullable restore
#line 4 "C:\Users\student\Code_School\Projects\todolist\TaskTracker\Views\Tracker\_forms.cshtml"
Write(Html.LabelFor(t => t.taskName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 5 "C:\Users\student\Code_School\Projects\todolist\TaskTracker\Views\Tracker\_forms.cshtml"
Write(Html.TextBoxFor(t => t.taskName, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 6 "C:\Users\student\Code_School\Projects\todolist\TaskTracker\Views\Tracker\_forms.cshtml"
Write(Html.ValidationMessageFor(t => t.taskName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n    ");
#nullable restore
#line 10 "C:\Users\student\Code_School\Projects\todolist\TaskTracker\Views\Tracker\_forms.cshtml"
Write(Html.LabelFor(t => t.taskDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\student\Code_School\Projects\todolist\TaskTracker\Views\Tracker\_forms.cshtml"
Write(Html.TextBoxFor(t => t.taskDescription, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\student\Code_School\Projects\todolist\TaskTracker\Views\Tracker\_forms.cshtml"
Write(Html.ValidationMessageFor(t => t.taskDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskTracker.Models.UserTask> Html { get; private set; }
    }
}
#pragma warning restore 1591
