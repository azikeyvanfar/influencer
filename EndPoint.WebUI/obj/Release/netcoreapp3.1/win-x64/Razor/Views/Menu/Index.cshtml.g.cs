#pragma checksum "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d5dcb9f2e0a65b87785b9913e5b8082871aacf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
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
#line 1 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\_ViewImports.cshtml"
using EndPoint.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\_ViewImports.cshtml"
using EndPoint.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d5dcb9f2e0a65b87785b9913e5b8082871aacf5", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0386f531d259c28e1050915ccce8f076f2431c3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.Entities.FSYS.MenuGroup>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"sidebar\"  style=\"height: auto;\">\r\n    <!-- sidebar menu-->\r\n    <ul class=\"sidebar-menu tree\" data-widget=\"tree\" id=\"menuUl\">\r\n        <li class=\"user-profile treeview\">\r\n            <a href=\"index.html\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2d5dcb9f2e0a65b87785b9913e5b8082871aacf55469", async() => {
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
            WriteLiteral("\r\n                <span>\r\n                    <span class=\"d-block font-weight-600 font-size-16\">");
#nullable restore
#line 9 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                                                  Write(ViewBag.displayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"email-id\">");
#nullable restore
#line 10 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                      Write(ViewBag.Roles);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </span>
                <span class=""pull-right-container"">
                    <i class=""fa fa-angle-right pull-right""></i>
                </span>
            </a>
            <ul class=""treeview-menu"">
                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d5dcb9f2e0a65b87785b9913e5b8082871aacf57564", async() => {
                WriteLiteral("<i class=\"fa fa-user mr-5\"></i>پروفایل من");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                <li><a href=""#""><i class=""fa fa-money mr-5""></i>تعادل من</a></li>
                <li><a href=""#""><i class=""fa fa-envelope-open mr-5""></i>صندوق</a></li>
                <li><a href=""#""><i class=""fa fa-cog mr-5""></i>تنظیمات حساب</a></li>
                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d5dcb9f2e0a65b87785b9913e5b8082871aacf59254", async() => {
                WriteLiteral("<i class=\"fa fa-power-off mr-5\"></i>خروج");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            </ul>\r\n        </li>\r\n");
#nullable restore
#line 24 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"treeview\">\r\n                <a href=\"#\">\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 1409, "\"", 1427, 1);
#nullable restore
#line 28 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
WriteAttributeValue("", 1417, item.Icon, 1417, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                    <span");
            BeginWriteAttribute("id", " id=\"", 1460, "\"", 1477, 1);
#nullable restore
#line 29 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
WriteAttributeValue("", 1465, item.MenuId, 1465, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                       Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"pull-right-container\">\r\n                        <i class=\"fa fa-angle-right pull-right\"></i>\r\n                    </span>\r\n                </a>\r\n                <ul class=\"treeview-menu\">\r\n");
#nullable restore
#line 35 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                     foreach (var child in item.Children)
                    {
                        if (child.children.Count == 0)
                        {
                            var link = child.Link.Split('/');
                            if (link.Length > 1)
                            {
                                var controller = link[0];
                                var action = link[1];

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d5dcb9f2e0a65b87785b9913e5b8082871aacf513037", async() => {
                WriteLiteral("\r\n                                        <i");
                BeginWriteAttribute("class", " class=\"", 2314, "\"", 2333, 1);
#nullable restore
#line 46 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
WriteAttributeValue("", 2322, child.Icon, 2322, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>");
#nullable restore
#line 46 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                                              Write(child.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                           WriteLiteral(controller);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                                                    WriteLiteral(action);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 49 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"treeview\">\r\n                                <a href=\"#\">\r\n                                    <i class=\"mdi mdi-notification-clear-all\"></i>\r\n                                    ");
#nullable restore
#line 56 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                               Write(child.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <span class=""pull-right-container"">
                                        <i class=""fa fa-angle-right pull-right""></i>
                                    </span>
                                </a>
                                <ul class=""treeview-menu"">
");
#nullable restore
#line 62 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                     foreach (var minichild in child.children)
                                    {
                                        var link2 = minichild.Link.Split('/');
                                        if (link2.Length > 1)
                                        {
                                            var controller2 = link2[0];
                                            var action2 = link2[1];
                                            if (link2.Length > 2)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d5dcb9f2e0a65b87785b9913e5b8082871aacf518139", async() => {
                WriteLiteral("<i");
                BeginWriteAttribute("class", " class=\"", 3791, "\"", 3814, 1);
#nullable restore
#line 71 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
WriteAttributeValue("", 3799, minichild.Icon, 3799, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>");
#nullable restore
#line 71 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                                                                                                                                                              Write(minichild.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                                       WriteLiteral(controller2);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                                                                 WriteLiteral(action2);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-GroupKey", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                                                                                               WriteLiteral(link2[2].Split('=')[1]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GroupKey"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-GroupKey", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GroupKey"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 72 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d5dcb9f2e0a65b87785b9913e5b8082871aacf522819", async() => {
                WriteLiteral("<i");
                BeginWriteAttribute("class", " class=\"", 4095, "\"", 4118, 1);
#nullable restore
#line 75 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
WriteAttributeValue("", 4103, minichild.Icon, 4103, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>");
#nullable restore
#line 75 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                                                                                                                 Write(minichild.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                                       WriteLiteral(controller2);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                                                                 WriteLiteral(action2);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 76 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                                            }
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </li>\r\n");
#nullable restore
#line 81 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
                        }
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </li>\r\n");
#nullable restore
#line 85 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\Menu\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d5dcb9f2e0a65b87785b9913e5b8082871aacf526897", async() => {
                WriteLiteral("<i class=\"mdi mdi-directions\"></i><span>خروج</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Domain.Entities.FSYS.MenuGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
