#pragma checksum "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bbf8d146a87c173d298cbc2325d8fb0d8c5333a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutWhiteLabel), @"mvc.1.0.view", @"/Views/Shared/_LayoutWhiteLabel.cshtml")]
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
#line 1 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
using CrowdOrder.beta.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bbf8d146a87c173d298cbc2325d8fb0d8c5333a", @"/Views/Shared/_LayoutWhiteLabel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6826422b3abbdbbac0260d59355659aa0c6d4186", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutWhiteLabel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bbf8d146a87c173d298cbc2325d8fb0d8c5333a3767", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\">\r\n\r\n    <title>");
#nullable restore
#line 13 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Crowd Order</title>\r\n    ");
#nullable restore
#line 14 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
Write(RenderSection("metatags", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- Favicons -->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 577, "\"", 652, 1);
#nullable restore
#line 17 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 584, UrlRewriteService.FixUrl(Context.Request.Host.Value, "favicon.png"), 584, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"icon\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 676, "\"", 764, 1);
#nullable restore
#line 18 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 683, UrlRewriteService.FixUrl(Context.Request.Host.Value, "img/apple-touch-icon.png"), 683, 81, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" rel=""apple-touch-icon"">

    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Raleway:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i&display=swap"" rel=""stylesheet"">

    <!-- Vendor CSS Files -->
    <link");
                BeginWriteAttribute("href", " href=\"", 1103, "\"", 1205, 1);
#nullable restore
#line 24 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 1110, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/bootstrap/css/bootstrap.min.css"), 1110, 95, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1235, "\"", 1329, 1);
#nullable restore
#line 25 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 1242, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/icofont/icofont.min.css"), 1242, 87, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1359, "\"", 1459, 1);
#nullable restore
#line 26 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 1366, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/boxicons/css/boxicons.min.css"), 1366, 93, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1489, "\"", 1587, 1);
#nullable restore
#line 27 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 1496, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/animate.css/animate.min.css"), 1496, 91, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1617, "\"", 1711, 1);
#nullable restore
#line 28 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 1624, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/remixicon/remixicon.css"), 1624, 87, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1741, "\"", 1831, 1);
#nullable restore
#line 29 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 1748, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/venobox/venobox.css"), 1748, 83, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1861, "\"", 1972, 1);
#nullable restore
#line 30 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 1868, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/owl.carousel/assets/owl.carousel.min.css"), 1868, 104, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n");
#nullable restore
#line 31 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
     if (!SiteDataService.IsDev)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <!-- Global site tag (gtag.js) - Google Analytics -->
        <script async src=""https://www.googletagmanager.com/gtag/js?id=UA-178759178-1""></script>
        <script>
            window.dataLayer = window.dataLayer || [];
            function gtag() { dataLayer.push(arguments); }
            gtag('js', new Date());

            gtag('config', 'UA-178759178-1');
        </script>
");
#nullable restore
#line 42 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- Template Main CSS File -->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 2491, "\"", 2572, 1);
#nullable restore
#line 46 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 2498, UrlRewriteService.FixUrl(Context.Request.Host.Value, "css/siteWhite.css"), 2498, 74, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n        \r\n    ");
#nullable restore
#line 48 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
Write(RenderSection("head", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bbf8d146a87c173d298cbc2325d8fb0d8c5333a11898", async() => {
                WriteLiteral("   \r\n   \r\n    ");
#nullable restore
#line 52 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <a href=\"#\" class=\"back-to-top\"><i class=\"icofont-simple-up\"></i></a>\r\n\r\n    <!-- Vendor JS Files -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2802, "\"", 2892, 1);
#nullable restore
#line 57 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 2808, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/jquery/jquery.min.js"), 2808, 84, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2916, "\"", 3022, 1);
#nullable restore
#line 58 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 2922, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/bootstrap/js/bootstrap.bundle.min.js"), 2922, 100, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3046, "\"", 3150, 1);
#nullable restore
#line 59 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 3052, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/jquery.easing/jquery.easing.min.js"), 3052, 98, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3174, "\"", 3270, 1);
#nullable restore
#line 60 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 3180, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/php-email-form/validate.js"), 3180, 90, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3294, "\"", 3398, 1);
#nullable restore
#line 61 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 3300, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/isotope-layout/isotope.pkgd.min.js"), 3300, 98, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3422, "\"", 3514, 1);
#nullable restore
#line 62 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 3428, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/venobox/venobox.min.js"), 3428, 86, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3538, "\"", 3641, 1);
#nullable restore
#line 63 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 3544, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/waypoints/jquery.waypoints.min.js"), 3544, 97, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3665, "\"", 3767, 1);
#nullable restore
#line 64 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 3671, UrlRewriteService.FixUrl(Context.Request.Host.Value, "vendor/owl.carousel/owl.carousel.min.js"), 3671, 96, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <!-- Template Main JS File -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3829, "\"", 3902, 1);
#nullable restore
#line 67 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
WriteAttributeValue("", 3835, UrlRewriteService.FixUrl(Context.Request.Host.Value, "js/main.js"), 3835, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    ");
#nullable restore
#line 68 "C:\DEV\In Progress\Crowdorder\git\Develop\CrowdOrder.beta\Views\Shared\_LayoutWhiteLabel.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CrowdOrder.beta.Infrastructure.SiteDataService SiteDataService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CrowdOrder.beta.Data.CategoryRepository repo { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
