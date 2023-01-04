#pragma checksum "C:\Users\Elect\source\repos\MyEcommerce\Ecommercedemo\Areas\UI\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2077a0fb1b3137f82cf884c36b53974c74b00566"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UI_Views_Blog_Index), @"mvc.1.0.view", @"/Areas/UI/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2077a0fb1b3137f82cf884c36b53974c74b00566", @"/Areas/UI/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f654d11e57cf147dc1a2db3a508e59a157b3c74", @"/Areas/UI/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_UI_Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/blogList.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Elect\source\repos\MyEcommerce\Ecommercedemo\Areas\UI\Views\Blog\Index.cshtml"
  
    ViewBag.Title = "Blog Website";
    ViewBag.Description = "This Blog Has Everything";
    ViewBag.Keywords = "Blog programing travel photography";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    /*  */
    .notFound {
        grid-template-columns: 1fr !important;
        color: var(--tenne-tawny);
        font-size: 1.8rem;
        font-weight: 600;
        width: 100%;
    }
</style>

<section class=""page-hero"">
    <div class=""section-center"">
        <h3 class=""page-hero-title"">Home / MyBlog</h3>
    </div>
</section>
<div class=""container-fluid"">
    <!-- page hero -->
    <div class=""row"">
        <!-- Sidebar Widgets Column -->
        <div class=""col-md-3"">
            <!-- Categories Widget -->
            <div class=""card my-3"">
                <h5 class=""card-header"">Search</h5>
                <div class=""card-body"">
                    <div class=""input-group"" id=""searchWrapper"">
                        <input type=""text"" class=""form-control""
                               name=""searchBar""
                               id=""searchBar""
                               placeholder=""Search for..."">
                    </div>
                </div>
 ");
            WriteLiteral(@"               <h5 class=""card-header"">Categories</h5>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <button type=""button"" class=""btn btn-primary filter-btn"" data-id=""all"">
                                All
                            </button>
                            <button type=""button"" class=""btn btn-success filter-btn"" data-id=""news"">
                                News
                            </button>
                            <button type=""button"" class=""btn btn-success filter-btn"" data-id=""technology"">
                                Technology
                            </button>
                            <button type=""button"" class=""btn btn-success filter-btn"" data-id=""music"">
                                Music
                            </button>
                            <button type=""button"" class=""btn btn-success filter-btn"" data-id=""sports"">
        ");
            WriteLiteral(@"                        Sports
                            </button>
                            <button type=""button"" class=""btn btn-success btn-rounded filter-btn"" data-id=""movies"">
                                Movies
                            </button>
                            <button type=""button"" class=""btn btn-success btn-rounded filter-btn"" data-id=""places"">
                                Places
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Blog Entries Column -->
        <div class=""my-4 col-md-6"">
            <!-- Blog Post -->
            <div id=""card""></div>
            <div id=""btn-container""></div>
        </div>
        <!-- /.row -->
    </div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2077a0fb1b3137f82cf884c36b53974c74b005667077", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
