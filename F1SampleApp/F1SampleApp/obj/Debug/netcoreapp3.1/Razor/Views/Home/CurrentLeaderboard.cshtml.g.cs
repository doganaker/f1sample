#pragma checksum "C:\Users\dogan\OneDrive\Masaüstü\F1Proje\F1SampleApp\F1SampleApp\Views\Home\CurrentLeaderboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c0b886ec85eb78468051d89341f4e77296de2ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CurrentLeaderboard), @"mvc.1.0.view", @"/Views/Home/CurrentLeaderboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c0b886ec85eb78468051d89341f4e77296de2ad", @"/Views/Home/CurrentLeaderboard.cshtml")]
    public class Views_Home_CurrentLeaderboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dogan\OneDrive\Masaüstü\F1Proje\F1SampleApp\F1SampleApp\Views\Home\CurrentLeaderboard.cshtml"
  
    ViewData["Title"] = "CurrentLeaderboard";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""module"" src=""/js/CLBhtmloperations.js""></script>
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.22/css/jquery.dataTables.css"">

<script type=""text/javascript"" charset=""utf8""
        src=""https://cdn.datatables.net/1.10.22/js/jquery.dataTables.js""></script>


<br>
<br>
<div class=""container"">
    <div class=""row"">
        <div class=""page-header"">
            <h1>2020's (Current) Leaderboard</h1>
        </div>
    </div>
    <br>
    <div class=""row"">
        <table class=""table table-hover"" id=""lb"">
            <thead>
                <tr>
                    <th>Position</th>
                    <th>Pilot</th>
                    <th>Nationality</th>
                    <th>Number</th>
                    <th>Points</th>
                    <th>Wins</th>
                    <th>Team</th>
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
