#pragma checksum "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Farmer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59a1e2b5ce26aecdf88c2b56a9bd0171944a1681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Farmer_Details), @"mvc.1.0.view", @"/Views/Farmer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Farmer/Details.cshtml", typeof(AspNetCore.Views_Farmer_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59a1e2b5ce26aecdf88c2b56a9bd0171944a1681", @"/Views/Farmer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f48d3398ce6110a121323409411c825ce9cd3e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Farmer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Milk.Web.ViewModels.FarmerDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Farmer\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(94, 163, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Name</label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(259, 18, false);
#line 10 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Farmer\Details.cshtml"
             Write(Model.Name ?? "NA");

#line default
#line hidden
            EndContext();
            BeginContext(278, 158, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Village</label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(438, 21, false);
#line 14 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Farmer\Details.cshtml"
             Write(Model.Village ?? "NA");

#line default
#line hidden
            EndContext();
            BeginContext(460, 166, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Profile Picture</label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(628, 28, false);
#line 18 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Farmer\Details.cshtml"
             Write(Model.ProfilePicture ?? "NA");

#line default
#line hidden
            EndContext();
            BeginContext(657, 164, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Mobile Number</label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(823, 26, false);
#line 22 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Farmer\Details.cshtml"
             Write(Model.MobileNumber ?? "NA");

#line default
#line hidden
            EndContext();
            BeginContext(850, 151, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"float-label mt-2\">Is Active</label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(1003, 22, false);
#line 26 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Farmer\Details.cshtml"
             Write(Model.IsActive ?? "NA");

#line default
#line hidden
            EndContext();
            BeginContext(1026, 54, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<button type=\"button\" class=\"col-md-4\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1080, "\"", 1135, 3);
            WriteAttributeValue("", 1090, "location.href=\'", 1090, 15, true);
#line 29 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Farmer\Details.cshtml"
WriteAttributeValue("", 1105, Url.Action("Index","Farmer"), 1105, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 1134, "\'", 1134, 1, true);
            EndWriteAttribute();
            BeginContext(1136, 32, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Milk.Web.ViewModels.FarmerDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591