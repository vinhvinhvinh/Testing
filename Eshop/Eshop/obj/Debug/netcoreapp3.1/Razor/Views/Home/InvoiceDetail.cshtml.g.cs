#pragma checksum "D:\GIT\Testing\Eshop\Eshop\Views\Home\InvoiceDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80ace193030f0d431fd4ea7352cb1a1e57ecc7d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InvoiceDetail), @"mvc.1.0.view", @"/Views/Home/InvoiceDetail.cshtml")]
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
#line 1 "D:\GIT\Testing\Eshop\Eshop\Views\_ViewImports.cshtml"
using Eshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GIT\Testing\Eshop\Eshop\Views\_ViewImports.cshtml"
using Eshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ace193030f0d431fd4ea7352cb1a1e57ecc7d1", @"/Views/Home/InvoiceDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92eb553d877df711cd8c824ed0f9f03803fe6bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InvoiceDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/client/client-2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/client/client-1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80ace193030f0d431fd4ea7352cb1a1e57ecc7d14415", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <link rel=""icon"" href=""img/fav-icon.png"" type=""image/x-icon"" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Cake - Bakery</title>

    <!-- Icon css link -->
    <link href=""css/font-awesome.min.css"" rel=""stylesheet"">
    <link href=""vendors/linearicons/style.css"" rel=""stylesheet"">
    <link href=""vendors/flat-icon/flaticon.css"" rel=""stylesheet"">
    <link href=""vendors/stroke-icon/style.css"" rel=""stylesheet"">
    <!-- Bootstrap -->
    <link href=""css/bootstrap.min.css"" rel=""stylesheet"">

    <!-- Rev slider css -->
    <link href=""vendors/revolution/css/settings.css"" rel=""stylesheet"">
    <link href=""vendors/revolution/css/layers.css"" rel=""stylesheet"">
    <link href=""vendors/revolution/css/navigation.css"" rel=""stylesheet"">
    <link href=""vendors/animate-css/ani");
                WriteLiteral(@"mate.css"" rel=""stylesheet"">

    <!-- Extra plugin css -->
    <link href=""vendors/owl-carousel/owl.carousel.min.css"" rel=""stylesheet"">
    <link href=""vendors/magnifc-popup/magnific-popup.css"" rel=""stylesheet"">

    <link href=""css/style.css"" rel=""stylesheet"">
    <link href=""css/responsive.css"" rel=""stylesheet"">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
    <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80ace193030f0d431fd4ea7352cb1a1e57ecc7d17198", async() => {
                WriteLiteral(@"

    <!--================Main Header Area =================-->
    <header class=""main_header_area"">
        <div class=""top_header_area row m0"">
            <div class=""container"">
                <div class=""float-left"">
                    <a href=""tell:+18004567890""><i class=""fa fa-phone"" aria-hidden=""true""></i> + (1800) 456 7890</a>
                    <a href=""mainto:info@cakebakery.com""><i class=""fa fa-envelope-o"" aria-hidden=""true""></i> info@cakebakery.com</a>
                </div>
                <div class=""float-right"">
                    <ul class=""h_social list_style"">
                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-linkedin""></i></a></li>
                    </ul>
                    <ul class=""h_search list_style"">
                        <li cla");
                WriteLiteral(@"ss=""shop_cart""><a href=""#""><i class=""lnr lnr-cart""></i></a></li>
                        <li><a class=""popup-with-zoom-anim"" href=""#test-search""><i class=""fa fa-search""></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""main_menu_area"">
            <div class=""container"">
                <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
                    <a class=""navbar-brand"" href=""index.html"">
                        <img src=""img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 3317, "\"", 3323, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                        <img src=\"img/logo-2.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3375, "\"", 3381, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""my_toggle_menu"">
                            <span></span>
                            <span></span>
                            <span></span>
                        </span>
                    </button>
                    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                        <ul class=""navbar-nav mr-auto"">
                            <li class=""dropdown submenu"">
                                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Home</a>
                                <ul class=""dropdown-menu"">
                                    <li><a href=""index.html"">Home 1</a></li>
                                    <li><a");
                WriteLiteral(@" href=""index-2.html"">Home 2</a></li>
                                    <li><a href=""index-3.html"">Home 3</a></li>
                                    <li><a href=""index-4.html"">Home 4</a></li>
                                    <li><a href=""index-5.html"">Home 5</a></li>
                                </ul>
                            </li>
                            <li><a href=""cake.html"">Our Cakes</a></li>
                            <li><a href=""menu.html"">Menu</a></li>
                            <li class=""dropdown submenu"">
                                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">About Us</a>
                                <ul class=""dropdown-menu"">
                                    <li><a href=""about-us.html"">About Us</a></li>
                                    <li><a href=""our-team.html"">Our Chefs</a></li>
                                    
                                </ul>
                       ");
                WriteLiteral(@"     </li>
                        </ul>
                        <ul class=""navbar-nav justify-content-end"">
                            <li class=""dropdown submenu"">
                                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Pages</a>
                                <ul class=""dropdown-menu"">
                                    <li><a href=""service.html"">Services</a></li>
                                    <li class=""dropdown submenu"">
                                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Gallery</a>
                                        <ul class=""dropdown-menu"">
                                            <li><a href=""portfolio.html"">-  Gallery Classic</a></li>
                                            <li><a href=""portfolio-full-width.html"">-  Gallery Full width</a></li>
                                        </");
                WriteLiteral(@"ul>
                                    </li>
                                    <li><a href=""faq.html"">Faq</a></li>
                                    <li><a href=""what-we-make.html"">What we make</a></li>
                                    <li><a href=""special.html"">Special Recipe</a></li>
                                    <li><a href=""404.html"">404 page</a></li>
                                    <li><a href=""comming-soon.html"">Coming Soon page</a></li>
                                </ul>
                            </li>
                            <li class=""dropdown submenu"">
                                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Blog</a>
                                <ul class=""dropdown-menu"">
                                    <li><a href=""blog.html"">Blog with sidebar</a></li>
                                    <li><a href=""blog-2column.html"">Blog 2 column</a></li>
                                  ");
                WriteLiteral(@"  <li><a href=""single-blog.html"">Blog details</a></li>
                                </ul>
                            </li>
                            <li class=""dropdown submenu active"">
                             
                                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Shop</a>
                                <ul class=""dropdown-menu"">
                                    <li><a href=""shop.html"">Main shop</a></li>
                                    <li><a href=""product-details.html"">Product Details</a></li>
                                    <li><a href=""cart.html"">Cart Page</a></li>
                                    <li><a href=""checkout.html"">Checkout Page</a></li>
                                    <li><a href=""testimonials.html"">Invoice History</a></li>
                                </ul>
                            </li>
                            <li><a href=""contact.html"">Contact Us</a></li>
     ");
                WriteLiteral(@"                   </ul>
                    </div>
                </nav>
            </div>
        </div>
    </header>
    <!--================End Main Header Area =================-->
    <!--================End Main Header Area =================-->
    <section class=""banner_area"">
        <div class=""container"">
            <div class=""banner_text"">
                <h3>Invoice History</h3>
                <ul>
                    <li><a href=""index.html"">Home</a></li>
                    <li><a href=""service.html"">Invoice History</a></li>
                </ul>
            </div>
        </div>
    </section>
    <!--================End Main Header Area =================-->
    <!--================Testimonials item Area =================-->
    <section class=""testimonials_item_area p_100"">
        <div class=""container"">
            <div class=""testi_item_inner"">
                <div class=""media"">
                    <div class=""d-flex"">
                        <img src=""~img/client/client-1.png""");
                BeginWriteAttribute("alt", " alt=\"", 9521, "\"", 9527, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <h3>“</h3>
                    </div>
                    <div class=""media-body"">
                        <p>Osed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci sed quia non numquam qui ratione voluptatem sequi nesciunt. Neque porro quisquam est.</p>
                        <h5>- Robert joe</h5>
                    </div>
                </div>
                <div class=""media"">
                    <div class=""d-flex"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "80ace193030f0d431fd4ea7352cb1a1e57ecc7d116719", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <h3>“</h3>
                    </div>
                    <a href=""D:\GIT\Testing\Eshop\Eshop\Views\Home\InvoiceDetail.cshtml"">D:\GIT\Testing\Eshop\Eshop\Views\Home\InvoiceDetail.cshtml</a>
                    <div class=""media-body"">
                        <p>Osed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci sed quia non numquam qui ratione voluptatem sequi nesciunt. Neque porro quisquam est.</p>
                        <h5>- Robert joe</h5>
                    </div>
                </div>
                <div class=""media"">
                    <div class=""d-flex"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "80ace193030f0d431fd4ea7352cb1a1e57ecc7d118640", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <h3>“</h3>
                    </div>
                    <div class=""media-body"">
                        <p>Osed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci sed quia non numquam qui ratione voluptatem sequi nesciunt. Neque porro quisquam est.</p>
                        <h5>- Robert joe</h5>
                    </div>
                </div>
                <div class=""media"">
                    <div class=""d-flex"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "80ace193030f0d431fd4ea7352cb1a1e57ecc7d120407", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <h3>“</h3>
                    </div>
                    <div class=""media-body"">
                        <p>Osed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci sed quia non numquam qui ratione voluptatem sequi nesciunt. Neque porro quisquam est.</p>
                        <h5>- Robert joe</h5>
                    </div>
                </div>
                <div class=""media"">
                    <div class=""d-flex"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "80ace193030f0d431fd4ea7352cb1a1e57ecc7d122174", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <h3>“</h3>
                    </div>
                    <div class=""media-body"">
                        <p>Osed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci sed quia non numquam qui ratione voluptatem sequi nesciunt. Neque porro quisquam est.</p>
                        <h5>- Robert joe</h5>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================End Testimonials item Area =================-->
    <!--================Newsletter Area =================-->
    <section class=""newsletter_area"">
        <div class=""container"">
            <div class=""row newsletter_inner"">
                <div class=""col-lg-6"">
                    <div class=""news_left_text"">
                        <h4>Join our Newsletter list to get all the latest offers, discounts and other benefits</h4>
                    </div>
     ");
                WriteLiteral(@"           </div>
                <div class=""col-lg-6"">
                    <div class=""newsletter_form"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" placeholder=""Enter your email address"">
                            <div class=""input-group-append"">
                                <button class=""btn btn-outline-secondary"" type=""button"">Subscribe Now</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================End Newsletter Area =================-->
    <!--================Footer Area =================-->
    <footer class=""footer_area"">
        <div class=""footer_widgets"">
            <div class=""container"">
                <div class=""row footer_wd_inner"">
                    <div class=""col-lg-3 col-6"">
                        <aside class=""f_widget f_about_widget"">
                            <im");
                WriteLiteral("g src=\"img/footer-logo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 14288, "\"", 14294, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui bland itiis praesentium voluptatum deleniti atque corrupti.</p>
                            <ul class=""nav"">
                                <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-linkedin""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                            </ul>
                        </aside>
                    </div>
                    <div class=""col-lg-3 col-6"">
                        <aside class=""f_widget f_link_widget"">
                            <div class=""f_title"">
                                <h3>Quick links</h3>
                            </div>
                            <ul class=""list_style"">
                                <li><a href=""#"">Your Account</a></li>");
                WriteLiteral(@"
                                <li><a href=""#"">View Order</a></li>
                                <li><a href=""#"">Privacy Policy</a></li>
                                <li><a href=""#"">Terms & Conditionis</a></li>
                            </ul>
                        </aside>
                    </div>
                    <div class=""col-lg-3 col-6"">
                        <aside class=""f_widget f_link_widget"">
                            <div class=""f_title"">
                                <h3>Work Times</h3>
                            </div>
                            <ul class=""list_style"">
                                <li><a href=""#"">Mon. :  Fri.: 8 am - 8 pm</a></li>
                                <li><a href=""#"">Sat. : 9am - 4pm</a></li>
                                <li><a href=""#"">Sun. : Closed</a></li>
                            </ul>
                        </aside>
                    </div>
                    <div class=""col-lg-3 col-6"">
                        <aside class=""f_");
                WriteLiteral(@"widget f_contact_widget"">
                            <div class=""f_title"">
                                <h3>Contact Info</h3>
                            </div>
                            <h4>(1800) 574 9687</h4>
                            <p>Justshiop Store <br />256, baker Street,, New Youk, 5245</p>
                            <h5>cakebakery@contact.co.in</h5>
                        </aside>
                    </div>
                </div>
            </div>
        </div>
        <div class=""footer_copyright"">
            <div class=""container"">
                <div class=""copyright_inner"">
                    <div class=""float-left"">
                        <h5><a target=""_blank"" href=""https://www.templatespoint.net"">Templates Point</a></h5>
                    </div>
                    <div class=""float-right"">
                        <a href=""#"">Purchase Now</a>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!--================End Footer ");
                WriteLiteral(@"Area =================-->
    <!--================Search Box Area =================-->
    <div class=""search_area zoom-anim-dialog mfp-hide"" id=""test-search"">
        <div class=""search_box_inner"">
            <h3>Search</h3>
            <div class=""input-group"">
                <input type=""text"" class=""form-control"" placeholder=""Search for..."">
                <span class=""input-group-btn"">
                    <button class=""btn btn-default"" type=""button""><i class=""icon icon-Search""></i></button>
                </span>
            </div>
        </div>
    </div>
    <!--================End Search Box Area =================-->
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src=""js/jquery-3.2.1.min.js""></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src=""js/popper.min.js""></script>
    <script src=""js/bootstrap.min.js""></script>
    <!-- Rev slider js -->
    <script src=""vendors/revolution/js/jquery.themepunch.t");
                WriteLiteral(@"ools.min.js""></script>
    <script src=""vendors/revolution/js/jquery.themepunch.revolution.min.js""></script>
    <script src=""vendors/revolution/js/extensions/revolution.extension.actions.min.js""></script>
    <script src=""vendors/revolution/js/extensions/revolution.extension.video.min.js""></script>
    <script src=""vendors/revolution/js/extensions/revolution.extension.slideanims.min.js""></script>
    <script src=""vendors/revolution/js/extensions/revolution.extension.layeranimation.min.js""></script>
    <script src=""vendors/revolution/js/extensions/revolution.extension.navigation.min.js""></script>
    <!-- Extra plugin js -->
    <script src=""vendors/owl-carousel/owl.carousel.min.js""></script>
    <script src=""vendors/magnifc-popup/jquery.magnific-popup.min.js""></script>
    <script src=""vendors/isotope/imagesloaded.pkgd.min.js""></script>
    <script src=""vendors/isotope/isotope.pkgd.min.js""></script>
    <script src=""vendors/datetime-picker/js/moment.min.js""></script>
    <script src=""vendors/datetime-picker");
                WriteLiteral("/js/bootstrap-datetimepicker.min.js\"></script>\n    <script src=\"vendors/nice-select/js/jquery.nice-select.min.js\"></script>\n    <script src=\"vendors/lightbox/simpleLightbox.min.js\"></script>\n\n    <script src=\"js/theme.js\"></script>\n");
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
            WriteLiteral("\n\n</html>");
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
