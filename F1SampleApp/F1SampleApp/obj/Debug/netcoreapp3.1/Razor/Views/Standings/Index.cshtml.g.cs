#pragma checksum "C:\Users\dogan\OneDrive\Masaüstü\F1Proje\F1SampleApp\F1SampleApp\Views\Standings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b2f63ce6305906863f623525448fd63fd2a150d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Standings_Index), @"mvc.1.0.view", @"/Views/Standings/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b2f63ce6305906863f623525448fd63fd2a150d", @"/Views/Standings/Index.cshtml")]
    public class Views_Standings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dogan\OneDrive\Masaüstü\F1Proje\F1SampleApp\F1SampleApp\Views\Standings\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""module"" src=""/js/standinghtmlop.js""></script>
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.22/css/jquery.dataTables.css"">

<script type=""text/javascript"" charset=""utf8""
        src=""https://cdn.datatables.net/1.10.22/js/jquery.dataTables.js""></script>

<br>
<br>

<div class=""container"">
    <div class=""page-header"">
        <h1>F1 Standings</h1>
    </div>
    <div class=""row"">
        <div class=""col-lg-3"">
            <select class=""form-control""");
            BeginWriteAttribute("name", " name=\"", 605, "\"", 612, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"yearsselect\">\r\n            </select>\r\n        </div>\r\n\r\n        <div class=\"col-lg-6\" style=\"display: flex;\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 747, "\"", 753, 0);
            EndWriteAttribute();
            WriteLiteral(@">Limit:</label>
            <input id=""inp1"" type=""text"" class=""form-control"">
            <button id=""searchbtn"" class=""btn"">Search</button>
        </div>

    </div>
    <br>
    <div class=""row"">
        <div class=""col-lg-3"">
            <select");
            BeginWriteAttribute("name", " name=\"", 1013, "\"", 1020, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" id=""roundsselect"">
            </select>
        </div>
    </div>
    <br>


</div>
<div class=""row"" style=""margin-left: 10px;"">
    <table class=""table"" id=""lb"">
        <thead>
            <tr>
                <th>Driver ID</th>
                <th>Full Name</th>
                <th>Nationality</th>
                <th>Bio</th>
                <th>Position</th>
                <th>Points</th>
                <th>Wins</th>
                <th>Team</th>
                <th>Team Nationality</th>
                <th>Team Bio</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
