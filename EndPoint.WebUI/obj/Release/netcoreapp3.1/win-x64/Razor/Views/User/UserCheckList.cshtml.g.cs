#pragma checksum "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\User\UserCheckList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4592c5eedf0386ab9e52da1a4b77d6ce50af0a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserCheckList), @"mvc.1.0.view", @"/Views/User/UserCheckList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4592c5eedf0386ab9e52da1a4b77d6ce50af0a5", @"/Views/User/UserCheckList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0386f531d259c28e1050915ccce8f076f2431c3a", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserCheckList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<select class=""js-example-data-array form-control"" id=""basicUser"" multiple=""multiple""></select>
<script>
    $(function () {
        var listUsers = [];
        $.GetDataFence = function (maximumSelectionLength) {
            $.ajax({
                url: '");
#nullable restore
#line 7 "C:\Users\azadeh\Source\Repos\azikeyvanfar\influencer\EndPoint.WebUI\Views\User\UserCheckList.cshtml"
                 Write(Url.Action("GetDataUsers","User"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'post',
                dataType: 'json',
                success: function (res) {
                    listUsers = res;
                    $(""#basicUser.js-example-data-array"").select2({
                        dir: ""rtl"",
                        data: res,
                        maximumSelectionLength: maximumSelectionLength
                    });
                }
            });
        }
        $.GetDataFence('all');
        $(""#users"").click(function () {
            if ($(this).is("":checked"")) {
                var html = """";
                var listVal = [];
                $.each(listUsers, function (e, v) {
                    html += '<li  class=""select2-selection__choice"" data-select2-id=""' + v.id + '"" title=""' + v.text + '""><span class=""select2-selection__choice__remove"" role=""presentation"">×</span>""' + v.text + '""</li>';
                    listVal.push(v.id);
                });
                $(""#basicUser~.select2 ul.select2-selection__rende");
            WriteLiteral(@"red"").append(html);
                $(""#basicUser"").val(listVal);
                $('#basicUser.js-example-data-array').trigger('change');
            } else {
                $(""#basicUser"").val('');
                $(""#basicUser~.select2 ul.select2-selection__rendered li"").remove();
            }
        });
    });
</script>");
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
