#pragma checksum "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4c49e25902d2ebe2a23d5fa916df58e21915d15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_IsEmri_Index), @"mvc.1.0.view", @"/Areas/Member/Views/IsEmri/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c49e25902d2ebe2a23d5fa916df58e21915d15", @"/Areas/Member/Views/IsEmri/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fa8c96dc6fa4dfff64e33f0bc1c9f87a7700ab7", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_IsEmri_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GorevListAllViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "IsEmri", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EkleRapor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DuzenleRapor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"mt-4\">Gelen İş Emirleri</h4>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
 foreach (var gorev in Model)
{
    index++;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card my-4\">\r\n        <h5 class=\"card-header\">");
#nullable restore
#line 15 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                           Write(gorev.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">\r\n                <span class=\"text-danger\">Aciliyet Durumu : </span> ");
#nullable restore
#line 18 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                                                               Write(gorev.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 20 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                            Write(gorev.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <p class=\"text-right\">\r\n");
#nullable restore
#line 23 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                 if (gorev.Raporlar.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-outline-dark btn-sm\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 755, "\"", 775, 2);
            WriteAttributeValue("", 762, "#rapor-", 762, 7, true);
#nullable restore
#line 25 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
WriteAttributeValue("", 769, index, 769, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"raportlar\">\r\n                        Raporlara Git <span class=\"badge badge-dark\"> ");
#nullable restore
#line 26 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                                                                 Write(gorev.Raporlar.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n");
#nullable restore
#line 28 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4c49e25902d2ebe2a23d5fa916df58e21915d158641", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-plus-circle mr-2\"></i>Rapor Yaz\r\n                ");
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
#line 30 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                                                                                      WriteLiteral(gorev.Id);

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
            WriteLiteral("\r\n\r\n                <button type=\"button\" class=\"btn btn-outline-success btn-sm\" data-toggle=\"modal\" data-target=\"#gorevTamamla\" data-id=\"");
#nullable restore
#line 34 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                                                                                                                                 Write(gorev.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <i class=\"fas fa-check mr-2\"></i>Tamamlandı Olarak İşaretle\r\n                </button>\r\n            </p>\r\n\r\n            <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1537, "\"", 1554, 2);
            WriteAttributeValue("", 1542, "rapor-", 1542, 6, true);
#nullable restore
#line 39 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
WriteAttributeValue("", 1548, index, 1548, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <table class=""table table-sm table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th>Tanım</th>
                            <th>Detay</th>
                            <th class=""text-center"" style=""width: 15%;"">İşlem</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 49 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                         foreach (var rapor in gorev.Raporlar)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 52 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                               Write(rapor.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                               Write(rapor.Detay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4c49e25902d2ebe2a23d5fa916df58e21915d1513971", async() => {
                WriteLiteral("Düzenle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                                                                                                             WriteLiteral(rapor.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 58 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 65 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""gorevTamamla"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Uyarı</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Bu işlemi gerçekleştirmek istediğinizden emin misiniz? 
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary btn-sm"" data-dismiss=""modal"">Vazgeç</button>
                <button type=""button"" class=""btn btn-primary btn-sm"" id=""btnTamamlaGorev"">Evet</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#gorevTamamla"").on(""show.bs.modal"", function (event) {
                var element = $(event.relatedTarget);
                var gorevId = element.data(""id"");

                $(""#btnTamamlaGorev"").click(function (e) {
                    e.preventDefault();
                    $.ajax({
                        type: ""GET"",
                        contentType: ""application/json; charset=utf-8"",
                        url: ""/Member/IsEmri/TamamlaGorev"",
                        data: { gorevId: gorevId },
                        success: function () {
                            // $(""#gorevTamamla"").hide();
                            window.location.reload();
                        },
                        error: function (err) {
                            alert(err.responseText);
                        }
                    });
                });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GorevListAllViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
