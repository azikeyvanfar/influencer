#pragma checksum "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a5f484394444018991d86d1574a1c16b59e3012"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advertise_Details), @"mvc.1.0.view", @"/Views/Advertise/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a5f484394444018991d86d1574a1c16b59e3012", @"/Views/Advertise/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ec4bacb01a5bb612ddd011ccd1444fb9e603cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Advertise_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Entities.Advertise>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <main role=\"main\" class=\"pb-3\">\r\n        <h1>Details Advertise</h1>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 13 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 19 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Categories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 23 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
                 switch (Model.Categories)
                {
                    case 1:
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Ladies</p>\r\n");
#nullable restore
#line 28 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
                            break;
                        }
                    case 2:
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Health</p>\r\n");
#nullable restore
#line 33 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"

                            break;
                        }
                    case 3:
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Fact</p>\r\n");
#nullable restore
#line 39 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
                            break;
                        }
                    case 4:
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Success And Motivation</p>\r\n");
#nullable restore
#line 44 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
                            break;
                        }
                    case 5:
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Sports</p>\r\n");
#nullable restore
#line 49 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
                            break;
                        }
                    case 6:
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Art and Music</p>\r\n");
#nullable restore
#line 54 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
                            break;
                        }
                    case 7:
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Lifestyle</p>\r\n");
#nullable restore
#line 59 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
                            break;
                        }
                    case 8:
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Foods</p>\r\n");
#nullable restore
#line 64 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
                            break;
                        }
                    case 9:
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Funny</p>\r\n");
#nullable restore
#line 69 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
                            break;
                        }
                    case 10:
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Teaching</p>\r\n");
#nullable restore
#line 74 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
                            break;
                        }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 79 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CntFollowers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 82 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
           Write(Html.DisplayFor(model => model.CntFollowers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 85 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CntViewers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 88 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
           Write(Html.DisplayFor(model => model.CntViewers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 91 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Fame));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 94 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
           Write(Html.DisplayFor(model => model.Fame));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 97 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 100 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
           Write(Html.DisplayFor(model => model.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 103 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.AdvPicture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a5f484394444018991d86d1574a1c16b59e301214426", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Uploads/");
#nullable restore
#line 106 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
                        WriteLiteral(Model.AdvPicture);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 106 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a5f484394444018991d86d1574a1c16b59e301216971", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Details.cshtml"
                                                          WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a5f484394444018991d86d1574a1c16b59e301219252", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </main>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Entities.Advertise> Html { get; private set; }
    }
}
#pragma warning restore 1591
