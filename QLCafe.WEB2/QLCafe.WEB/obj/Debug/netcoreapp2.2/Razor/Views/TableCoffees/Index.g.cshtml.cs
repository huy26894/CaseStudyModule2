#pragma checksum "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b171bc7090602774ce06b53f4ddc57f10ee0d44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TableCoffees_Index), @"mvc.1.0.view", @"/Views/TableCoffees/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TableCoffees/Index.cshtml", typeof(AspNetCore.Views_TableCoffees_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b171bc7090602774ce06b53f4ddc57f10ee0d44", @"/Views/TableCoffees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60d74ec3a4c109ea01f59e0f563e33cea5e11222", @"/Views/_ViewImports.cshtml")]
    public class Views_TableCoffees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QLCafe.WEB.Models.TableCoffees.TableCoffeesView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TableCoffees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
  
    ViewData["Title"] = "TableCoffees";

#line default
#line hidden
            BeginContext(119, 40, true);
            WriteLiteral("\r\n    <h1>TableCoffees</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(159, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b171bc7090602774ce06b53f4ddc57f10ee0d444553", async() => {
                BeginContext(236, 19, true);
                WriteLiteral("TableCoffees Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(259, 133, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-striped table-bordered table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(393, 38, false);
#line 16 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(431, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(487, 42, false);
#line 19 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AreaID));

#line default
#line hidden
            EndContext();
            BeginContext(529, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(585, 40, false);
#line 22 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(625, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(681, 42, false);
#line 25 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(723, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(841, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(890, 37, false);
#line 34 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(927, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(983, 41, false);
#line 37 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AreaID));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1080, 39, false);
#line 40 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1175, 41, false);
#line 43 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1272, 89, false);
#line 46 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.ID }, new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1380, 95, false);
#line 47 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.ID }, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1494, 157, false);
#line 48 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.ID }, new { @class = "btn btn-warning", onClick = "return confirm('Are you sure you want to delete?' )"}));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1670, 114, false);
#line 49 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.ActionLink("The table list is empty", "GetEmptyTable", new { id = item.ID }, new { @class="btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1784, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1803, 113, false);
#line 50 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
           Write(Html.ActionLink("List of tables booked", "GetNotEmptyTable", new { id = item.ID }, new { @class="btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(1916, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 53 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1955, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QLCafe.WEB.Models.TableCoffees.TableCoffeesView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
