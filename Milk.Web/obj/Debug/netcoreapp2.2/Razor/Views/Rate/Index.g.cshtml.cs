#pragma checksum "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Rate\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19b743c2fcc2f52808836c0c131574619edcbde8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rate_Index), @"mvc.1.0.view", @"/Views/Rate/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rate/Index.cshtml", typeof(AspNetCore.Views_Rate_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19b743c2fcc2f52808836c0c131574619edcbde8", @"/Views/Rate/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f48d3398ce6110a121323409411c825ce9cd3e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Rate_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Milk.Web.ViewModels.RateChartWrapperViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Rate\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 38, true);
            WriteLiteral("<button type=\"button\" class=\"col-md-2\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 133, "\"", 186, 3);
            WriteAttributeValue("", 143, "location.href=\'", 143, 15, true);
#line 5 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Rate\Index.cshtml"
WriteAttributeValue("", 158, Url.Action("Index","Home"), 158, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 185, "\'", 185, 1, true);
            EndWriteAttribute();
            BeginContext(187, 118, true);
            WriteLiteral(">Back</button>\r\n<div class=\"row\">\r\n    <h1 class=\"col-md-4\">Index</h1>\r\n</div>\r\n<button type=\"button\" class=\"col-md-2\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 305, "\"", 368, 3);
            WriteAttributeValue("", 315, "location.href=\'", 315, 15, true);
#line 9 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Rate\Index.cshtml"
WriteAttributeValue("", 330, Url.Action("RateSheetImport","Rate"), 330, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 367, "\'", 367, 1, true);
            EndWriteAttribute();
            BeginContext(369, 316, true);
            WriteLiteral(@">Upload Rate Excel</button>
<div id=""indexPartialContent"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th width=""20%"">FAT</th>
                <th width=""20%"">SNF</th>
                <th width=""20%"">Rate</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 20 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Rate\Index.cshtml"
             foreach (var rate in Model.RateChartList)
            {

#line default
#line hidden
            BeginContext(756, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(803, 8, false);
#line 23 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Rate\Index.cshtml"
                   Write(rate.FAT);

#line default
#line hidden
            EndContext();
            BeginContext(811, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(843, 8, false);
#line 24 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Rate\Index.cshtml"
                   Write(rate.SNF);

#line default
#line hidden
            EndContext();
            BeginContext(851, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(883, 9, false);
#line 25 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Rate\Index.cshtml"
                   Write(rate.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(892, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 27 "E:\@Saggy\Milk Project\Project\Milk\Milk.Web\Views\Rate\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(937, 44, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Milk.Web.ViewModels.RateChartWrapperViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
