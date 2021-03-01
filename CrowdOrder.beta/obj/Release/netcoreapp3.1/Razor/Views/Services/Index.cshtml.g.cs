#pragma checksum "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "995cead1ab32ba75d0c2e7d589492ec560970ddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
#line 2 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml"
using CrowdOrder.beta.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"995cead1ab32ba75d0c2e7d589492ec560970ddf", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6826422b3abbdbbac0260d59355659aa0c6d4186", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServicesVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/commerce320.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml"
  
    ViewData["Title"] = "Start Up and Small Business Services, Offers and Discounts";

#line default
#line hidden
#nullable disable
            DefineSection("metatags", async() => {
                WriteLiteral("\r\n    <meta name=\"description\" content=\"Does your start up or small business have a need that needs real expertise? Search Crowd Order\'s marketplace to find the perfect partner for all your business needs.\" />\r\n");
            }
            );
            WriteLiteral(@"<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <div class=""d-flex justify-content-between align-items-center"">
                <ol>
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 661, "\"", 725, 1);
#nullable restore
#line 18 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml"
WriteAttributeValue("", 668, UrlRewriteService.FixUrl(Context.Request.Host.Value, ""), 668, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Home</a></li>
                    <li>Services</li>
                </ol>
            </div>

        </div>
    </section><!-- End Breadcrumbs -->
    <section id=""services"" class=""blog"">
        <div class=""home-container"">
            <div class=""container"">
                <div class=""row content"">
                    <div class=""col-lg-6  pt-4 pt-lg-0"" style=""padding-right:0px;"">
                        <h1>Start Up and Small Business Services, Offers and Discounts</h1>
                        <p>
                            Our partners have been handpicked to provide your small business with the support you need to thrive. We’ve organised their services into categories, and if you click into a category, you’ll be able to see all of the service providers with a quick overview of what they can offer you.
                        </p>
                    </div>
                    <div class=""col-lg-6"" style=""text-align:center;"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "995cead1ab32ba75d0c2e7d589492ec560970ddf5991", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id=""clients"" class=""clients hideSmall"">
        <div class=""home-container"">
            <div class=""container"">
                <div class=""row content"">
                    <h2>Featured partner: </h2>
                </div>

                <div class=""row"">
                    <div class=""home-container"">
                        <div class=""container"">
                            <div class=""row content"">
                                <div class=""row"" style=""padding: 20px;"">
                                    <div class=""col-lg-4  pt-4 pt-lg-0"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 2485, "\"", 2590, 1);
#nullable restore
#line 55 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml"
WriteAttributeValue("", 2491, UrlRewriteService.FixUrl(Context.Request.Host.Value, $"/Partners/{Model.FeaturedPartner.LogoUrl}"), 2491, 99, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2591, "\"", 2597, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                                    </div>\r\n                                    <div class=\"col-lg-8\">\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 59 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => Model.FeaturedPartner.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                        <div class=\"read-more\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3028, "\"", 3115, 1);
#nullable restore
#line 62 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml"
WriteAttributeValue("", 3035, UrlRewriteService.FixUrl(Context.Request.Host.Value, Model.FeaturedPartner.Url), 3035, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Click here for offers</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id=""about"" class=""blog section-bg"">
        <div class=""container"">
            <div class=""row"">
                <h2>View services for</h2>
            </div>
            <div class=""row"">
");
#nullable restore
#line 79 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml"
                 foreach (var item in Model.Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4  col-md-6 d-flex align-items-stretch\" data-aos=\"fade-up\">\r\n                        <article class=\"entry\">\r\n                            <div class=\"entry-img\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3971, "\"", 4053, 1);
#nullable restore
#line 84 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml"
WriteAttributeValue("", 3977, UrlRewriteService.FixUrl(Context.Request.Host.Value, $"img/{item.Url}.png"), 3977, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />                                \r\n                            </div>\r\n                            <h2 class=\"entry-title\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4233, "\"", 4345, 1);
#nullable restore
#line 87 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml"
WriteAttributeValue("", 4240, UrlRewriteService.FixUrl(Context.Request.Host.Value, $"small-business-start-up-blogs-guides/{item.Url}"), 4240, 105, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 87 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml"
                                                                                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </h2>

                            <div class=""entry-content"">
                                <p>

                                </p>
                                <div class=""read-more"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 4629, "\"", 4741, 1);
#nullable restore
#line 95 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml"
WriteAttributeValue("", 4636, UrlRewriteService.FixUrl(Context.Request.Host.Value, $"small-business-start-up-blogs-guides/{item.Url}"), 4636, 105, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Find out more</a>\r\n                                </div>\r\n                            </div>\r\n\r\n                        </article><!-- End blog entry -->\r\n                    </div>\r\n");
#nullable restore
#line 101 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Services\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>


    <section id=""clients"" class=""clients hideSmall"">
        <div class=""home-container"">
            <div class=""container"">
                <div class=""row content"">
                    <h2>Most popular partners</h2>
                </div>

                <div class=""row"">
                    <div class=""home-container"">
                        <div class=""container"">
                            <div class=""row content"">
                                <div class=""row"" style=""padding: 20px;"">
                                    <div class=""col-lg-2 col-md-4 col-6 d-flex align-items-center justify-content-center"">
                                        <a href=""small-business-start-up-services/mazuma-money""><img src=""partners/Mazuma_Logo.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 5788, "\"", 5794, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                    <div class=""col-lg-2 col-md-4 col-6 d-flex align-items-center justify-content-center"">
                                        <a href=""small-business-start-up-services/opayo""><img src=""partners/Opayo.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 6106, "\"", 6112, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                    <div class=""col-lg-2 col-md-4 col-6 d-flex align-items-center justify-content-center"">
                                        <a href=""small-business-start-up-services/pipedrive""><img src=""partners/pipedrive_logo.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 6437, "\"", 6443, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                    <div class=""col-lg-2 col-md-4 col-6 d-flex align-items-center justify-content-center"">
                                        <a href=""small-business-start-up-services/monday-dot-com""><img src=""partners/mondaydotcom.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 6771, "\"", 6777, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                    <div class=""col-lg-2 col-md-4 col-6 d-flex align-items-center justify-content-center"">
                                        <a href=""small-business-start-up-services/get-response""><img src=""partners/get-response.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 7103, "\"", 7109, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                    <div class=""col-lg-2 col-md-4 col-6 d-flex align-items-center justify-content-center"">
                                        <a href=""small-business-start-up-services/you-at-work""><img src=""partners/You_at_work_logo.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 7438, "\"", 7444, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServicesVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
