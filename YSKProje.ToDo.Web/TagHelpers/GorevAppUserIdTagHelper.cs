using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Web.TagHelpers
{
    [HtmlTargetElement("getirGorevAppUserId")]
    public class GorevAppUserIdTagHelper : TagHelper
    {
        private readonly IGorevService _gorevService;
        public int AppUserId { get; set; }
        public GorevAppUserIdTagHelper(IGorevService gorevService)
        {
            _gorevService = gorevService;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
           List<Gorev> gorevler = _gorevService.GetirileAppUserId(AppUserId);
           var tamamlananGorevSayisi= gorevler.Where(I => I.Durum).Count();
           var ustundeCalistigiGorevSayisi = gorevler.Where(I => !I.Durum).Count();

            string htmlString = $"<strong>Tamamladığı Görev Sayısı :</strong>{tamamlananGorevSayisi}<br>" +
                $"<strong>Üstünde Çalıştığı Görev Sayısı :</strong>{ustundeCalistigiGorevSayisi}";
            output.Content.SetHtmlContent(htmlString);
        }
    }
}
