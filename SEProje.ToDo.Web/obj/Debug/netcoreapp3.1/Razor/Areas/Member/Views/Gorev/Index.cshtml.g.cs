#pragma checksum "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84d6eb2929f69b1916fc6e8ef656c71eb6d05688"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Gorev_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Gorev/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84d6eb2929f69b1916fc6e8ef656c71eb6d05688", @"/Areas/Member/Views/Gorev/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c24a5e7e43a1661892ad0534120248c53c1c2c12", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Gorev_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GorevListAllViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gorev", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"mt-4\">Gelen İş Emirleri</h4>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
 foreach (var gorev in Model)
{
    index++;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card my-4\">\r\n        <h5 class=\"card-header\">");
#nullable restore
#line 15 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                           Write(gorev.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">\r\n                <span class=\"text-danger\">Aciliyet Durumu : </span> ");
#nullable restore
#line 18 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                                                               Write(gorev.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 20 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                            Write(gorev.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <p class=\"text-right\">\r\n");
#nullable restore
#line 23 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                 if (gorev.Raporlar.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-outline-dark btn-sm\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 755, "\"", 775, 2);
            WriteAttributeValue("", 762, "#rapor-", 762, 7, true);
#nullable restore
#line 25 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
WriteAttributeValue("", 769, index, 769, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"raportlar\">\r\n                        Raporlara Git <span class=\"badge badge-dark\"> ");
#nullable restore
#line 26 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                                                                 Write(gorev.Raporlar.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n");
#nullable restore
#line 28 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n\r\n            <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1039, "\"", 1056, 2);
            WriteAttributeValue("", 1044, "rapor-", 1044, 6, true);
#nullable restore
#line 31 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
WriteAttributeValue("", 1050, index, 1050, 6, false);

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
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 40 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                         foreach (var rapor in gorev.Raporlar)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                               Write(rapor.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                               Write(rapor.Detay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 53 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav class=\"page navigation float-right\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 57 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
         for (int i = 1; i <= ViewBag.pageCount; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 1935, "\"", 1996, 2);
            WriteAttributeValue("", 1943, "page-item", 1943, 9, true);
#nullable restore
#line 59 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
WriteAttributeValue(" ", 1952, ViewBag.currentpage == i ? "active" : "", 1953, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84d6eb2929f69b1916fc6e8ef656c71eb6d0568810884", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 61 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                                                                                                     WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 64 "C:\Users\SE\source\repos\UdemyToDo\SEProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>");
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
