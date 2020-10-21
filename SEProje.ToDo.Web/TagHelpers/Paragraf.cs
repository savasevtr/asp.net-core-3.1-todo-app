using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.TagHelpers
{
    [HtmlTargetElement("SE")]
    public class Paragraf : TagHelper
    {
        // gelen-data
        public string GelenData { get; set; } = "www.savasev.com";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // string data
            // tagBuilder
            // stringBuilder

            //var tagBuilder = new TagBuilder("p");
            //tagBuilder.InnerHtml.AppendHtml("<b>www.savasev.com</b>");
            //output.Content.SetHtmlContent(tagBuilder);

            //var stringBuilder = new StringBuilder();
            //stringBuilder.AppendFormat("<p><b>{0}</b></p>", "www.savasev.com");
            //output.Content.SetHtmlContent(stringBuilder.ToString());

            string data = string.Empty;

            data = "<p><b>" + GelenData + "</b></p>";
            output.Content.SetHtmlContent(data);

            base.Process(context, output);
        }
    }
}
