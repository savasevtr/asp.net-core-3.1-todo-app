#pragma checksum "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72ed5bdad480e9e423e160cb37315374a96bcd67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\_ViewImports.cshtml"
using SEProje.ToDo.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\_ViewImports.cshtml"
using SEProje.ToDo.Web.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\_ViewImports.cshtml"
using SEProje.ToDo.DTO.DTOs.BildirimDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\_ViewImports.cshtml"
using SEProje.ToDo.DTO.DTOs.GorevDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ed5bdad480e9e423e160cb37315374a96bcd67", @"/Areas/Member/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f813f0b71f9afacae207076dcc5c4237dece00a0", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h4 class=""my-4"">Başlangıç</h4>

<div class=""row"">
    <div class=""col-md-3"">
        <div class=""card text-white bg-success mb-3"">
            <div class=""card-body"">
                <h5 class=""card-title"">Rapor Sayısı:</h5>
                <p class=""card-text lead"">");
#nullable restore
#line 13 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                                     Write(ViewBag.raporSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""card text-white bg-success mb-3"">
            <div class=""card-body"">
                <h5 class=""card-title"">Tamamlanan Görevler:</h5>
                <p class=""card-text lead"">");
#nullable restore
#line 21 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                                     Write(ViewBag.tamamlananGorevSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""card text-white bg-success mb-3"">
            <div class=""card-body"">
                <h5 class=""card-title"">Okunmamış Bildirimler</h5>
                <p class=""card-text lead"">");
#nullable restore
#line 29 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                                     Write(ViewBag.okunmayanBildirimSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""card text-white bg-success mb-3"">
            <div class=""card-body"">
                <h5 class=""card-title"">Devam Eden Görevler:</h5>
                <p class=""card-text lead"">");
#nullable restore
#line 37 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                                     Write(ViewBag.tamamlanmayanGorevSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
