#pragma checksum "C:\Users\berkc\Desktop\F1\F1SampleApp\F1SampleApp\Views\Standings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bdb787f7d0de3594dbd679456efa6bf59c592bc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bdb787f7d0de3594dbd679456efa6bf59c592bc", @"/Views/Standings/Index.cshtml")]
    public class Views_Standings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\berkc\Desktop\F1\F1SampleApp\F1SampleApp\Views\Standings\Index.cshtml"
  
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
        <h1>Standings</h1>
    </div>
    <br>
    <br>
    <div class=""row"">
        <div class=""col-lg-3"" style=""display:flex;"">
            <label class=""px-2"">Year:</label>
            <select class=""form-control""");
            BeginWriteAttribute("name", " name=\"", 691, "\"", 698, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"yearsselect\">\r\n            </select>\r\n        </div>\r\n        <div class=\"col-lg-3\" style=\"display:flex;\">\r\n            <label class=\" px-2\">Round:</label>\r\n            <select");
            BeginWriteAttribute("name", " name=\"", 880, "\"", 887, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" id=""roundsselect"">
            </select>
        </div>
    </div>
    <br>
    <div class=""row"">
        <table class=""table table-hover"" id=""lb"">
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
                    <th>Team Bio</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
</div>


");
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
