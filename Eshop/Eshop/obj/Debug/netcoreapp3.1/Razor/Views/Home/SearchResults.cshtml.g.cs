#pragma checksum "C:\Users\Anh Nhat\Desktop\Testing\Eshop\Eshop\Views\Home\SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30da5da78c5f7c8f35f601b44f66d28d38d3014a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchResults), @"mvc.1.0.view", @"/Views/Home/SearchResults.cshtml")]
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
#line 1 "C:\Users\Anh Nhat\Desktop\Testing\Eshop\Eshop\Views\_ViewImports.cshtml"
using Eshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anh Nhat\Desktop\Testing\Eshop\Eshop\Views\_ViewImports.cshtml"
using Eshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30da5da78c5f7c8f35f601b44f66d28d38d3014a", @"/Views/Home/SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92eb553d877df711cd8c824ed0f9f03803fe6bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eshop.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-display", new global::Microsoft.AspNetCore.Html.HtmlString("Default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""product_area p_100"">
    <div class=""container"">
        <div class=""row product_inner_row"">
            <div class=""col-lg-9"">
                <div class=""row m0 product_task_bar"">
                    <div class=""product_task_inner"">
                        <div class=""float-left"">
                            <a class=""active"" href=""#""><i class=""fa fa-th-large"" aria-hidden=""true""></i></a>
                            <a href=""#""><i class=""fa fa-th-list"" aria-hidden=""true""></i></a>
                            <span>Showing 1 - 10 of 55 results</span>
                        </div>
                        <div class=""float-right"">
                            <h4>Sort by :</h4>
                            <select class=""short"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30da5da78c5f7c8f35f601b44f66d28d38d3014a5644", async() => {
                WriteLiteral("Default");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30da5da78c5f7c8f35f601b44f66d28d38d3014a6718", async() => {
                WriteLiteral("Default");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30da5da78c5f7c8f35f601b44f66d28d38d3014a7910", async() => {
                WriteLiteral("Default");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30da5da78c5f7c8f35f601b44f66d28d38d3014a9102", async() => {
                WriteLiteral("Default");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row product_item_inner\">\r\n");
#nullable restore
#line 31 "C:\Users\Anh Nhat\Desktop\Testing\Eshop\Eshop\Views\Home\SearchResults.cshtml"
                     foreach (var i in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-md-4 col-6\">\r\n                            <div class=\"cake_feature_item\">\r\n                                <div class=\"cake_img\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30da5da78c5f7c8f35f601b44f66d28d38d3014a10939", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1697, "~/img/cake-feature/", 1697, 19, true);
#nullable restore
#line 36 "C:\Users\Anh Nhat\Desktop\Testing\Eshop\Eshop\Views\Home\SearchResults.cshtml"
AddHtmlAttributeValue("", 1716, i.Image, 1716, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"cake_text\">\r\n                                    <h4>");
#nullable restore
#line 39 "C:\Users\Anh Nhat\Desktop\Testing\Eshop\Eshop\Views\Home\SearchResults.cshtml"
                                   Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <h3>");
#nullable restore
#line 40 "C:\Users\Anh Nhat\Desktop\Testing\Eshop\Eshop\Views\Home\SearchResults.cshtml"
                                   Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <a class=\"pest_btn\" href=\"#\">Add to cart</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 45 "C:\Users\Anh Nhat\Desktop\Testing\Eshop\Eshop\Views\Home\SearchResults.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""product_pagination"">
                    <div class=""left_btn"">
                        <a href=""#""><i class=""lnr lnr-arrow-left""></i> New posts</a>
                    </div>
                    <div class=""middle_list"">
                        <nav aria-label=""Page navigation example"">
                            <ul class=""pagination"">
                                <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                                <li class=""page-item active""><a class=""page-link"" href=""#"">2</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">...</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">12</a></li>
                            </ul>
                        </nav>
                    </div>
                    <div class=""right_b");
            WriteLiteral(@"tn""><a href=""#"">Older posts <i class=""lnr lnr-arrow-right""></i></a></div>
                </div>
            </div>
            <div class=""col-lg-3"">
                <div class=""product_left_sidebar"">
                    <aside class=""left_sidebar search_widget"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" placeholder=""Enter Search Keywords"">
                            <div class=""input-group-append"">
                                <button class=""btn"" type=""button""><i class=""icon icon-Search""></i></button>
                            </div>
                        </div>
                    </aside>
                    <aside class=""left_sidebar p_catgories_widget"">
                        <div class=""p_w_title"">
                            <h3>Product Categories</h3>
                        </div>
                        <ul class=""list_style"">
                            <li><a href=""#"">Cupcake (17)</a></li>
    ");
            WriteLiteral(@"                        <li><a href=""#"">Chocolate (15)</a></li>
                            <li><a href=""#"">Celebration (14)</a></li>
                            <li><a href=""#"">Wedding Cake (8)</a></li>
                            <li><a href=""#"">Desserts (11)</a></li>
                        </ul>
                    </aside>
                    <aside class=""left_sidebar p_price_widget"">
                        <div class=""p_w_title"">
                            <h3>Filter By Price</h3>
                        </div>
                        <div class=""filter_price"">
                            <div id=""slider-range""></div>
                            <label for=""amount"">Price range:</label>
                            <input type=""text"" id=""amount"" readonly />
                            <a href=""#"">Filter</a>
                        </div>
                    </aside>
                    <aside class=""left_sidebar p_sale_widget"">
                        <div class=""p_w_title"">
        ");
            WriteLiteral(@"                    <h3>Top Sale Products</h3>
                        </div>
                        <div class=""media"">
                            <div class=""d-flex"">
                                <img src=""img/product/sale-product/s-product-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5484, "\"", 5490, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""media-body"">
                                <a href=""#""><h4>Brown Cake</h4></a>
                                <ul class=""list_style"">
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                </ul>
                                <h5>$29</h5>
                            </div>
                        </div>
                        <div class=""media"">
                            <div class=""d-flex"">
                                <img src=""img/product/sale-product/s-product-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6496, "\"", 6502, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""media-body"">
                                <a href=""#""><h4>Brown Cake</h4></a>
                                <ul class=""list_style"">
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                </ul>
                                <h5>$29</h5>
                            </div>
                        </div>
                        <div class=""media"">
                            <div class=""d-flex"">
                                <img src=""img/product/sale-product/s-product-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7508, "\"", 7514, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""media-body"">
                                <a href=""#""><h4>Brown Cake</h4></a>
                                <ul class=""list_style"">
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                </ul>
                                <h5>$29</h5>
                            </div>
                        </div>
                        <div class=""media"">
                            <div class=""d-flex"">
                                <img src=""img/product/sale-product/s-product-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8520, "\"", 8526, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""media-body"">
                                <a href=""#""><h4>Brown Cake</h4></a>
                                <ul class=""list_style"">
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                </ul>
                                <h5>$29</h5>
                            </div>
                        </div>
                    </aside>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eshop.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
