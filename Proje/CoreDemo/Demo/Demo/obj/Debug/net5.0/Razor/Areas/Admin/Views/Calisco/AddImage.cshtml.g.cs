#pragma checksum "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Areas\Admin\Views\Calisco\AddImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9c47d1e2093c84322dac1312a41ccc2369ace7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Calisco_AddImage), @"mvc.1.0.view", @"/Areas/Admin/Views/Calisco/AddImage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9c47d1e2093c84322dac1312a41ccc2369ace7f", @"/Areas/Admin/Views/Calisco/AddImage.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Calisco_AddImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo.Areas.Admin.Models.AddCaliscoImage>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Areas\Admin\Views\Calisco\AddImage.cshtml"
  
    ViewData["Title"] = "AddImage";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<form class=\"form-group\" method=\"post\" enctype=\"multipart/form-data\">\r\n    <h1>Yeni Model Ekle</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Areas\Admin\Views\Calisco\AddImage.cshtml"
 using (Html.BeginForm("AddCalisco","Calisco",FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Areas\Admin\Views\Calisco\AddImage.cshtml"
Write(Html.Label("Model'in Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Areas\Admin\Views\Calisco\AddImage.cshtml"
Write(Html.TextBoxFor(x=>x.Calisco_Name,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Areas\Admin\Views\Calisco\AddImage.cshtml"
Write(Html.ValidationMessageFor(x=>x.Calisco_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <label>Model\'in Resmi</label>\r\n        <input type=\"file\" name=\"Calisco_Image\" />\r\n    </div>\r\n");
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Kaydet</button>\r\n");
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Areas\Admin\Views\Calisco\AddImage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</form>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo.Areas.Admin.Models.AddCaliscoImage> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591