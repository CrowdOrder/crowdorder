#pragma checksum "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43d19c3cc53d9fe1a24babb1f1d4c099994ec970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorys_Details), @"mvc.1.0.view", @"/Views/Categorys/Details.cshtml")]
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
#nullable restore
#line 1 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\_ViewImports.cshtml"
using CrowdOrder.beta;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\_ViewImports.cshtml"
using CrowdOrder.beta.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
using CrowdOrder.beta.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d19c3cc53d9fe1a24babb1f1d4c099994ec970", @"/Views/Categorys/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6826422b3abbdbbac0260d59355659aa0c6d4186", @"/Views/_ViewImports.cshtml")]
    public class Views_Categorys_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrowdOrder.beta.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            DefineSection("metatags", async() => {
                WriteLiteral("\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 175, "\"", 207, 1);
#nullable restore
#line 8 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
WriteAttributeValue("", 185, Model.MetaDescription, 185, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            WriteLiteral(@"
<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <div class=""d-flex justify-content-between align-items-center"">
                <ol>
                    <li><a href=""index.html"">Home</a></li>
                    <li><a href=""/small-business-start-up-services"">Services</a></li>
                    <li>");
#nullable restore
#line 21 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ol>\r\n            </div>\r\n\r\n        </div>\r\n    </section><!-- End Breadcrumbs -->\r\n\r\n    <section id=\"blog\" class=\"blog\">\r\n        <div class=\"container\">\r\n\r\n            <div class=\"row\">\r\n                <h1>");
#nullable restore
#line 32 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
               Write(Html.DisplayFor(model => model.H1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <p>");
#nullable restore
#line 33 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
              Write(Html.DisplayFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
                 foreach (var item in Model.SubCategories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <section id=\"blog\" class=\"blog\">\r\n                <h3>");
#nullable restore
#line 37 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                <div class=\"row\">\r\n\r\n");
            WriteLiteral("                </div>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 43 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
                     foreach (var serv in item.Services)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4  col-md-6 d-flex align-items-stretch\" data-aos=\"fade-up\">\r\n                            <div class=\"entry\">\r\n\r\n                                <div class=\"entry-img\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1677, "\"", 1773, 1);
#nullable restore
#line 49 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
WriteAttributeValue("", 1683, UrlRewriteService.FixUrl(Context.Request.Host.Value, $"/Partners/{serv.Partner.LogoUrl}"), 1683, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1774, "\"", 1780, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                                </div>\r\n\r\n                                <h2 class=\"entry-title\">\r\n                                    ");
#nullable restore
#line 53 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => serv.Partner.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h2>\r\n\r\n                                <div class=\"entry-content\">\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 58 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => serv.Partner.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <div class=\"read-more\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2367, "\"", 2445, 1);
#nullable restore
#line 61 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
WriteAttributeValue("", 2374, UrlRewriteService.FixUrl(Context.Request.Host.Value, serv.Partner.Url), 2374, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click here for offers</a>\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div><!-- End blog entry -->\r\n                        </div>\r\n");
#nullable restore
#line 67 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </section>  \r\n");
#nullable restore
#line 70 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Categorys\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrowdOrder.beta.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
