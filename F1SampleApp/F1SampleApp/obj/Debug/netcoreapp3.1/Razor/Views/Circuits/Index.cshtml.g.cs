#pragma checksum "C:\Users\Hp\Desktop\f1sample\F1SampleApp\F1SampleApp\Views\Circuits\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72114e32bf026206b1d89b7e4b0cc7ddf3344685"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Circuits_Index), @"mvc.1.0.view", @"/Views/Circuits/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72114e32bf026206b1d89b7e4b0cc7ddf3344685", @"/Views/Circuits/Index.cshtml")]
    public class Views_Circuits_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Hp\Desktop\f1sample\F1SampleApp\F1SampleApp\Views\Circuits\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""module"" src=""/js/circuitshtmloperations.js""></script>
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.22/css/jquery.dataTables.css"">

<script type=""text/javascript"" charset=""utf8""
        src=""https://cdn.datatables.net/1.10.22/js/jquery.dataTables.js""></script>

<br>
<br>

<div class=""container"">
    <div class=""page-header"">
        <h1>F1 Season Circuits</h1>
    </div>
    <div class=""row"">
        <div class=""col-lg-3"">
            <select class=""form-control""");
            BeginWriteAttribute("name", " name=\"", 619, "\"", 626, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""yearsselect"">
            </select>
        </div>
    </div>
    <br>
    <div class=""row"">
        <table class=""table"" id=""lb"">
            <thead>
                <tr>
                    <th scope=""col"">Circuit Id</th>
                    <th scope=""col"">Circuit Name</th>
                    <th scope=""col"">Location</th>
                    <th scope=""col"">Country</th>
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
