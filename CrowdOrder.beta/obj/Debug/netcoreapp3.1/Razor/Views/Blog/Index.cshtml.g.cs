#pragma checksum "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fddaeb6a3b09fa264062166563114a8f36acb95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 2 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
using CrowdOrder.beta.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fddaeb6a3b09fa264062166563114a8f36acb95", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6826422b3abbdbbac0260d59355659aa0c6d4186", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrowdOrder.beta.Models.Article>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Start Up and Small Business Blog and Guides";

#line default
#line hidden
#nullable disable
            DefineSection("metatags", async() => {
                WriteLiteral(@"
    <meta name=""description"" content=""There are so many factors that go into making a start up or SME successful. Our Blogs and Guide are a great resource to help you drive your business forward."" />
    
    <meta property='og:title' content='Crowd Order' />
    <meta property='og:image'");
                BeginWriteAttribute("content", " content=\'", 727, "\'", 805, 1);
#nullable restore
#line 17 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
WriteAttributeValue("", 737, UrlRewriteService.FixUrl(Context.Request.Host.Value, "Logo100.png"), 737, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\'og:description\' content=\'There are so many factors that go into making a start up or SME successful. Our Blogs and Guide are a great resource to help you drive your business forward.\' />\r\n    <meta property=\'og:url\'");
                BeginWriteAttribute("content", " content=\'", 1046, "\'", 1149, 1);
#nullable restore
#line 19 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1056, UrlRewriteService.FixUrl(Context.Request.Host.Value, "small-business-start-up-blogs-guides"), 1056, 93, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\'twitter:card\' content=\'summary\' />\r\n    <meta name=\'twitter:site\'");
                BeginWriteAttribute("content", " content=\'", 1236, "\'", 1339, 1);
#nullable restore
#line 21 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1246, UrlRewriteService.FixUrl(Context.Request.Host.Value, "small-business-start-up-blogs-guides"), 1246, 93, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    <meta name='twitter:title' content='Crowd Order' />
    <meta name='twitter:description' content='There are so many factors that go into making a start up or SME successful. Our Blogs and Guide are a great resource to help you drive your business forward.' />
    <meta name='twitter:image'");
                BeginWriteAttribute("content", " content=\'", 1641, "\'", 1719, 1);
#nullable restore
#line 24 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1651, UrlRewriteService.FixUrl(Context.Request.Host.Value, "Logo100.png"), 1651, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    \r\n");
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
                    <li>Blogs &amp; Guides</li>
                </ol>
            </div>

        </div>
    </section><!-- End Breadcrumbs -->
    <!-- ======= Blog Section ======= -->
    <section id=""about"" class=""blog"">
        <div class=""container"">
            <div class=""row"">
                <h1>Start Up and Small Business Blog and Guides</h1>
                <p>There are so many factors that go into making a start up or SME successful. Our Blogs and Guide are a great resource to help you drive your business forward.</p>

            </div>
            <div class=""row"">
");
#nullable restore
#line 52 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
                 foreach (var article in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4  col-md-6 d-flex align-items-stretch\" data-aos=\"fade-up\">\r\n                        <article class=\"entry\">\r\n\r\n                            <h2 class=\"entry-title\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2969, "\"", 3084, 1);
#nullable restore
#line 58 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2976, UrlRewriteService.FixUrl(Context.Request.Host.Value, $"small-business-start-up-blogs-guides/{article.Url}"), 2976, 108, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 58 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
                                                                                                                                                  Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h2>\r\n                            <div class=\"entry-img\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3230, "\"", 3327, 1);
#nullable restore
#line 61 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3236, UrlRewriteService.FixUrl(Context.Request.Host.Value, $"img/blogs/{article.MainImagePath}"), 3236, 91, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\r\n                            </div>\r\n\r\n                            <div class=\"entry-meta\">\r\n                                <ul>\r\n                                    <li class=\"d-flex align-items-center\"><i class=\"icofont-user\"></i>");
#nullable restore
#line 66 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
                                                                                                  Write(article.AuthorName ?? article.Author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li class=\"d-flex align-items-center\"><i class=\"icofont-wall-clock\"></i><time datetime=\"2020-01-01\">");
#nullable restore
#line 67 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
                                                                                                                                   Write(article.CreatedDate.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</time></li>\r\n                                </ul>\r\n                            </div>\r\n\r\n                            <div class=\"entry-content\">\r\n                                <p>\r\n                                    ");
#nullable restore
#line 73 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
                               Write(article.Abstract);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <div class=\"read-more\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4191, "\"", 4306, 1);
#nullable restore
#line 76 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4198, UrlRewriteService.FixUrl(Context.Request.Host.Value, $"small-business-start-up-blogs-guides/{article.Url}"), 4198, 108, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read More</a>\r\n                                </div>\r\n                            </div>\r\n\r\n                        </article><!-- End blog entry -->\r\n                    </div>\r\n");
#nullable restore
#line 82 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section><!-- End Blog Section -->\r\n    <section id=\"blog\" class=\"blog\">\r\n        <div class=\"container\">\r\n            <div class=\"=row\">\r\n");
#nullable restore
#line 89 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
                 if (SignInManager.IsSignedIn(User) && SiteDataService.UserIsCrowdOrder(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fddaeb6a3b09fa264062166563114a8f36acb9513616", async() => {
                WriteLiteral("\r\n                            <span class=\"glyphicon glyphicon-plus\" aria-hidden=\"true\"></span> Write a new Article\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 96 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Blog\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n</main>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CrowdOrder.beta.Infrastructure.SiteDataService SiteDataService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CrowdOrder.beta.Models.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
