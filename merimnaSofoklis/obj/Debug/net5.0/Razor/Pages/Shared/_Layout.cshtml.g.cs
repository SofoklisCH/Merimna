#pragma checksum "C:\Users\Sofoklis\source\repos\merimnaSofoklis\merimnaSofoklis\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a14ae15c5efd03fc3e0cfbf7de96bac23fc8100d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(merimnaSofoklis.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
namespace merimnaSofoklis.Pages.Shared
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
#line 1 "C:\Users\Sofoklis\source\repos\merimnaSofoklis\merimnaSofoklis\Pages\_ViewImports.cshtml"
using merimnaSofoklis;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a14ae15c5efd03fc3e0cfbf7de96bac23fc8100d", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d338659bb46b41db9f9ed12b50b5fcb5925cb1da", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/template/images/favicon.ico"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image/x-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/template/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/template/css/fonts.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/template/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/template/js/core.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/template/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\" >\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a14ae15c5efd03fc3e0cfbf7de96bac23fc8100d6524", async() => {
                WriteLiteral(@"

    <meta name=""format-detection"" content=""telephone=no"">
    <meta name=""viewport"" content=""width=device-width, height=device-height, initial-scale=1.0, maximum-scale=1.0, user-scalable=0"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta charset=""utf-8"">
    <title>");
#nullable restore
#line 9 "C:\Users\Sofoklis\source\repos\merimnaSofoklis\merimnaSofoklis\Pages\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - merimnaSofoklis</title>\r\n    <!-- Stylesheets-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a14ae15c5efd03fc3e0cfbf7de96bac23fc8100d7388", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"//fonts.googleapis.com/css?family=Montserrat:400,700%7COpen+Sans:300,400\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a14ae15c5efd03fc3e0cfbf7de96bac23fc8100d8787", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a14ae15c5efd03fc3e0cfbf7de96bac23fc8100d9966", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a14ae15c5efd03fc3e0cfbf7de96bac23fc8100d11145", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!--[if lt IE 10]>
    <div style=""background: #212121; padding: 10px 0; box-shadow: 3px 3px 5px 0 rgba(0,0,0,.3); clear: both; text-align:center; position: relative; z-index:1;""><a href=""http://windows.microsoft.com/en-US/internet-explorer/""><img src=""images/ie8-panel/warning_bar_0000_us.jpg"" border=""0"" height=""42"" width=""820"" alt=""You are using an outdated browser. For a faster, safer browsing experience, upgrade for free today.""></a></div>
    <script src=""js/html5shiv.min.js""></script>
        <![endif]-->
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a14ae15c5efd03fc3e0cfbf7de96bac23fc8100d13568", async() => {
                WriteLiteral(@"

    <div class=""page-loader"">
        <div>
            <div class=""page-loader-body"">
                <div class=""cssload-loader"">
                    <div class=""cssload-inner cssload-one""></div>
                    <div class=""cssload-inner cssload-two""></div>
                    <div class=""cssload-inner cssload-three""></div>
                </div>
            </div>
        </div>
    </div>

    <header class=""page-header"">
        <!-- RD Navbar-->
        <div class=""rd-navbar-wrap"">
            <nav class=""rd-navbar rd-navbar-transparent"" data-layout=""rd-navbar-fixed"" data-sm-layout=""rd-navbar-fixed"" data-md-layout=""rd-navbar-fixed"" data-md-device-layout=""rd-navbar-fullwidth"" data-lg-layout=""rd-navbar-static"" data-lg-device-layout=""rd-navbar-static"" data-xl-layout=""rd-navbar-static"" data-xl-device-layout=""rd-navbar-static"" data-sm-stick-up-offset=""1px"" data-md-stick-up-offset=""37px"" data-lg-stick-up-offset=""46px"" data-xxl-stick-up-offset=""1px"" data-md-stick-up=""true"" data-lg-stick-");
                WriteLiteral(@"up=""true"" data-xl-stick-up=""true"">
                <div class=""rd-navbar-outer outer-transparent"">
                    <div class=""rd-navbar-panel"">
                        <!-- RD Navbar Toggle-->
                        <button class=""rd-navbar-toggle"" data-rd-navbar-toggle="".rd-navbar-inner""><span class=""toggle-icon""></span></button>
                        <!-- RD Navbar Brand--><a class=""rd-navbar-brand"" href=""./""><img class=""brand-mini"" src=""images/brand.png"" width=""138"" height=""18""");
                BeginWriteAttribute("alt", " alt=\"", 2861, "\"", 2867, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                    </div>
                    <div class=""rd-navbar-inner"">
                        <!-- RD Navbar Panel-->
                        <div class=""rd-navbar-cell rd-navbar-brand-wrap"">
                            <!-- RD Navbar Brand--><a class=""rd-navbar-brand"" href=""./""><img class=""brand-normal"" src=""images/brand.png"" width=""138"" height=""18""");
                BeginWriteAttribute("alt", " alt=\"", 3238, "\"", 3244, 0);
                EndWriteAttribute();
                WriteLiteral(@"><span class=""brand-slogan"">?????????????? ???????????????????????? ?????? ??????????????</span></a>
                        </div>
                        <!-- RD Navbar Nav-->
                        <div class=""rd-navbar-cell rd-navbar-nav-wrap"">
                            <!-- RD Navbar Nav-->
                            <ul class=""rd-navbar-nav rd-navbar-nav-default"">
                                <li class=""active"">
                                    <a href=""./"">Home</a>
                                    <!-- RD Navbar Megamenu-->
                                    <ul class=""rd-navbar-megamenu"">
                                        <li>
                                            <p class=""rd-megamenu-header"">Health and Wellness</p>
                                            <ul class=""rd-megamenu-list"">
                                                <li><a href=""health-services.html"">Health Services</a></li>
                                                <li><a href=""prevention-support.html"">Prevention");
                WriteLiteral(@" and On Campus Support</a></li>
                                                <li><a href=""wellness-courses.html"">Wellness Courses</a></li>
                                            </ul>
                                            <p class=""rd-megamenu-header"">News</p>
                                            <ul class=""rd-megamenu-list"">
                                                <li><a href=""post-page.html"">Post page</a></li>
                                            </ul>
                                        </li>
                                        <li>
                                            <p class=""rd-megamenu-header"">Elements</p>
                                            <ul class=""rd-megamenu-list"">
                                                <li><a href=""typography.html"">Typography</a></li>
                                                <li><a href=""tabs-and-accordions.html"">Tabs & Accordions</a></li>
                                                <li>");
                WriteLiteral(@"<a href=""progress-bars.html"">Progress bars</a></li>
                                                <li><a href=""tables.html"">Tables</a></li>
                                                <li><a href=""forms.html"">Forms</a></li>
                                                <li><a href=""buttons.html"">Buttons</a></li>
                                                <li><a href=""grid.html"">Grid</a></li>
                                            </ul>
                                        </li>
                                        <li>
                                            <p class=""rd-megamenu-header"">Sports</p>
                                            <ul class=""rd-megamenu-list"">
                                                <li><a href=""competitions.html"">Competitions</a></li>
                                                <li><a href=""sports-leaders.html"">Sports Leaders</a></li>
                                                <li><a href=""sports-teams.html"">Sports Teams</a>");
                WriteLiteral(@"</li>
                                            </ul>
                                            <p class=""rd-megamenu-header"">Layouts</p>
                                            <ul class=""rd-megamenu-list"">
                                                <li><a href=""home-light.html"">Home Light</a></li>
                                                <li><a href=""home-sidebar.html"">Home Sidebar</a></li>
                                            </ul>
                                        </li>
                                        <li>
                                            <p class=""rd-megamenu-header"">Pages</p>
                                            <ul class=""rd-megamenu-list"">
                                                <li><a href=""404.html"">404</a></li>
                                                <li><a href=""503.html"">503</a></li>
                                                <li><a href=""maintenance.html"">Maintenance (Under Construction)</a></li>
      ");
                WriteLiteral(@"                                          <li><a href=""coming-soon.html"">Coming soon</a></li>
                                                <li><a href=""site-map.html"">Site Map</a></li>
                                                <li><a href=""privacy-policy.html"">Privacy Policy</a></li>
                                                <li><a href=""terms-of-use.html"">Terms of Use</a></li>
                                            </ul>
                                        </li>
                                    </ul>
                                </li>
                                <li><a href=""about.html"">About</a></li>
                                <li>
                                    <a href=""events.html"">Events</a>
                                    <!-- RD Navbar Dropdown-->
                                    <ul class=""rd-navbar-dropdown"">
                                        <li><a href=""event-page.html"">Event page</a></li>
                                    </u");
                WriteLiteral(@"l>
                                </li>
                                <li><a href=""clubs.html"">Clubs</a></li>
                                <li>
                                    <a href=""#"">Health & Wellness</a>
                                    <!-- RD Navbar Dropdown-->
                                    <ul class=""rd-navbar-dropdown"">
                                        <li><a href=""health-services.html"">Health services</a></li>
                                        <li>
                                            <a href=""prevention-support.html"">Prevention and On Campus Support</a>
                                            <!-- RD Navbar Dropdown-->
                                            <ul class=""rd-navbar-dropdown"">
                                                <li><a href=""#"">Student center</a></li>
                                                <li><a href=""#"">Psychological services</a></li>
                                                <li><a href=""#"">Coun");
                WriteLiteral(@"seling</a></li>
                                            </ul>
                                        </li>
                                        <li><a href=""wellness-courses.html"">Wellness courses</a></li>
                                    </ul>
                                </li>
                                <li>
                                    <a href=""#"">Services</a>
                                    <!-- RD Navbar Dropdown-->
                                    <ul class=""rd-navbar-dropdown"">
                                        <li><a href=""housing.html"">Housing</a></li>
                                        <li><a href=""vending.html"">Vending</a></li>
                                    </ul>
                                </li>
                                <li><a href=""volunteering.html"">Volunteering</a></li>
                                <li>
                                    <a href=""#"">Sports</a>
                                    <!-- RD Navbar Dro");
                WriteLiteral(@"pdown-->
                                    <ul class=""rd-navbar-dropdown"">
                                        <li><a href=""competitions.html"">Competitions</a></li>
                                        <li><a href=""sports-leaders.html"">Sports leaders</a></li>
                                        <li><a href=""sports-teams.html"">Sports Teams</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                        <!-- RD Navbar Panel Right-->
                        <div class=""rd-navbar-cell rd-navbar-panel-right"">
                            <!-- RD Navbar Nav-->
                            <ul class=""rd-navbar-nav rd-navbar-nav-right"">
                                <li><a href=""student-help.html"">Student help</a></li>
                                <li><a href=""news.html"">News</a></li>
                                <li><a href=""contact-us.html"">Contact us</a></li>
        ");
                WriteLiteral("                    </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </nav>\r\n        </div>\r\n    </header>\r\n\r\n\r\n\r\n    <!-- sofoklis - - Body - - page Begin -->\r\n\r\n\r\n            ");
#nullable restore
#line 175 "C:\Users\Sofoklis\source\repos\merimnaSofoklis\merimnaSofoklis\Pages\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- sofoklis - - Body - - page End -->\r\n\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a14ae15c5efd03fc3e0cfbf7de96bac23fc8100d25324", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a14ae15c5efd03fc3e0cfbf7de96bac23fc8100d26424", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 184 "C:\Users\Sofoklis\source\repos\merimnaSofoklis\merimnaSofoklis\Pages\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

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
