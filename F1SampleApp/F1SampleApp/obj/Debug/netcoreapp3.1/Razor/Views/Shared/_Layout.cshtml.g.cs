#pragma checksum "C:\Users\dogan\OneDrive\Masaüstü\f1project\F1SampleApp\F1SampleApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "925b58c0aed13128bb47e1e247e6f5f57990794a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"925b58c0aed13128bb47e1e247e6f5f57990794a", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "925b58c0aed13128bb47e1e247e6f5f57990794a2754", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>BABoost</title>
    <link rel=""apple-touch-icon"" sizes=""180x180"" href=""/img/apple-touch-icon.png"">
    <link rel=""icon"" type=""image/png"" sizes=""32x32"" href=""/img/favicon-32x32.png"">
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""/img/favicon-16x16.png"">
    <link rel=""manifest"" href=""/img/site.webmanifest"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css""
          integrity=""sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2"" crossorigin=""anonymous"">
    <link href=""https://fonts.googleapis.com/css2?family=Racing+Sans+One&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""/css/main.css"">
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""
            integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj""
            crossorigin=""anonymous");
                WriteLiteral(@"""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js""
            integrity=""sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.min.js""
            integrity=""sha384-w1Q4orYjBQndcko6MimVbzY0tgp4pWB4lZ7lr30WKz0vr/aWKhXdBNmNb5D92v7s""
            crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "925b58c0aed13128bb47e1e247e6f5f57990794a5325", async() => {
                WriteLiteral(@"


        <!-- Navbar -->
        <nav class=""navbar navbar-expand-lg fixed-top navbar-custom"">
            <div class=""container"">
                <a class=""navbar-brand"" href=""/Home/"">
                    <img src=""/img/favicon-32x32.png"" width=""32"" height=""32""");
                BeginWriteAttribute("alt", " alt=\"", 1833, "\"", 1839, 0);
                EndWriteAttribute();
                WriteLiteral(@" loading=""lazy"">
                    BABoost
                </a>
                <button class=""navbar-toggler navbar-light"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavDropdown""
                        aria-controls=""navbarNavDropdown"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarNavDropdown"">
                    <ul class=""navbar-nav ml-auto"">
                        <li class=""nav-item active"">
                            <a class=""nav-link"" href=""/Home/"">
                                Home <span class=""sr-only"">(current)</span>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Home/About"">About</a>
                        </li>
                        <li class=""nav-item"">
                          ");
                WriteLiteral(@"  <a class=""nav-link"" href=""/F1Drivers2020/"">2020's Drivers</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Home/CurrentLeaderboard"">2020's Leaderboard</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink"" role=""button"" data-toggle=""dropdown""
                               aria-haspopup=""true"" aria-expanded=""false"">
                                Tables
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownMenuLink"">
                                <a class=""dropdown-item"" href=""/Driver/"">Drivers</a>
                                <a class=""dropdown-item"" href=""/Constructor/"">Constructors</a>
                                <a class=""dropdown-item"" href=""/Standings/"">Standings</a>
          ");
                WriteLiteral(@"                      <a class=""dropdown-item"" href=""/Season/"">Seasons</a>
                                <a class=""dropdown-item"" href=""/Circuits/"">Circuits</a>
                                <a class=""dropdown-item"" href=""/Qualifying/"">Qualifyings</a>
                                <a class=""dropdown-item"" href=""/Laps/"">Laps</a>
                                <a class=""dropdown-item"" href=""/PitStops/"">
                                    Pit
                                    Stops
                                </a>
                                <a class=""dropdown-item"" href=""/FinishingStatus/"">Finishing Status</a>
                                <a class=""dropdown-item"" href=""/RaceSchedule/"">Race Schedule</a>
                            </div>
                        </li>

                    </ul>
                </div>
            </div>
           
        </nav>
        <br>
        <br>


        ");
#nullable restore
#line 88 "C:\Users\dogan\OneDrive\Masaüstü\f1project\F1SampleApp\F1SampleApp\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    <br>\r\n    <br>\r\n    <br>\r\n\r\n    <!-- Footer -->\r\n    <div class=\"footer\">\r\n        BABoost\r\n        <br>\r\n        2020\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
