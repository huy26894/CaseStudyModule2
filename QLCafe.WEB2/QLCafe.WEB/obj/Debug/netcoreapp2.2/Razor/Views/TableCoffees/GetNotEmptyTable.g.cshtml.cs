#pragma checksum "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feade708ce35dabb8f3d632f3b89dcdc4e9c4e38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TableCoffees_GetNotEmptyTable), @"mvc.1.0.view", @"/Views/TableCoffees/GetNotEmptyTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TableCoffees/GetNotEmptyTable.cshtml", typeof(AspNetCore.Views_TableCoffees_GetNotEmptyTable))]
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
#line 1 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\_ViewImports.cshtml"
using QLCafe.WEB;

#line default
#line hidden
#line 2 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\_ViewImports.cshtml"
using QLCafe.WEB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feade708ce35dabb8f3d632f3b89dcdc4e9c4e38", @"/Views/TableCoffees/GetNotEmptyTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60d74ec3a4c109ea01f59e0f563e33cea5e11222", @"/Views/_ViewImports.cshtml")]
    public class Views_TableCoffees_GetNotEmptyTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QLCafe.WEB.Models.TableCoffees.TableCoffeesGetNotEmptyTable>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TableCoffees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml"
  
    ViewData["Title"] = "GetNotEmptyTable";

#line default
#line hidden
            BeginContext(135, 40, true);
            WriteLiteral("\r\n<h1>GetNotEmptyTable</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(175, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feade708ce35dabb8f3d632f3b89dcdc4e9c4e384601", async() => {
                BeginContext(228, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(242, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(335, 38, false);
#line 16 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(373, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(429, 42, false);
#line 19 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml"
           Write(Html.DisplayNameFor(model => model.AreaID));

#line default
#line hidden
            EndContext();
            BeginContext(471, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(527, 40, false);
#line 22 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(567, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(685, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(734, 37, false);
#line 31 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(771, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(827, 41, false);
#line 34 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml"
           Write(Html.DisplayFor(modelItem => item.AreaID));

#line default
#line hidden
            EndContext();
            BeginContext(868, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(924, 39, false);
#line 37 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(963, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1019, 65, false);
#line 40 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1105, 71, false);
#line 41 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1197, 69, false);
#line 42 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\GetNotEmptyTable.cshtml"
}

#line default
#line hidden
            BeginContext(1305, 35, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1340, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feade708ce35dabb8f3d632f3b89dcdc4e9c4e3810777", async() => {
                BeginContext(1362, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1378, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QLCafe.WEB.Models.TableCoffees.TableCoffeesGetNotEmptyTable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
