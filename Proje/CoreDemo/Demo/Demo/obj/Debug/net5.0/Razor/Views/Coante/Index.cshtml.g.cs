#pragma checksum "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Views\Coante\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b34f1a23e510d354abc22d875c08eb29859ae3cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coante_Index), @"mvc.1.0.view", @"/Views/Coante/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Views\_ViewImports.cshtml"
using Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Views\_ViewImports.cshtml"
using Demo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Views\Coante\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34f1a23e510d354abc22d875c08eb29859ae3cb", @"/Views/Coante/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18407c5b9dabc62761fc6cdd8f67817f22bc556", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Coante_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Coante>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Views\Coante\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"main-content-w3layouts-agileits\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<h3 class=\"tittle\">Coante Modeller</h3>\r\n\t\t\t<div class=\"inner-sec\">\r\n\t\t\t\t<div class=\"left-blog-info-w3layouts-agileits text-left\">\r\n\t\t\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Views\Coante\Index.cshtml"
                         foreach(var item in Model ){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"col-lg-4 card\">\r\n\t\t\t\t\t\t\t<a>\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 478, "\"", 502, 1);
#nullable restore
#line 18 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Views\Coante\Index.cshtml"
WriteAttributeValue("", 484, item.Coante_Image, 484, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 534, "\"", 540, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t</a>\r\n\r\n\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t<h5 class=\"card-title\">\r\n\t\t\t\t\t\t\t\t\t<a>");
#nullable restore
#line 23 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Views\Coante\Index.cshtml"
                                  Write(item.Coante_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<br />\r\n");
#nullable restore
#line 28 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Views\Coante\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Coante>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
