#pragma checksum "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdf1f4a45916af4e76436f22a0a339d04e86510f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gorev_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Gorev/Index.cshtml")]
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
using YSKProje.ToDo.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdf1f4a45916af4e76436f22a0a339d04e86510f", @"/Areas/Admin/Views/Gorev/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13b92e3d2a4f41004eb00b6a5d04a1766c96421a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Gorev_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GorevListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EkleGorev", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gorev", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-dark my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuncelleGorev", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf1f4a45916af4e76436f22a0a339d04e86510f5251", async() => {
                WriteLiteral("<i class=\"far fa-plus-square mr-2\"></i>Yeni Görev Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <table class=""table table-sm table-hover"">
        <thead>
            <tr>
                <th>Tanım</th>
                <th>Açıklama</th>
                <th>Oluşturulma Tarihi</th>
                <th>Aciliyet</th>
                <th>Islem</th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 22 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml"
                   Write(item.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml"
                   Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml"
                   Write(item.OlusturulmaTarih.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml"
                   Write(item.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf1f4a45916af4e76436f22a0a339d04e86510f8644", async() => {
                WriteLiteral("<i class=\"far fa-edit mr-2\"></i>Düzenle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <a data-toggle=\"modal\" data-target=\"#silmeEkrani\" data-kubay=\"");
#nullable restore
#line 31 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml"
                                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger btn-sm\"><i class=\"far fa-times-circle mr-2\"></i>Sil</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 37 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center m-4\">\r\n        <p class=\"lead\">\r\n            Sistemde Kayıtlı Bir Görev Bulunamadı.\r\n        </p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf1f4a45916af4e76436f22a0a339d04e86510f12406", async() => {
                WriteLiteral("<i class=\"far fa-plus-square mr-2\"></i>Yeni Görev Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 47 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\Gorev\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    
<!-- Modal -->
<div class=""modal fade"" id=""silmeEkrani"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">UYARI</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Silmek istediğinizden emin misiniz?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Vazgeç</button>
                <button id=""btnSil"" type=""button"" class=""btn btn-primary"">Evet</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@" 
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#silmeEkrani"").on(""show.bs.modal"", function (event) {
                let tetikleyenElement = $(event.relatedTarget);
                let id = tetikleyenElement.data(""kubay"");

                $(""#btnSil"").click(function () {
                    $.ajax({
                        type: ""Get"",
                        url: ""./Gorev/SilGorev"",
                        data: { id: id },
                        dataType: ""json"",
                        contentType: ""application/json; charset=utf-8"",
                        success: function () {
                            alert(""İşlem Tamamlandı"");
                            window.location.reload();
                        },
                        error: function (error) {
                            alert(error.statusText)
                        }
                    })
                });
            })

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GorevListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
