#pragma checksum "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9239019a840e8e45ba90a86f6c6163e0cfdd4c4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SubCategorys_Details), @"mvc.1.0.view", @"/Views/SubCategorys/Details.cshtml")]
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
#line 2 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
using CrowdOrder.beta.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9239019a840e8e45ba90a86f6c6163e0cfdd4c4d", @"/Views/SubCategorys/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6826422b3abbdbbac0260d59355659aa0c6d4186", @"/Views/_ViewImports.cshtml")]
    public class Views_SubCategorys_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrowdOrder.beta.Models.SubCategory>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            DefineSection("metatags", async() => {
                WriteLiteral("\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 178, "\"", 210, 1);
#nullable restore
#line 8 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
WriteAttributeValue("", 188, Model.MetaDescription, 188, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\'og:title\' content=\'Crowd Order\' />\r\n    <meta property=\'og:image\'");
                BeginWriteAttribute("content", " content=\'", 301, "\'", 379, 1);
#nullable restore
#line 10 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
WriteAttributeValue("", 311, UrlRewriteService.FixUrl(Context.Request.Host.Value, "Logo100.png"), 311, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\'og:description\'");
                BeginWriteAttribute("content", " content=\'", 420, "\'", 452, 1);
#nullable restore
#line 11 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
WriteAttributeValue("", 430, Model.MetaDescription, 430, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\'og:url\'");
                BeginWriteAttribute("content", " content=\'", 485, "\'", 559, 1);
#nullable restore
#line 12 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
WriteAttributeValue("", 495, UrlRewriteService.FixUrl(Context.Request.Host.Value, Model.Url), 495, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\'twitter:card\' content=\'summary\' />\r\n    <meta name=\'twitter:site\'");
                BeginWriteAttribute("content", " content=\'", 646, "\'", 720, 1);
#nullable restore
#line 14 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
WriteAttributeValue("", 656, UrlRewriteService.FixUrl(Context.Request.Host.Value, Model.Url), 656, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\'twitter:title\' content=\'Crowd Order\' />\r\n    <meta name=\'twitter:description\'");
                BeginWriteAttribute("content", " content=\'", 819, "\'", 851, 1);
#nullable restore
#line 16 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
WriteAttributeValue("", 829, Model.MetaDescription, 829, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\'twitter:image\'");
                BeginWriteAttribute("content", " content=\'", 887, "\'", 965, 1);
#nullable restore
#line 17 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
WriteAttributeValue("", 897, UrlRewriteService.FixUrl(Context.Request.Host.Value, "Logo100.png"), 897, 68, false);

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
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1250, "\"", 1314, 1);
#nullable restore
#line 28 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
WriteAttributeValue("", 1257, UrlRewriteService.FixUrl(Context.Request.Host.Value, ""), 1257, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a></li>\r\n                    <li><a href=\"/small-business-start-up-services\">Services</a></li>\r\n                    <li>");
#nullable restore
#line 30 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ol>\r\n            </div>\r\n\r\n        </div>\r\n    </section><!-- End Breadcrumbs -->\r\n\r\n    <section id=\"blog\" class=\"blog\">\r\n        <div class=\"container\">\r\n\r\n            <div class=\"row\">\r\n                <h1>");
#nullable restore
#line 41 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
               Write(Html.DisplayFor(model => model.H1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <p>");
#nullable restore
#line 42 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
              Write(Html.DisplayFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 44 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
                     foreach (var item in Model.Services)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4  col-md-6 d-flex align-items-stretch\" data-aos=\"fade-up\">\r\n                            <div class=\"entry\">\r\n\r\n                                <div class=\"entry-img\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2160, "\"", 2256, 1);
#nullable restore
#line 50 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
WriteAttributeValue("", 2166, UrlRewriteService.FixUrl(Context.Request.Host.Value, $"/Partners/{item.Partner.LogoUrl}"), 2166, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2257, "\"", 2263, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                                </div>\r\n\r\n                                <h2 class=\"entry-title\">\r\n                                    ");
#nullable restore
#line 54 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Partner.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h2>\r\n\r\n                                <div class=\"entry-content\">\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 59 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Partner.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <div class=\"read-more\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2850, "\"", 2928, 1);
#nullable restore
#line 62 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
WriteAttributeValue("", 2857, UrlRewriteService.FixUrl(Context.Request.Host.Value, item.Partner.Url), 2857, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click here for offers</a>\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div><!-- End blog entry -->\r\n                        </div>\r\n");
#nullable restore
#line 68 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\SubCategorys\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrowdOrder.beta.Models.SubCategory> Html { get; private set; }
    }
}
#pragma warning restore 1591
