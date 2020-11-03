using Microsoft.AspNetCore.Razor.TagHelpers;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace SEProje.ToDo.Web.TagHelpers
{
    [HtmlTargetElement("getirGorevAppUserId")]
    public class GorevAppUserIdTagHelper : TagHelper
    {
        private readonly IGorevService _gorevService;

        public GorevAppUserIdTagHelper(IGorevService gorevService)
        {
            _gorevService = gorevService;
        }

        public int AppUserId { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            List<Gorev> gorevler = _gorevService.GetirileAppUserId(AppUserId);

            var tamamlananlar = gorevler.Where(x => x.Durum).Count();
            var devamEdenler = gorevler.Where(x => !x.Durum).Count();

            string htmlString = $"<strong>Tamamladığı Görev Sayısı : </strong> {tamamlananlar}<br>" +
                $"<strong>Devam Eden Görev Sayısı : </strong> {devamEdenler}";

            output.Content.SetHtmlContent(htmlString);
        }
    }
}