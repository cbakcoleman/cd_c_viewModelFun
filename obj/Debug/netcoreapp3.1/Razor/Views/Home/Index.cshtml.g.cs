#pragma checksum "/Users/cbakcoleman/Desktop/CD_C#/cd_c_viewModelFun/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65bb96ca57f7675be85441751eaba9da2e3c7424"
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
#line 1 "/Users/cbakcoleman/Desktop/CD_C#/cd_c_viewModelFun/Views/_ViewImports.cshtml"
using cd_c_viewModelFun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cbakcoleman/Desktop/CD_C#/cd_c_viewModelFun/Views/_ViewImports.cshtml"
using cd_c_viewModelFun.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65bb96ca57f7675be85441751eaba9da2e3c7424", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f17eab1907606eb0df517f1a8e7f7388ec78ee67", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Here is a message!</h2>\r\n");
#nullable restore
#line 3 "/Users/cbakcoleman/Desktop/CD_C#/cd_c_viewModelFun/Views/Home/Index.cshtml"
 foreach(var msg in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 4 "/Users/cbakcoleman/Desktop/CD_C#/cd_c_viewModelFun/Views/Home/Index.cshtml"
  Write(msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 5 "/Users/cbakcoleman/Desktop/CD_C#/cd_c_viewModelFun/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
