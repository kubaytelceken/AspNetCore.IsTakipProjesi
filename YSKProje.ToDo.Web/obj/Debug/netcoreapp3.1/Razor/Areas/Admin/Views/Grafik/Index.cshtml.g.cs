#pragma checksum "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Grafik\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d213abab27b4b58d417a9e5fa43b1d48c93f5434"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Grafik_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Grafik/Index.cshtml")]
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
#line 3 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AciliyetDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.BildirimDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.GorevDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AppUserDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d213abab27b4b58d417a9e5fa43b1d48c93f5434", @"/Areas/Admin/Views/Grafik/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af2779da0148f888ce5db6596ce61b732904477", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Grafik_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Grafik\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-6"">
        <div id=""piechart_3d"" class=""w-100"" style="" height: 500px;""></div>
    </div>
    <div class=""col-md-6"">
        <div id=""piechart"" class=""w-100"" style="" height: 500px;""></div>

    </div>

</div>



");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script type=""text/javascript"">


        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {

            let enCokIsTamamlayan = [['Personel Adı', 'Görev Sayısı']];

            $.ajax({
                type: ""Get"",
                url: ""./Grafik/EnCokTamamlayan"",
                async: false,
                success: function (data) {
                    let gelenObje = jQuery.parseJSON(data);
                    $.each(gelenObje, (index, value) => {
                        enCokIsTamamlayan.push([value.Isim, value.GorevSayisi]);
                    });
                }
            })



            var data = google.visualization.arrayToDataTable(enCokIsTamamlayan);

            var options = {
                title: 'En Çok İş Tamamlayan 5 Personel'
            };

            var c");
                WriteLiteral(@"hart = new google.visualization.PieChart(document.getElementById('piechart'));

            chart.draw(data, options);
        }

        google.charts.load(""current"", { packages: [""corechart""] });
        google.charts.setOnLoadCallback(drawChart2);
        function drawChart2() {
            let enCokCalisan = [['Personel Adı', 'Görev Sayısı']];
            $.ajax({
                type: ""Get"",
                url: ""./Grafik/EnCokCalisan"",
                async: false,
                success: function (data) {
                    let gelenObje2 = jQuery.parseJSON(data);
                    $.each(gelenObje2, (index, value) => {
                        enCokCalisan.push([value.Isim, value.GorevSayisi]);
                    });
                }
            });


            var data = google.visualization.arrayToDataTable(enCokCalisan);

            var options = {
                title: 'Şuan Görevde Çalışan Personeller',
                is3D: true,
            };

            ");
                WriteLiteral("var chart = new google.visualization.PieChart(document.getElementById(\'piechart_3d\'));\r\n            chart.draw(data, options);\r\n        }\r\n    </script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
