#pragma checksum "D:\Code\atik-tespit-sistemi\atik-tespit-sistemi.MVC\Views\Home\Takephoto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abb80f8c625d0a686baffa9d54a540129827c5a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Takephoto), @"mvc.1.0.view", @"/Views/Home/Takephoto.cshtml")]
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
#line 1 "D:\Code\atik-tespit-sistemi\atik-tespit-sistemi.MVC\Views\_ViewImports.cshtml"
using atik_tespit_sistemi.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code\atik-tespit-sistemi\atik-tespit-sistemi.MVC\Views\_ViewImports.cshtml"
using atik_tespit_sistemi.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb80f8c625d0a686baffa9d54a540129827c5a7", @"/Views/Home/Takephoto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be7ecae3c920495ee95e4bbcacf4dc1d38bb618", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Takephoto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Code\atik-tespit-sistemi\atik-tespit-sistemi.MVC\Views\Home\Takephoto.cshtml"
  
    ViewData["Title"] = "Take Photo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .cntnr {
        margin: 140px 15%;
    }
</style>

<div class=""cntnr"">
    <table cellpadding=""0"" cellspacing=""0"">
        <tr>
            <th style=""align-items: center;""><u>Live Camera</u></th>
            <th style=""align-items: center;""><u>Captured Picture</u></th>
        </tr>
        <tr>
            <td>
                <div id=""webcam""></div>
            </td>
            <td><img id=""imgCapture"" /></td>
        </tr>
        <tr>
            <td style=""align-items: center;"">
                <input type=""button"" id=""btnCapture"" value=""Capture"" />
            </td>
            <td style=""align-items: center;"">
                <input type=""button"" id=""btnUpload"" value=""Upload"" disabled=""disabled"" />
            </td>
        </tr>
    </table>
</div>
");
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
