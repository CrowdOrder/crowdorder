#pragma checksum "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2182e1bd2a26883344f5dae10425f43be9d9ca08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Affiliate_Index), @"mvc.1.0.view", @"/Views/Affiliate/Index.cshtml")]
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
#line 2 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
using CrowdOrder.beta.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2182e1bd2a26883344f5dae10425f43be9d9ca08", @"/Views/Affiliate/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6826422b3abbdbbac0260d59355659aa0c6d4186", @"/Views/_ViewImports.cshtml")]
    public class Views_Affiliate_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrowdOrder.beta.Models.Affiliate>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Affiliate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
  
    ViewData["Title"] = "Affiliates";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <div class=""d-flex justify-content-between align-items-center"">
                <h1>Website Admin</h1>
                <ol>
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 505, "\"", 569, 1);
#nullable restore
#line 18 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
WriteAttributeValue("", 512, UrlRewriteService.FixUrl(Context.Request.Host.Value, ""), 512, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a></li>\r\n                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2182e1bd2a26883344f5dae10425f43be9d9ca086456", async() => {
                WriteLiteral("Website Admin");
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
            WriteLiteral(@"</li>
                    <li>Affiliates</li>
                </ol>
            </div>
        </div>
    </section><!-- End Breadcrumbs -->
    <!-- ======= About Section ======= -->
    <section id=""about"" class=""about"">
        <div class=""container"">
            <div class=""row"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2182e1bd2a26883344f5dae10425f43be9d9ca087854", async() => {
                WriteLiteral("\r\n                    <span class=\"glyphicon glyphicon-plus\" aria-hidden=\"true\"></span>Create new affiliate link\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 37 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 40 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 43 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Link));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 49 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 53 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 59 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
                           Write(UrlRewriteService.AffiliatesUrl(Context.Request.Host.Value, item.Link));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2182e1bd2a26883344f5dae10425f43be9d9ca0812331", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2182e1bd2a26883344f5dae10425f43be9d9ca0814536", async() => {
                WriteLiteral("copy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 66 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Affiliate\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CrowdOrder.beta.Models.Affiliate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
