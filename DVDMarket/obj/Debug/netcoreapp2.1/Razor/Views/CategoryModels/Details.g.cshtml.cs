#pragma checksum "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\CategoryModels\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8b027a075358fe365dd3b03b297cfef88103f55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoryModels_Details), @"mvc.1.0.view", @"/Views/CategoryModels/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CategoryModels/Details.cshtml", typeof(AspNetCore.Views_CategoryModels_Details))]
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
#line 1 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\_ViewImports.cshtml"
using DVDMarket;

#line default
#line hidden
#line 2 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\_ViewImports.cshtml"
using DVDMarket.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8b027a075358fe365dd3b03b297cfef88103f55", @"/Views/CategoryModels/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4f07274e6063b32dbfa2e6db977ce809043860e", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoryModels_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DVDMarket.Models.CategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success col-md-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning col-md-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\CategoryModels\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 151, true);
            WriteLiteral("\r\n<h2>Details Category</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <div style=\"padding: 0 0 0 20px;\">\r\n        <div class=\"row\">\r\n            <h3>\r\n                ");
            EndContext();
            BeginContext(283, 40, false);
#line 15 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\CategoryModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(323, 23, true);
            WriteLiteral(" :  [\r\n                ");
            EndContext();
            BeginContext(347, 36, false);
#line 16 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\CategoryModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(383, 100, true);
            WriteLiteral(" ]\r\n            </h3>\r\n        </div>\r\n        <div class=\"row\">\r\n            <h3>\r\n                ");
            EndContext();
            BeginContext(484, 47, false);
#line 21 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\CategoryModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(531, 22, true);
            WriteLiteral(" : [\r\n                ");
            EndContext();
            BeginContext(554, 43, false);
#line 22 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\CategoryModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(597, 100, true);
            WriteLiteral(" ]\r\n            </h3>\r\n        </div>\r\n        <div class=\"row\">\r\n            <h3>\r\n                ");
            EndContext();
            BeginContext(698, 41, false);
#line 27 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\CategoryModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Limit));

#line default
#line hidden
            EndContext();
            BeginContext(739, 22, true);
            WriteLiteral(" : [\r\n                ");
            EndContext();
            BeginContext(762, 37, false);
#line 28 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\CategoryModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.Limit));

#line default
#line hidden
            EndContext();
            BeginContext(799, 100, true);
            WriteLiteral(" ]\r\n            </h3>\r\n        </div>\r\n        <div class=\"row\">\r\n            <h3>\r\n                ");
            EndContext();
            BeginContext(900, 44, false);
#line 33 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\CategoryModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(944, 22, true);
            WriteLiteral(" : [\r\n                ");
            EndContext();
            BeginContext(967, 40, false);
#line 34 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\CategoryModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 186, true);
            WriteLiteral(" ]\r\n            </h3>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\" style=\"padding: 30px 0 30px 0;\">\r\n    <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1193, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d61afed82c944e79dcfd4711b9bd769", async() => {
                BeginContext(1280, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 43 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\CategoryModels\Details.cshtml"
                                   WriteLiteral(Model.CategoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1288, 85, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1373, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e4b450b925e4c8eac08fc3eaa7e0775", async() => {
                BeginContext(1428, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1444, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DVDMarket.Models.CategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
