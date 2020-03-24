#pragma checksum "E:\Projects\HCM Projects_\AppyController\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33b485c4e2cdae7cff6206972d5389f05e006b62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "E:\Projects\HCM Projects_\AppyController\Views\_ViewImports.cshtml"
using MenuManager;

#line default
#line hidden
#line 2 "E:\Projects\HCM Projects_\AppyController\Views\_ViewImports.cshtml"
using MenuManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33b485c4e2cdae7cff6206972d5389f05e006b62", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bad7df9ce55776236e93c2b663d2127b9ecdeb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Projects\HCM Projects_\AppyController\Views\Home\Privacy.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(75, 3386, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-xl-8 mb-5 mb-xl-0"">
        <div class=""card bg-gradient-default shadow"">
            <div class=""card-header bg-transparent"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h6 class=""text-uppercase text-light ls-1 mb-1"">Overview</h6>
                        <h2 class=""text-white mb-0"">Sales value</h2>
                    </div>
                    <div class=""col"">
                        <ul class=""nav nav-pills justify-content-end"">
                            <li class=""nav-item mr-2 mr-md-0"" data-toggle=""chart"" data-target=""#chart-sales"" data-update=""{&quot;data&quot;:{&quot;datasets&quot;:[{&quot;data&quot;:[0, 20, 10, 30, 15, 40, 20, 60, 60]}]}}"" data-prefix=""$"" data-suffix=""k"">
                                <a href=""#"" class=""nav-link py-2 px-3 active"" data-toggle=""tab"">
                                    <span class=""d-none d-md-block"">Month</span>
                              ");
            WriteLiteral(@"      <span class=""d-md-none"">M</span>
                                </a>
                            </li>
                            <li class=""nav-item"" data-toggle=""chart"" data-target=""#chart-sales"" data-update=""{&quot;data&quot;:{&quot;datasets&quot;:[{&quot;data&quot;:[0, 20, 5, 25, 10, 30, 15, 40, 40]}]}}"" data-prefix=""$"" data-suffix=""k"">
                                <a href=""#"" class=""nav-link py-2 px-3"" data-toggle=""tab"">
                                    <span class=""d-none d-md-block"">Week</span>
                                    <span class=""d-md-none"">W</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <!-- Chart -->
                <div class=""chart"">
                    <div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div class=""""></div></div><div class=""chartjs-size");
            WriteLiteral(@"-monitor-shrink""><div class=""""></div></div></div>
                    <!-- Chart wrapper -->
                    <canvas id=""chart-sales"" class=""chart-canvas chartjs-render-monitor"" width=""990"" height=""350"" style=""display: block; width: 990px; height: 350px;""></canvas>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-4"">
        <div class=""card shadow"">
            <div class=""card-header bg-transparent"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h6 class=""text-uppercase text-muted ls-1 mb-1"">Performance</h6>
                        <h2 class=""mb-0"">Total orders</h2>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <!-- Chart -->
                <div class=""chart"">
                    <div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div class=""""></div></div><div class=""chartjs-");
            WriteLiteral(@"size-monitor-shrink""><div class=""""></div></div></div>
                    <canvas id=""chart-orders"" class=""chart-canvas chartjs-render-monitor"" style=""display: block; width: 455px; height: 350px;"" width=""455"" height=""350""></canvas>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
