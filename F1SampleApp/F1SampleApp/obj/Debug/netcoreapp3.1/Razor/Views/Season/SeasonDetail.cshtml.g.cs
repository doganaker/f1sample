#pragma checksum "C:\Users\dogan\OneDrive\Masaüstü\f1project\F1SampleApp\F1SampleApp\Views\Season\SeasonDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d19e1a15fd06f2135dc31a6700da0af111fcf94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Season_SeasonDetail), @"mvc.1.0.view", @"/Views/Season/SeasonDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d19e1a15fd06f2135dc31a6700da0af111fcf94", @"/Views/Season/SeasonDetail.cshtml")]
    public class Views_Season_SeasonDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dogan\OneDrive\Masaüstü\f1project\F1SampleApp\F1SampleApp\Views\Season\SeasonDetail.cshtml"
  
    ViewData["Title"] = "SeasonDetail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""module"" src=""/js/seasondetailop.js ""></script>
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.22/css/jquery.dataTables.css"">

<script type=""text/javascript"" charset=""utf8""
        src=""https://cdn.datatables.net/1.10.22/js/jquery.dataTables.js""></script>

<br>
<br>
<div class=""container"">
    <div class=""page-header"">
        <h1>Season Detail</h1>
    </div>
    <br>
    <br>
    <div>
        <div class=""row justify-content-start"">
            <div class=""col-lg-3"" style=""display:flex;align-items:flex-end"">
                <label class=""px-2"">Round:</label>
                <select");
            BeginWriteAttribute("name", " name=\"", 750, "\"", 757, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" id=""roundsselect"">
                </select>
            </div>
        </div>
        <br>
        <div class=""table-responsive-sm"">
            <table class=""table table-hover"" id=""lb"">
                <thead>
                    <tr>
                        <th scope=""col"" value=""position"">Position</th>
                        <th scope=""col"" value=""Driver.givenName"">Name</th>
                        <th scope=""col"" value=""Constructor.nationality"">Nationality</th>
                        <th scope=""col"" value=""FastestLap.Time.time"">Fastest Time</th>
                        <th scope=""col"" value=""FastestLap.AverageSpeed.speed"">Fastest Speed</th>
                        <th scope=""col"" value=""Constructor.url"">Team Url</th>

                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
        </div>

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
