#pragma checksum "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c29f01b38b946cf5070cc44febbd21e1450a3d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Bildirim_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Bildirim/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c29f01b38b946cf5070cc44febbd21e1450a3d4", @"/Areas/Member/Views/Bildirim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fa8c96dc6fa4dfff64e33f0bc1c9f87a7700ab7", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Bildirim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BildirimListDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bildirim", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"my-4\">Bildirimler</h4>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-sm table-bordered"">
        <thead>
            <tr class=""table-info"">
                <th class=""text-center"" style=""width: 5%"">#</th>
                <th>Açıklama</th>
                <th class=""text-center"" style=""width: 20%"">İşlem</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
             foreach (var item in Model)
            {
                index++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 26 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
                                       Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
                   Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td class=\"text-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c29f01b38b946cf5070cc44febbd21e1450a3d47051", async() => {
                WriteLiteral("\r\n\r\n                            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 994, "\"", 1010, 1);
#nullable restore
#line 33 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
WriteAttributeValue("", 1002, item.Id, 1002, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                            <button type=\"submit\" class=\"btn btn-outline-dark btn-sm\"><i class=\"fas fa-check mr-2\"></i>Okundu Olarak İşaretle</button>\r\n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 43 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\">\r\n        <strong>Herhangi bir bildiriminiz bulunmamaktadır!</strong>\r\n    </div>\r\n");
#nullable restore
#line 49 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BildirimListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
