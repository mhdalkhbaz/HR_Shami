#pragma checksum "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90ff7d1983f8f9ac00231b5e77d37ca41ce3efc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_vi_emp_this_month_Details), @"mvc.1.0.view", @"/Views/vi_emp_this_month/Details.cshtml")]
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
#line 1 "D:\hr_E\HRApp\HRApp\Views\_ViewImports.cshtml"
using HRApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\hr_E\HRApp\HRApp\Views\_ViewImports.cshtml"
using HRApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ff7d1983f8f9ac00231b5e77d37ca41ce3efc0", @"/Views/vi_emp_this_month/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e169a2b07067aed65c85fcd123d6314d283b878c", @"/Views/_ViewImports.cshtml")]
    public class Views_vi_emp_this_month_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRApp.Models.vi_emp_this_month>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>vi_emp_this_month</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.depName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.depName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DayDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.DayDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.InHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OutHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.OutHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EarlyOverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.EarlyOverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LateHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.LateHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LateType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.LateType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EarlyOut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.EarlyOut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EarlyOutType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.EarlyOutType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OverTime1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "D:\hr_E\HRApp\HRApp\Views\vi_emp_this_month\Details.cshtml"
       Write(Html.DisplayFor(model => model.OverTime1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRApp.Models.vi_emp_this_month> Html { get; private set; }
    }
}
#pragma warning restore 1591
