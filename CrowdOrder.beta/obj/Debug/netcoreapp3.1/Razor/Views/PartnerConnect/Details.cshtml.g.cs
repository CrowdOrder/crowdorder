#pragma checksum "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfb59d3f97b8790d88f9d27cdc728487ea63bc9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PartnerConnect_Details), @"mvc.1.0.view", @"/Views/PartnerConnect/Details.cshtml")]
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
#line 2 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
using CrowdOrder.beta.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfb59d3f97b8790d88f9d27cdc728487ea63bc9c", @"/Views/PartnerConnect/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6826422b3abbdbbac0260d59355659aa0c6d4186", @"/Views/_ViewImports.cshtml")]
    public class Views_PartnerConnect_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrowdOrder.beta.Data.PartnerConnectionVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("metatags", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
     if (Model.PartnerConnection.Service.PartnerSignupType == CrowdOrder.beta.Data.DataHelpers.PartnerSignupType.Url)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <meta http-equiv=\"refresh\"");
                BeginWriteAttribute("content", " content=\"", 316, "\"", 375, 2);
                WriteAttributeValue("", 326, "5;url=", 326, 6, true);
#nullable restore
#line 11 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
WriteAttributeValue("", 332, Model.PartnerConnection.Service.ConnectUrl, 332, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 12 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
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
                    <li>Thank you</li>
                </ol>
            </div>

        </div>
    </section><!-- End Breadcrumbs -->

    <section id=""blog"" class=""blog"">
        <div class=""container"">

            <div class=""row"">
                <h1>Thank you for selecting ");
#nullable restore
#line 35 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
                                       Write(Model.PartnerConnection.Service.Partner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <p></p>\r\n            </div>\r\n\r\n");
#nullable restore
#line 39 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
             if (Model.PartnerConnection.Service.PartnerSignupType == CrowdOrder.beta.Data.DataHelpers.PartnerSignupType.Url)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <p>You will be redirected in 5 seconds to their website</p>\r\n                </div>\r\n");
#nullable restore
#line 44 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <p>Your details have been sent to ");
#nullable restore
#line 48 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
                                                 Write(Model.PartnerConnection.Service.Partner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" who will contact you in due course</p>\r\n                </div>\r\n");
#nullable restore
#line 50 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </section>\r\n    <section id=\"blog\" class=\"blog\">\r\n        <div class=\"container\">\r\n\r\n            <div class=\"row\">\r\n                <h3>You may also be interested in</h3>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 59 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
                     foreach (var item in Model.Suggestions)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4  col-md-6 d-flex align-items-stretch\" data-aos=\"fade-up\">\r\n                            <div class=\"entry\">\r\n\r\n                                <div class=\"entry-img\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2197, "\"", 2293, 1);
#nullable restore
#line 65 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
WriteAttributeValue("", 2203, UrlRewriteService.FixUrl(Context.Request.Host.Value, $"/Partners/{item.Partner.LogoUrl}"), 2203, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2294, "\"", 2300, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                                </div>\r\n\r\n                                <h2 class=\"entry-title\">\r\n                                    ");
#nullable restore
#line 69 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Partner.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h2>\r\n\r\n                                <div class=\"entry-content\">\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 74 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Partner.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <div class=\"read-more\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2887, "\"", 2965, 1);
#nullable restore
#line 77 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
WriteAttributeValue("", 2894, UrlRewriteService.FixUrl(Context.Request.Host.Value, item.Partner.Url), 2894, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click here for offers</a>\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div><!-- End blog entry -->\r\n                        </div>\r\n");
#nullable restore
#line 83 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\PartnerConnect\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>    \r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrowdOrder.beta.Data.PartnerConnectionVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
