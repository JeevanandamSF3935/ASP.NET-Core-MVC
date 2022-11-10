#pragma checksum "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\Home\ViewDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "796b14d71b3a9574928c05d0455107a7a306f0d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewDetails), @"mvc.1.0.view", @"/Views/Home/ViewDetails.cshtml")]
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
#line 1 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\_ViewImports.cshtml"
using Employees.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\_ViewImports.cshtml"
using Employees.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\_ViewImports.cshtml"
using Employees;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"796b14d71b3a9574928c05d0455107a7a306f0d0", @"/Views/Home/ViewDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0893437fd9d0e229026fec3a0857043c91b83c92", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("118px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\Home\ViewDetails.cshtml"
  
    ViewBag.Title = "Employees List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>\r\n    All Employees\r\n</h1>\r\n");
#nullable restore
#line 8 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\Home\ViewDetails.cshtml"
   
    var employees = Model.Select(x => x).OrderBy(x => x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-deck\">\r\n");
#nullable restore
#line 13 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\Home\ViewDetails.cshtml"
     foreach (var employee in employees)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card m-3 text-center\">\r\n            <h3>");
#nullable restore
#line 16 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\Home\ViewDetails.cshtml"
           Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div style=\"text-align:center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "796b14d71b3a9574928c05d0455107a7a306f0d05738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/uploadedImages/");
#nullable restore
#line 17 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\Home\ViewDetails.cshtml"
                                                                                      WriteLiteral(employee.ProfileImage);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\Home\ViewDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n            <div class=\"card-footer\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 550, "\"", 611, 1);
#nullable restore
#line 19 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\Home\ViewDetails.cshtml"
WriteAttributeValue("", 557, Url.Action("Details","Home",new { @id = employee.Id}), 557, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">View</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 665, "\"", 707, 1);
#nullable restore
#line 20 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\Home\ViewDetails.cshtml"
WriteAttributeValue("", 672, Url.Action("Edit","Home",employee), 672, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 761, "\"", 821, 1);
#nullable restore
#line 21 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\Home\ViewDetails.cshtml"
WriteAttributeValue("", 768, Url.Action("Delete","Home",new { @Id = employee.Id}), 768, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\Home\ViewDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div style=\"margin-top:1cm\" class=\"card-footer text-center\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 977, "\"", 1011, 1);
#nullable restore
#line 27 "C:\Users\JeevanandamPerumal\source\repos\EmployeeDetails\Assignment\Views\Home\ViewDetails.cshtml"
WriteAttributeValue("", 984, Url.Action("Index","Home"), 984, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Back To Home</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "796b14d71b3a9574928c05d0455107a7a306f0d010727", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
