#pragma checksum "C:\Users\Elect\source\repos\MyEcommerce\Ecommercedemo\Areas\UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "168df4164ac8710731eae520908b16775bd0a599"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UI_Views_Home_Index), @"mvc.1.0.view", @"/Areas/UI/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Elect\source\repos\MyEcommerce\Ecommercedemo\Areas\UI\Views\_ViewImports.cshtml"
using AspnetcoreEcommercedemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elect\source\repos\MyEcommerce\Ecommercedemo\Areas\UI\Views\_ViewImports.cshtml"
using AspnetcoreEcommercedemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"168df4164ac8710731eae520908b16775bd0a599", @"/Areas/UI/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f654d11e57cf147dc1a2db3a508e59a157b3c74", @"/Areas/UI/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_UI_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/puma.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/1610306319-air-vapormax-plus-mens-shoe-w4xgr4-1610306273.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/adrenaline-gts-21-370x250.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/AO1696_061_P1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/run-asics-running-shoes-1636736175.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Elect\source\repos\MyEcommerce\Ecommercedemo\Areas\UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--  ======================= Start Main Area ================================ -->
<!-- Showcase Area -->
<section class=""section-a"">
    <div class=""container"">
        <div>
            <h1>Welcome To My Store</h1>
            <h3>New Clothes For Sale</h3>
            <p>
                Lorem ipsum dolor sit amet consectetur adipisicing elit.
                Doloribus sit eum impedit consequuntur dolores vitae assumenda consectetur
                architecto labore vel!
            </p>
            <a href=""#"" class=""btn button btn-warning mr-4 text-uppercase"">Shop Now</a>
        </div>
        <img src=""https://i.ibb.co/37Y74kv/showcase.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 717, "\"", 723, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    </div>
</section>

<!-- New Deals-->
<section id=""newDeals"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1 class=""heading""> <span>new arrivals</span> </h1>
            </div>
        </div>
");
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""owl-carousel owl-theme"">
                    <div class=""item"">
                        <div class=""product m-2"">
                            <div class=""product-header"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "168df4164ac8710731eae520908b16775bd0a5996768", async() => {
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
                                <ul class=""icons"">
                                    <span><i class=""bx bx-heart""></i></span>
                                    <a href=""/UI/Product/Cart"">
                                        <span><i class=""bx bx-shopping-bag""></i></span>
                                    </a>
                                    <span><i class=""bx bx-search""></i></span>
                                </ul>
                            </div>
                            <div class=""product-footer"">
                                <a href=""product-details.html"">
                                    <h5 class=""card-title"">T-shirts</h5>
                                </a>
                                <div class=""rating"">
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""");
            WriteLiteral(@"></i>
                                    <i class=""bx bx-star""></i>
                                </div>
                                <h4 class=""price"">$20.00</h4>
                                <a href=""/UI/Product"" class=""btn btn-primary"">Go to Product</a>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""product m-2"">
                            <div class=""product-header"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "168df4164ac8710731eae520908b16775bd0a5999439", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <ul class=""icons"">
                                    <span><i class=""bx bx-heart""></i></span>
                                    <a href=""/UI/Product/Cart"">
                                        <span><i class=""bx bx-shopping-bag""></i></span>
                                    </a>
                                    <span><i class=""bx bx-search""></i></span>
                                </ul>
                            </div>
                            <div class=""product-footer"">
                                <a href=""product-details.html"">
                                    <h5 class=""card-title"">Pants</h5>
                                </a>
                                <div class=""rating"">
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></");
            WriteLiteral(@"i>
                                    <i class=""bx bx-star""></i>
                                </div>
                                <h4 class=""price"">$35.00</h4>
                                <a href=""/UI/Product"" class=""btn btn-primary"">Go to Product</a>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""product m-2"">
                            <div class=""product-header"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "168df4164ac8710731eae520908b16775bd0a59912107", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <ul class=""icons"">
                                    <span><i class=""bx bx-heart""></i></span>
                                    <a href=""/UI/Product/Cart"">
                                        <span><i class=""bx bx-shopping-bag""></i></span>
                                    </a>
                                    <span><i class=""bx bx-search""></i></span>
                                </ul>
                            </div>
                            <div class=""product-footer"">
                                <a href=""product-details.html"">
                                    <h5 class=""card-title"">Pants</h5>
                                </a>
                                <div class=""rating"">
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></");
            WriteLiteral(@"i>
                                    <i class=""bx bx-star""></i>
                                </div>
                                <h4 class=""price"">$ 35.00</h4>
                                <a href=""/UI/Product"" class=""btn btn-primary"">Go to Product</a>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""product m-2"">
                            <div class=""product-header"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "168df4164ac8710731eae520908b16775bd0a59914777", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <ul class=""icons"">
                                    <span><i class=""bx bx-heart""></i></span>
                                    <a href=""/UI/Product/Cart"">
                                        <span><i class=""bx bx-shopping-bag""></i></span>
                                    </a>
                                    <span><i class=""bx bx-search""></i></span>
                                </ul>
                            </div>
                            <div class=""product-footer"">
                                <a href=""product-details.html"">
                                    <h5 class=""card-title"">Shoes</h5>
                                </a>
                                <div class=""rating"">
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></");
            WriteLiteral(@"i>
                                    <i class=""bx bx-star""></i>
                                </div>
                                <h4 class=""price"">$ 35.00</h4>
                                <a href=""/UI/Product"" class=""btn btn-primary"">Go to Product</a>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""product m-2"">
                            <div class=""product-header"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "168df4164ac8710731eae520908b16775bd0a59917447", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <ul class=""icons"">
                                    <span><i class=""bx bx-heart""></i></span>
                                    <a href=""/UI/Product/Cart"">
                                        <span><i class=""bx bx-shopping-bag""></i></span>
                                    </a>
                                    <span><i class=""bx bx-search""></i></span>
                                </ul>
                            </div>
                            <div class=""product-footer"">
                                <a href=""product-details.html"">
                                    <h5 class=""card-title"">Watches</h5>
                                </a>
                                <div class=""rating"">
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star""></i>
                                    <i class=""bx bxs-star"">");
            WriteLiteral(@"</i>
                                    <i class=""bx bx-star""></i>
                                </div>
                                <h4 class=""price"">$ 55.00</h4>
                                <a href=""/UI/Product"" class=""btn btn-primary"">Go to Product</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- Testimonials -->
<section class=""section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1 class=""heading""> <span>Testimonials</span> </h1>
            </div>
        </div>
    </div>
    <div class=""testimonial-center container pt-5"">
        <div class=""testimonial"">
            <span>&ldquo;</span>
            <p>
                Lorem ipsum dolor sit, amet consectetur adipisicing elit. Debitis,
                fugiat labore. Veritatis et omnis consequatur.
            </p>
     ");
            WriteLiteral(@"       <div class=""rating"">
                <i class=""bx bxs-star""></i>
                <i class=""bx bxs-star""></i>
                <i class=""bx bxs-star""></i>
                <i class=""bx bxs-star""></i>
                <i class=""bx bx-star""></i>
            </div>
            <div class=""img-cover"">
                <img src=""./images/profile1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10594, "\"", 10600, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>
            <h4>Will Smith</h4>
        </div>
        <div class=""testimonial"">
            <span>&ldquo;</span>
            <p>
                Lorem ipsum dolor sit, amet consectetur adipisicing elit. Debitis,
                fugiat labore. Veritatis et omnis consequatur.
            </p>
            <div class=""rating"">
                <i class=""bx bxs-star""></i>
                <i class=""bx bxs-star""></i>
                <i class=""bx bxs-star""></i>
                <i class=""bx bxs-star""></i>
                <i class=""bx bx-star""></i>
            </div>
            <div class=""img-cover"">
                <img src=""./images/profile2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11290, "\"", 11296, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>
            <h4>Will Smith</h4>
        </div>
        <div class=""testimonial"">
            <span>&ldquo;</span>
            <p>
                Lorem ipsum dolor sit, amet consectetur adipisicing elit. Debitis,
                fugiat labore. Veritatis et omnis consequatur.
            </p>
            <div class=""rating"">
                <i class=""bx bxs-star""></i>
                <i class=""bx bxs-star""></i>
                <i class=""bx bxs-star""></i>
                <i class=""bx bxs-star""></i>
                <i class=""bx bx-star""></i>
            </div>
            <div class=""img-cover"">
                <img src=""./images/profile3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11986, "\"", 11992, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>
            <h4>Will Smith</h4>
        </div>
    </div>
</section>

<!-- Brands -->
<section class=""section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1 class=""heading""> <span>Brands</span> </h1>
            </div>
        </div>
    </div>
    <div class=""brands-center container pt-5"">
        <div class=""brand"">
            <img src=""./images/brand1.png""");
            BeginWriteAttribute("alt", " alt=\"", 12461, "\"", 12467, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"brand\">\r\n            <img src=\"./images/brand2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 12560, "\"", 12566, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"brand\">\r\n            <img src=\"./images/brand1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 12659, "\"", 12665, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"brand\">\r\n            <img src=\"./images/brand2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 12758, "\"", 12764, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"brand\">\r\n            <img src=\"./images/brand1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 12857, "\"", 12863, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"brand\">\r\n            <img src=\"./images/brand2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 12956, "\"", 12962, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>
    </div>
</section>
<!-- cta area -->
<section class=""cta"">
    <div class=""cta-content"">
        <div class=""container"">
            <h2>Free Shipping With Your Order<br>Start Today</h2>
            <a href=""contact.html"" class=""btn btn-primary"">Lets Get Started</a>
        </div>
    </div>
</section>
<!-- Social Media Area -->
<section id=""social-contact"" class=""contact-area"">
    <div class=""container"">
        <h2>We<i class=""fa fa-heart""></i>New Friends!</h2>
        <ul class=""list-inline list-social social d-flex justify-content-center"">
            <li class=""social-twitter"">
                <a href=""#""><i class=""fa fa-twitter""></i></a>
            </li>
            <li class=""social-facebook"">
                <a href=""#""><i class=""fa fa-facebook""></i></a>
            </li>
            <li class=""social-google-plus"">
                <a href=""#""><i class=""fa fa-google-plus""></i></a>
            </li>
        </ul>
    </div>
</section>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
