#pragma checksum "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "782c1ff996b1b5571440e9d82e1f3d0c596ff5d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\_ViewImports.cshtml"
using influencer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\_ViewImports.cshtml"
using influencer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\_ViewImports.cshtml"
using influencer.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
using Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"782c1ff996b1b5571440e9d82e1f3d0c596ff5d5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ec4bacb01a5bb612ddd011ccd1444fb9e603cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.Entities.UserArticle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-gallery", new global::Microsoft.AspNetCore.Html.HtmlString("portfolioGallery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("portfolio-lightbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = Localizer["HomePage"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- ======= Hero Section ======= -->
<div id=""carouselExampleCaptions"" class=""carousel"" data-bs-ride=""carousel"">
    <div class=""carousel-indicators"">
        <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""0"" class=""active"" aria-current=""true"" aria-label=""Slide 1""></button>
        <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
        <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button>
    </div>
    <div class=""carousel-inner"">
        <section id=""hero"" class=""align-items-center carousel-item active"">

            <div class=""container padtop-60"" data-aos=""zoom-out"" data-aos-delay=""100"">
                <div class=""row"">
                    <div class=""col-xl-7"">
                        <h1>Creative influencer marketplace to meet your brand's content needs</h1>
                        <h2>
                            Brands n");
            WriteLiteral(@"eed to bridge the gap between themselves and customers
                            We are that bridge linking Brands
                        </h2>
                        <a href=""#about"" class=""btn-get-started scrollto"">Get Started</a>
                    </div>
                </div>
            </div>

        </section>
        <section id=""hero2"" class=""carousel-item"">

            <div class=""container padtop-60"" data-aos=""fade-right"" data-aos-delay=""200"">
                <div class=""row"">
                    <div class=""col-xl-7"">
                        <h1>Creative influencer marketplace to meet your brand's content needs</h1>
                        <h2>
                            Brands need to bridge the gap between themselves and customers
                            We are that bridge linking Brands
                        </h2>
                        <a href=""#about"" class=""btn-get-started scrollto"">Get Started</a>
                    </div>
                </div>
      ");
            WriteLiteral(@"      </div>

        </section>
        <section id=""hero3"" class=""align-items-center carousel-item"">
            <div class=""container padtop-60"" data-aos=""fade-right"" data-aos-delay=""200"">
                <div class=""row"">
                    <div class=""col-xl-7"">
                        <h1>Creative influencer marketplace to meet your brand's content needs</h1>
                        <h2>
                            Brands need to bridge the gap between themselves and customers
                            We are that bridge linking Brands
                        </h2>
                        <a href=""#about"" class=""btn-get-started scrollto"">Get Started</a>
                    </div>
                </div>
            </div>
        </section>
    </div>
    <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""visually-hidden"">");
            WriteLiteral(@"Previous</span>
    </button>
    <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""visually-hidden"">Next</span>
    </button>
</div>
<!-- End Hero -->
<main id=""main"">
    <section id=""Article"" class=""faq"">
        <div class=""container"" data-aos=""fade-up"">
");
#nullable restore
#line 75 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
             if (Model.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
                 foreach (var article in Model)
                {
                    if (article.Categories == 3)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <section id=\"creator\" class=\"portfolio\">\r\n                                <div class=\"container\" data-aos=\"fade-up\">\r\n                                    ");
#nullable restore
#line 84 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
                               Write(Html.Raw(@article.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"row portfolio-container\" data-aos=\"fade-right\" data-aos-delay=\"200\" style=\"position: relative; height: 855px;\">\r\n");
#nullable restore
#line 86 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
                                         foreach (Advertise advertise in ViewBag.ListAdv)
                                        {
                                            var cat = "";
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
                                             switch (@advertise.Categories)
                                            {
                                                case 1:
                                                    {
                                                        cat = "ladies";
                                                        break;
                                                    }
                                                case 2:
                                                    {
                                                        cat = "health";
                                                        break;
                                                    }
                                                case 3:
                                                    {
                                                        cat = "fact";
                                                        break;
                                                    }
                                                case 4:
                                                    {
                                                        cat = "successAndMotivation";
                                                        break;
                                                    }
                                                case 5:
                                                    {
                                                        cat = "sports";
                                                        break;
                                                    }
                                                case 6:
                                                    {
                                                        cat = "artandMusic";
                                                        break;
                                                    }
                                                case 7:
                                                    {
                                                        cat = "lifestyle";
                                                        break;
                                                    }
                                                case 8:
                                                    {
                                                        cat = "foods";
                                                        break;
                                                    }
                                                case 9:
                                                    {
                                                        cat = "funny";
                                                        break;
                                                    }
                                                case 10:
                                                    {
                                                        cat = "teaching";
                                                        break;
                                                    }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div");
            BeginWriteAttribute("class", " class=\"", 7737, "\"", 7789, 5);
            WriteAttributeValue("", 7745, "col-lg-4", 7745, 8, true);
            WriteAttributeValue(" ", 7753, "col-md-6", 7754, 9, true);
            WriteAttributeValue(" ", 7762, "portfolio-item", 7763, 15, true);
            WriteAttributeValue(" ", 7777, "filter-", 7778, 8, true);
#nullable restore
#line 142 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
WriteAttributeValue("", 7785, cat, 7785, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"portfolio-wrap\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "782c1ff996b1b5571440e9d82e1f3d0c596ff5d515465", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7933, "~/Uploads/", 7933, 10, true);
#nullable restore
#line 144 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7943, advertise.AdvPicture, 7943, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    <div class=\"portfolio-info\">\r\n                                                        <h4>");
#nullable restore
#line 146 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
                                                       Write(advertise.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                                        <p>\r\n                                                            ");
#nullable restore
#line 148 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
                                                       Write(cat);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </p>\r\n                                                        <div class=\"portfolio-links\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "782c1ff996b1b5571440e9d82e1f3d0c596ff5d518180", async() => {
                WriteLiteral("\r\n                                                                <i class=\"bx bx-plus\"></i>\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8503, "~/Uploads/", 8503, 10, true);
#nullable restore
#line 151 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 8513, advertise.AdvPicture, 8513, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 151 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 8602, advertise.Title, 8602, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<a href=""portfolio-details.html"" title=""More Details"">
                                                                <i class=""bx bx-link""></i>
                                                            </a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
");
#nullable restore
#line 160 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </section>\r\n                        </div>\r\n");
#nullable restore
#line 165 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            ");
#nullable restore
#line 172 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
                       Write(Html.Raw(@article.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 174 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 175 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </section><!-- End Frequently Asked Questions Section -->\r\n</main><!-- End #main -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            $(\".editable\").removeClass(\"editable\");\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Domain.Entities.UserArticle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
