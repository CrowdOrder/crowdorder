#pragma checksum "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\Shared\_Nav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49010a7fa955465b9dcba207aa8afa8bf8155f29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Nav), @"mvc.1.0.view", @"/Views/Shared/_Nav.cshtml")]
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
#line 1 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\_ViewImports.cshtml"
using CrowdOrder.beta;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\_ViewImports.cshtml"
using CrowdOrder.beta.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49010a7fa955465b9dcba207aa8afa8bf8155f29", @"/Views/Shared/_Nav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6826422b3abbdbbac0260d59355659aa0c6d4186", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Nav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<nav class=\"nav-menu d-none d-lg-block\">\r\n\r\n    <ul>\r\n        <li class=\"active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49010a7fa955465b9dcba207aa8afa8bf8155f294350", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n        <li><a href=\"about-us\">About Us</a></li>\r\n        <li class=\"drop-down\">\r\n            <a href=\"/small-business-start-up-services\">Services</a>\r\n            <ul>\r\n");
#nullable restore
#line 10 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\Shared\_Nav.cshtml"
                 foreach (var cat in repo.MenuData())
                {
                    if (cat.SubCategories.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"drop-down\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 605, "\"", 620, 1);
#nullable restore
#line 15 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\Shared\_Nav.cshtml"
WriteAttributeValue("", 612, cat.Url, 612, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\Shared\_Nav.cshtml"
                                          Write(cat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <ul>\r\n");
#nullable restore
#line 17 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\Shared\_Nav.cshtml"
                                 foreach (var sub in cat.SubCategories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 863, "\"", 878, 1);
#nullable restore
#line 20 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\Shared\_Nav.cshtml"
WriteAttributeValue("", 870, sub.Url, 870, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\Shared\_Nav.cshtml"
                                                      Write(sub.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 22 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\Shared\_Nav.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </li>\r\n");
#nullable restore
#line 25 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\Shared\_Nav.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1141, "\"", 1156, 1);
#nullable restore
#line 28 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\Shared\_Nav.cshtml"
WriteAttributeValue("", 1148, cat.Url, 1148, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\Shared\_Nav.cshtml"
                                          Write(cat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 29 "C:\DEV\In Progress\Crowdorder\git\CrowdOrder.beta\Views\Shared\_Nav.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </li>\r\n\r\n        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49010a7fa955465b9dcba207aa8afa8bf8155f299680", async() => {
                WriteLiteral("Blogs &amp; Guides");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\r\n    </ul>\r\n\r\n</nav><!-- .nav-menu -->\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CrowdOrder.beta.Data.CategoryRepository repo { get; private set; }
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