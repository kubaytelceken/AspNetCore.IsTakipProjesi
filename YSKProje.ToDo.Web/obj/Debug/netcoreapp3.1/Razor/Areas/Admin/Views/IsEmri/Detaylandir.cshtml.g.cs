#pragma checksum "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd9d982b158155f349fa0ac818853c3715bd660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_IsEmri_Detaylandir), @"mvc.1.0.view", @"/Areas/Admin/Views/IsEmri/Detaylandir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd9d982b158155f349fa0ac818853c3715bd660", @"/Areas/Admin/Views/IsEmri/Detaylandir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af2779da0148f888ce5db6596ce61b732904477", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_IsEmri_Detaylandir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GorevListAllDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetirExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success  my-2 mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetirPdf", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger  my-2 mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
  
    ViewData["Title"] = "Detaylandir";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
 if (Model.Raporlar.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd9d982b158155f349fa0ac818853c3715bd6606066", async() => {
                WriteLiteral("<i class=\"fas fa-file-excel mr-2\"></i>Excel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd9d982b158155f349fa0ac818853c3715bd6608458", async() => {
                WriteLiteral("<i class=\"fas fa-file-pdf mr-2\"></i>Pdf");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <table class=\"table table-hover table-sm\">\r\n        <tr>\r\n            <th>");
#nullable restore
#line 13 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
           Write(Model.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                               Write(Model.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" personelinizin ");
#nullable restore
#line 13 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                                                                     Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" görevine yazmış olduğu raporlar </th>\r\n        </tr>\r\n        <tr>\r\n            <th>Tanım</th>\r\n            <th>Detay</th>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
         foreach (var rapor in Model.Raporlar)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
               Write(rapor.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
               Write(rapor.Detay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 27 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"border border-dark mt-2 text-center\">\r\n        ");
#nullable restore
#line 31 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
   Write(Model.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                       Write(Model.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" personeliniz şuanda ");
#nullable restore
#line 31 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                                                                  Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" görevi üzerinde çalışıyor. Henüz bir rapor yazmamış.\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\Kubay\Documents\GitHub\AspNetCore.IsTakipProjesi\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GorevListAllDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
