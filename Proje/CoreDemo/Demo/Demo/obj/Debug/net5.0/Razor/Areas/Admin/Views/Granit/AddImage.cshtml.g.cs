#pragma checksum "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Areas\Admin\Views\Granit\AddImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74df2e609a073f157e730c78708b2125b156825f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Granit_AddImage), @"mvc.1.0.view", @"/Areas/Admin/Views/Granit/AddImage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74df2e609a073f157e730c78708b2125b156825f", @"/Areas/Admin/Views/Granit/AddImage.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Granit_AddImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo.Areas.Admin.Models.AddGranitImage>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Areas\Admin\Views\Granit\AddImage.cshtml"
  
    ViewData["Title"] = "AddImage";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<form class=""form-group"" method=""post"" enctype=""multipart/form-data"">
    <div class=""col-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Yeni Model Ekle</h4>
                <br />
                <div class=""forms-sample"">
                    <div class=""form-group"">
                        <label for=""exampleInputName"">Model'in Adı</label>
                        ");
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\Proje\CoreDemo\Demo\Demo\Areas\Admin\Views\Granit\AddImage.cshtml"
                   Write(Html.TextBoxFor(x=>x.Granit_Name,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                     <div class=""form-group"">
                        <label>Model'in Resmi</label>
                        <input type=""file"" name=""Granit_Image""/>
                    </div>
                    <button type=""submit"" class=""btn btn-gradient-primary mr-2"">Kaydet</button>
                </div>
            </div>
        </div>
    </div>
</form>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo.Areas.Admin.Models.AddGranitImage> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
