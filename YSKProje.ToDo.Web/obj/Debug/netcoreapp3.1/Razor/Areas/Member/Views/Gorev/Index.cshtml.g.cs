#pragma checksum "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "811d957c0c6c0ee4827509c9b33d65ac43f91f68"
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
#line 3 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\_ViewImports.cshtml"
using YSKProje.ToDo.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"811d957c0c6c0ee4827509c9b33d65ac43f91f68", @"/Areas/Member/Views/Gorev/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13b92e3d2a4f41004eb00b6a5d04a1766c96421a", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Gorev_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GorevListAllViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
 foreach (var gorev in Model)
{
    index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card my-1\">\r\n        <h5 class=\"card-header\">");
#nullable restore
#line 12 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                           Write(gorev.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\"><span class=\"text-danger\">Aciliyet Durumu:</span>");
#nullable restore
#line 14 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                                                                               Write(gorev.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\"><span class=\"text-danger\">Görev Açıklama:</span>");
#nullable restore
#line 15 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                                                                            Write(gorev.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n            <p class=\"text-right\">\r\n");
#nullable restore
#line 19 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                 if (gorev.Raporlar.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-light btn-sm\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 718, "\"", 748, 2);
            WriteAttributeValue("", 725, "#collapseExample-", 725, 17, true);
#nullable restore
#line 21 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
WriteAttributeValue("", 742, index, 742, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\r\n                        <i class=\"fas fa-file-signature mr-2\"></i>\r\n                        Raporlara Git.\r\n                        <span class=\"badge badge-dark\">");
#nullable restore
#line 24 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                                                  Write(gorev.Raporlar.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n");
#nullable restore
#line 26 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n \r\n            </p>\r\n            <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1118, "\"", 1145, 2);
            WriteAttributeValue("", 1123, "collapseExample-", 1123, 16, true);
#nullable restore
#line 32 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
WriteAttributeValue("", 1139, index, 1139, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <table class=\"table table-hover table-bordered table-sm\">\r\n                    <tr>\r\n                        <th>Tanım</th>\r\n                        <th>Detay</th>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                     foreach (var rapor in gorev.Raporlar)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                           Write(rapor.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                           Write(rapor.Detay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           \r\n                        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </table>\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 55 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav aria-label=\"Page navigation example\" class=\"float-right\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 58 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
         for (int i = 1; i <=ViewBag.ToplamSayfa; i++)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 1912, "\"", 1966, 2);
            WriteAttributeValue("", 1920, "page-item", 1920, 9, true);
#nullable restore
#line 60 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
WriteAttributeValue(" ", 1929, ViewBag.AktifSayfa==i?"active":"", 1930, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "811d957c0c6c0ee4827509c9b33d65ac43f91f6810555", async() => {
#nullable restore
#line 61 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                                                                             Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-aktifSayfa", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
                                                                  WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aktifSayfa"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-aktifSayfa", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aktifSayfa"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 63 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Member\Views\Gorev\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n\r\n    </ul>\r\n</nav>\r\n\r\n\r\n");
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
