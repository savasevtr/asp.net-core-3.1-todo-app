#pragma checksum "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aec338704565101157a04cc8efaf0103f860989"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_IsEmri_PersonelAta), @"mvc.1.0.view", @"/Areas/Admin/Views/IsEmri/PersonelAta.cshtml")]
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
#line 3 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SEProje.ToDo.DTO.DTOs.AciliyetDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SEProje.ToDo.DTO.DTOs.BildirimDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SEProje.ToDo.DTO.DTOs.GorevDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SEProje.ToDo.DTO.DTOs.AppUserDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aec338704565101157a04cc8efaf0103f860989", @"/Areas/Admin/Views/IsEmri/PersonelAta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad76540c95b1272332d3a0db4e36336885fd1c2f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_IsEmri_PersonelAta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GorevListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "IsEmri", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PersonelAta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid card-img p-4 shadow img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GorevlendirPersonel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::SEProje.ToDo.Web.TagHelpers.GorevAppUserIdTagHelper __SEProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
  
    ViewData["Title"] = "Personel Ata";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    string search = (string)ViewBag.search;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"mt-4\">Personel Ata</h4>\r\n\r\n<div class=\"row mb-2\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 12 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
         if (!string.IsNullOrWhiteSpace(search))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"border border-dark p-3 mb-2\">\r\n                <strong>");
#nullable restore
#line 15 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                   Write(search);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> kelimesi için arama sonuçları:\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aec338704565101157a04cc8efaf0103f8609898645", async() => {
                WriteLiteral("Aramayı Temizle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 18 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aec338704565101157a04cc8efaf0103f86098911606", async() => {
                WriteLiteral("\r\n            <input type=\"text\" name=\"search\"");
                BeginWriteAttribute("value", " value=\"", 800, "\"", 815, 1);
#nullable restore
#line 20 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
WriteAttributeValue("", 808, search, 808, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control-sm border border-primary border-top-0 border-left-0 border-right-0\" />\r\n            <button type=\"submit\" class=\"btn btn-sm btn-success\">Ara</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div class=""row mt-4"">
    <div class=""col-md-4"">
        <div class=""card border border-primary"">
            <div class=""card-header"">
                <h5 class=""text-center lead"">Görev Bilgileri</h5>
            </div>
            <div class=""card-body"">
                <div class=""card-title"">");
#nullable restore
#line 33 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                   Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <p class=\"card-text\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
               Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p class=\"card-text\">\r\n                    <strong>Aciliyet Durumu:</strong><span class=\"badge badge-primary\">");
#nullable restore
#line 38 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                                                  Write(Model.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </p>\r\n                <p class=\"card-text\">\r\n                    <small>");
#nullable restore
#line 41 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                      Write(Model.OlusturmaTarihi.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n\r\n");
#nullable restore
#line 48 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
         foreach (var item in (List<AppUserListDto>)ViewBag.Personeller)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-3 border border-primary\">\r\n                <div class=\"row no-gutters\">\r\n                    <div class=\"col-md-4 p-4\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9aec338704565101157a04cc8efaf0103f86098916733", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2109, "~/img/", 2109, 6, true);
#nullable restore
#line 53 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
AddHtmlAttributeValue("", 2115, item.Picture, 2115, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
AddHtmlAttributeValue("", 2135, item.Name, 2135, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 57 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 57 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                         Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                            <p class=\"card-text\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getirGorevAppUserId", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aec338704565101157a04cc8efaf0103f86098919626", async() => {
            }
            );
            __SEProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper = CreateTagHelper<global::SEProje.ToDo.Web.TagHelpers.GorevAppUserIdTagHelper>();
            __tagHelperExecutionContext.Add(__SEProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper);
#nullable restore
#line 59 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
__SEProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper.AppUserId = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("app-user-id", __SEProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper.AppUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                            <p class=\"card-text\">\r\n                                <small class=\"text-muted\">");
#nullable restore
#line 62 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                     Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aec338704565101157a04cc8efaf0103f86098921514", async() => {
                WriteLiteral("Görevlendir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PersonelId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PersonelId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PersonelId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PersonelId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                                                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GorevId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-GorevId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GorevId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 69 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <nav aria-label=\"Page navigation example\">\r\n            <ul class=\"pagination\">\r\n");
#nullable restore
#line 73 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                 for (int i = 1; i <= (int)@ViewBag.pageCount; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 3304, "\"", 3365, 2);
            WriteAttributeValue("", 3312, "page-item", 3312, 9, true);
#nullable restore
#line 75 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
WriteAttributeValue(" ", 3321, ViewBag.currentPage == i ? "active" : "", 3322, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 76 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                         if (!string.IsNullOrWhiteSpace(search))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aec338704565101157a04cc8efaf0103f86098926728", async() => {
#nullable restore
#line 78 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                                                                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                                                                                              WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                                                                                                                    WriteLiteral(search);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-search", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aec338704565101157a04cc8efaf0103f86098931726", async() => {
#nullable restore
#line 82 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                                                                                                                              WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 83 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </li>\r\n");
#nullable restore
#line 85 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Admin\Views\IsEmri\PersonelAta.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </nav>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GorevListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
