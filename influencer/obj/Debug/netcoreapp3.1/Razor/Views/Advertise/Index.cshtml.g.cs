#pragma checksum "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fd7d65666279bbaa0c3678420912c36367f1888"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advertise_Index), @"mvc.1.0.view", @"/Views/Advertise/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fd7d65666279bbaa0c3678420912c36367f1888", @"/Views/Advertise/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d49a529210120cf46888b52c977990ca4cf5b7c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Advertise_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Entities.Advertise>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <main role=""main"" class=""pb-3"">
        <div class=""row"">
            <div class=""col-md-10 col-sm-8 col-7"">
                <h1>All Advertise</h1>
            </div>
            <div class=""col-md-2 col-sm-4 col-5"">
                <p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd7d65666279bbaa0c3678420912c36367f18887056", async() => {
                WriteLiteral("<i class=\"bi-plus\"></i>Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 22 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 25 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CntFollowers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 28 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CntViewers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 31 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Fame));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 34 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Categories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 37 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.OrderAdvertise));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 40 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.AdvPicture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 46 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 52 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 55 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CntFollowers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 58 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CntViewers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 61 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                                 switch (@item.Fame)
                                {
                                    case 1:
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>⭐</p>\r\n");
#nullable restore
#line 66 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                                            break;
                                        }
                                    case 2:
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>⭐⭐</p>\r\n");
#nullable restore
#line 71 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"

                                            break;
                                        }
                                    case 3:
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>⭐⭐⭐</p>\r\n");
#nullable restore
#line 77 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                                            break;
                                        }
                                    case 4:
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>⭐⭐⭐⭐</p>\r\n");
#nullable restore
#line 82 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"

                                            break;
                                        }
                                    case 5:
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>⭐⭐⭐⭐⭐</p>\r\n");
#nullable restore
#line 88 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                                            break;
                                        }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 93 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                                 switch (@item.Categories)
                                {
                                    case 1:
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>APP</p>\r\n");
#nullable restore
#line 98 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                                            break;
                                        }
                                    case 2:
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>CARD</p>\r\n");
#nullable restore
#line 103 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"

                                            break;
                                        }
                                    case 3:
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>WEB</p>\r\n");
#nullable restore
#line 109 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                                            break;
                                        }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 114 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OrderAdvertise));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a href=\"#\" class=\"pop\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fd7d65666279bbaa0c3678420912c36367f188817795", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Uploads/");
#nullable restore
#line 118 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                                            WriteLiteral(item.AdvPicture);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 118 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
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
            WriteLiteral("\r\n                                </a>\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd7d65666279bbaa0c3678420912c36367f188820599", async() => {
                WriteLiteral("<i class=\"bi-pencil\"></i>");
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
#line 122 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 122 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
AddHtmlAttributeValue("", 5105, item.Title, 5105, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 5116, "Edit", 5117, 5, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd7d65666279bbaa0c3678420912c36367f188823461", async() => {
                WriteLiteral("<i class=\"bi-list-task\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 123 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 123 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
AddHtmlAttributeValue("", 5274, item.Title, 5274, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 5285, "Details", 5286, 8, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                <a data-id=\"");
#nullable restore
#line 124 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-name=\"");
#nullable restore
#line 124 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                                                            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("title", " title=\"", 5408, "\"", 5434, 2);
#nullable restore
#line 124 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
WriteAttributeValue("", 5416, item.Title, 5416, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5427, "Delete", 5428, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger delete-adv\" data-bs-toggle=\"modal\" data-bs-target=\"#DelModal\"><i class=\"bi-trash\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 127 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </main>
</div>
<!-- Creates the bootstrap modal where the image will appear -->
<div class=""modal fade"" id=""imagemodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
");
            WriteLiteral("                <h4 class=\"modal-title\" id=\"myModalLabel\">Image preview</h4>\r\n            </div>\r\n            <div class=\"modal-body\" style=\"text-align: center;\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 6374, "\"", 6380, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""imagepreview"" style=""width: 400px; height: 264px;"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-bs-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<!-- Modal -->
<div class=""modal"" id=""DelModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""DelModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""DelModalLabel"">Delete</h5>
                <button type=""button"" class=""close"" data-bs-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Are You Sure Delete
                <b><span id=""advName""></span></b>
                ?
                <input id=""advId"" name=""advId"" ty");
            WriteLiteral(@"pe=""hidden"" />
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-danger"" id=""delete-to-server"">Delete</button>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $("".pop"").on(""click"", function () {
            var img = $(this).find('img.rounded-circle');
            $('#imagepreview').attr('src', img.attr('src')); // here asign the image to the modal when the user click the enlarge link
            $('#imagemodal').modal('show'); // imagemodal is the id attribute assigned to the bootstrap modal, then i use the show function
        });
         $(document).on(""click"", "".delete-adv"", function () {
                var myadvId = $(this).data('id');
                $("".modal-body #advId"").val(myadvId);
                var myadvName = $(this).data('name');
                $("".modal-body #advName"").text(myadvName);

                // As pointed out in comments,
                // it is unnecessary to have to manually call the modal.
                // $('#addBookDialog').modal('show');
            });
            $(""#delete-to-server"").click(function () {
                 $.ajax({
                        type: 'post',
            ");
                WriteLiteral("            url: \'");
#nullable restore
#line 193 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\influencer\Views\Advertise\Index.cshtml"
                         Write(Url.Action("DeleteConfirmed", "Advertise"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        data: {
                            id: $('#advId').val()
                        },
                         success: function (e) {
                             if (e == true) {
                                 alert('Delete Success');
                                 id = $('#advId').val();
                                 $('[data-id=""' + id + '""]').parent(""tr"").remove();
                                 $('[data-bs-dismiss=""modal""]').click();
                            }
                            else {
                             alert('Do Not Delete');
                            }
                        }
                    });
            });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Entities.Advertise>> Html { get; private set; }
    }
}
#pragma warning restore 1591
