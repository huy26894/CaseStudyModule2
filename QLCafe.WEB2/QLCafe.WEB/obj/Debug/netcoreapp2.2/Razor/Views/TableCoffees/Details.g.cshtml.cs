#pragma checksum "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b21f7c17d53141344e67f6ebf27cebbbc13c1862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TableCoffees_Details), @"mvc.1.0.view", @"/Views/TableCoffees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TableCoffees/Details.cshtml", typeof(AspNetCore.Views_TableCoffees_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b21f7c17d53141344e67f6ebf27cebbbc13c1862", @"/Views/TableCoffees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60d74ec3a4c109ea01f59e0f563e33cea5e11222", @"/Views/_ViewImports.cshtml")]
    public class Views_TableCoffees_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QLCafe.WEB.Models.TableCoffees.TableCoffeesView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(101, 128, true);
            WriteLiteral("\r\n    <h1>TableCoffeesDetails</h1>\r\n\r\n<div>\r\n  \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(230, 38, false);
#line 14 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(268, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(332, 34, false);
#line 17 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Details.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(366, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(429, 42, false);
#line 20 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AreaID));

#line default
#line hidden
            EndContext();
            BeginContext(471, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(535, 38, false);
#line 23 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Details.cshtml"
       Write(Html.DisplayFor(model => model.AreaID));

#line default
#line hidden
            EndContext();
            BeginContext(573, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(636, 40, false);
#line 26 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(676, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(740, 36, false);
#line 29 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(776, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(839, 42, false);
#line 32 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(881, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(945, 38, false);
#line 35 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(983, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1031, 68, false);
#line 40 "D:\Module2\QLCaFe\QLCaFe.Web\QLCafe.WEB\QLCafe.WEB\Views\TableCoffees\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1107, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b21f7c17d53141344e67f6ebf27cebbbc13c18627751", async() => {
                BeginContext(1129, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1145, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QLCafe.WEB.Models.TableCoffees.TableCoffeesView> Html { get; private set; }
    }
}
#pragma warning restore 1591
