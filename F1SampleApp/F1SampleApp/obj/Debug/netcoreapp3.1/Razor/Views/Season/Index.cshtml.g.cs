#pragma checksum "C:\Users\Hp\Desktop\f1sample\F1SampleApp\F1SampleApp\Views\Season\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4471d02ed1ce46843afcd385414ba4cc4ed1be6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Season_Index), @"mvc.1.0.view", @"/Views/Season/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4471d02ed1ce46843afcd385414ba4cc4ed1be6", @"/Views/Season/Index.cshtml")]
    public class Views_Season_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Hp\Desktop\f1sample\F1SampleApp\F1SampleApp\Views\Season\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""module"" src=""/js/seasonhtmloperations.js""></script>
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.22/css/jquery.dataTables.css"">

<script type=""text/javascript"" charset=""utf8""
        src=""https://cdn.datatables.net/1.10.22/js/jquery.dataTables.js""></script>


<style>
    td {
        cursor: pointer;
    }
</style>

<br>
<br>
<div class=""container"">
    <div class=""page-header"">
        <h1>Seasons</h1>
    </div>
    <br>
    <br>
    <div class=""row"">
        <table class=""table table-hover"" id=""lb"">
            <thead>
                <tr>
                    <th scope=""col"">Season</th>
                    <th scope=""col"">Season URL</th>
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
