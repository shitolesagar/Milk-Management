#pragma checksum "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Advance\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a73074de8737f46131eb6e606b8666fecc87d77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advance_Details), @"mvc.1.0.view", @"/Views/Advance/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Advance/Details.cshtml", typeof(AspNetCore.Views_Advance_Details))]
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
#line 1 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\_ViewImports.cshtml"
using Milk.Web;

#line default
#line hidden
#line 2 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\_ViewImports.cshtml"
using Milk.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a73074de8737f46131eb6e606b8666fecc87d77", @"/Views/Advance/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f48d3398ce6110a121323409411c825ce9cd3e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Advance_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Milk.Web.ViewModels.AdvanceDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Advance\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(95, 163, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Name</label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(260, 12, false);
#line 10 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Advance\Details.cshtml"
             Write(Model.Farmer);

#line default
#line hidden
            EndContext();
            BeginContext(273, 155, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Date</label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(430, 10, false);
#line 14 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Advance\Details.cshtml"
             Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(441, 157, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Amount</label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(600, 12, false);
#line 18 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Advance\Details.cshtml"
             Write(Model.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(613, 54, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<button type=\"button\" class=\"col-md-4\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 667, "\"", 723, 3);
            WriteAttributeValue("", 677, "location.href=\'", 677, 15, true);
#line 21 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Advance\Details.cshtml"
WriteAttributeValue("", 692, Url.Action("Index","Advance"), 692, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 722, "\'", 722, 1, true);
            EndWriteAttribute();
            BeginContext(724, 32, true);
            WriteLiteral(">Back To Index Page</button>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Milk.Web.ViewModels.AdvanceDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
