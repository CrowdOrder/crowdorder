#pragma checksum "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\_ArticleSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01ae478ac683ca75d6e6db3871083c896d29358a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog__ArticleSummary), @"mvc.1.0.view", @"/Views/Blog/_ArticleSummary.cshtml")]
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
#line 2 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\_ArticleSummary.cshtml"
using CrowdOrder.beta.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01ae478ac683ca75d6e6db3871083c896d29358a", @"/Views/Blog/_ArticleSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6826422b3abbdbbac0260d59355659aa0c6d4186", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog__ArticleSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrowdOrder.beta.Models.Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row article-summary\">\r\n    <div class=\"col-md-4\">\r\n        <profile-picture");
            BeginWriteAttribute("profile", " profile=\"", 168, "\"", 191, 1);
#nullable restore
#line 6 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\_ArticleSummary.cshtml"
WriteAttributeValue("", 178, Model.Author, 178, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" size-px=\"40\" />\r\n        <p class=\"text-center author-name\">\r\n            ");
#nullable restore
#line 8 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\_ArticleSummary.cshtml"
        Write(Model.Author.Email ?? Model.Author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p class=\"text-center\">\r\n            ");
#nullable restore
#line 11 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\_ArticleSummary.cshtml"
       Write(Model.CreatedDate.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n        <h4>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 500, "\"", 613, 1);
#nullable restore
#line 16 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\_ArticleSummary.cshtml"
WriteAttributeValue("", 507, UrlRewriteService.FixUrl(Context.Request.Host.Value, $"small-business-start-up-blogs-guides/{Model.Url}"), 507, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\_ArticleSummary.cshtml"
                                                                                                                            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </h4>\r\n        <blockquote>\r\n            <p>");
#nullable restore
#line 19 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\_ArticleSummary.cshtml"
          Write(Model.Abstract);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </blockquote>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrowdOrder.beta.Models.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
