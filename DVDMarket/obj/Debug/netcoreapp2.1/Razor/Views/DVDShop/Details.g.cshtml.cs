#pragma checksum "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e923db0906211424f3e9ac1a3abbf00151359b98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DVDShop_Details), @"mvc.1.0.view", @"/Views/DVDShop/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DVDShop/Details.cshtml", typeof(AspNetCore.Views_DVDShop_Details))]
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
#line 8 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
using DVDMarket.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e923db0906211424f3e9ac1a3abbf00151359b98", @"/Views/DVDShop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4f07274e6063b32dbfa2e6db977ce809043860e", @"/Views/_ViewImports.cshtml")]
    public class Views_DVDShop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DVDMarket.Models.DVDModel>
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
  
    ViewData["Title"] = "Details DVD Product";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(202, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
  
    var member = context.MemberModel.Where(s => s.MemberEmail == User.Identity.Name)
                        .SingleOrDefault();

    var permission = false;
    if (member != null)
    {
        if (!"Customer".Equals(member.Permission))
        {
            permission = true;
        }
    }

#line default
#line hidden
            BeginContext(518, 222, true);
            WriteLiteral("\r\n<h2>Details DVD Product</h2>\r\n\r\n<div>\r\n    <h4>DVD Database</h4>\r\n    <hr />\r\n    <div style=\"text-align: left;\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(741, 41, false);
#line 34 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(782, 27, true);
            WriteLiteral(" :  [\r\n                    ");
            EndContext();
            BeginContext(810, 37, false);
#line 35 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(847, 168, true);
            WriteLiteral(" ]\r\n                </h3>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(1016, 41, false);
#line 42 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Actor));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 27, true);
            WriteLiteral(" :  [\r\n                    ");
            EndContext();
            BeginContext(1085, 37, false);
#line 43 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayFor(model => model.Actor));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 140, true);
            WriteLiteral(" ]\r\n                </h3>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h3>\r\n                    Actor Count :\r\n");
            EndContext();
            BeginContext(1311, 23, false);
#line 50 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
                   Write(ViewData["Actor_Count"]);

#line default
#line hidden
            EndContext();
#line 50 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
                                                ;
                    

#line default
#line hidden
            BeginContext(1360, 164, true);
            WriteLiteral("                </h3>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(1525, 44, false);
#line 58 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Producer));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 27, true);
            WriteLiteral(" :  [\r\n                    ");
            EndContext();
            BeginContext(1597, 40, false);
#line 59 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayFor(model => model.Producer));

#line default
#line hidden
            EndContext();
            BeginContext(1637, 125, true);
            WriteLiteral(" ]\r\n                </h3>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(1763, 40, false);
#line 64 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Cast));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 27, true);
            WriteLiteral(" :  [\r\n                    ");
            EndContext();
            BeginContext(1831, 36, false);
#line 65 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayFor(model => model.Cast));

#line default
#line hidden
            EndContext();
            BeginContext(1867, 168, true);
            WriteLiteral(" ]\r\n                </h3>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(2036, 39, false);
#line 72 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Url));

#line default
#line hidden
            EndContext();
            BeginContext(2075, 27, true);
            WriteLiteral(" :  [\r\n                    ");
            EndContext();
            BeginContext(2103, 35, false);
#line 73 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayFor(model => model.Url));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 125, true);
            WriteLiteral(" ]\r\n                </h3>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(2264, 42, false);
#line 78 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Studio));

#line default
#line hidden
            EndContext();
            BeginContext(2306, 27, true);
            WriteLiteral(" :  [\r\n                    ");
            EndContext();
            BeginContext(2334, 38, false);
#line 79 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayFor(model => model.Studio));

#line default
#line hidden
            EndContext();
            BeginContext(2372, 168, true);
            WriteLiteral(" ]\r\n                </h3>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(2541, 42, false);
#line 86 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Copies));

#line default
#line hidden
            EndContext();
            BeginContext(2583, 27, true);
            WriteLiteral(" :  [\r\n                    ");
            EndContext();
            BeginContext(2611, 38, false);
#line 87 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayFor(model => model.Copies));

#line default
#line hidden
            EndContext();
            BeginContext(2649, 125, true);
            WriteLiteral(" ]\r\n                </h3>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(2775, 44, false);
#line 92 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Released));

#line default
#line hidden
            EndContext();
            BeginContext(2819, 27, true);
            WriteLiteral(" :  [\r\n                    ");
            EndContext();
            BeginContext(2847, 40, false);
#line 93 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
               Write(Html.DisplayFor(model => model.Released));

#line default
#line hidden
            EndContext();
            BeginContext(2887, 126, true);
            WriteLiteral(" ]\r\n                </h3>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\">\r\n");
            EndContext();
#line 99 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
                 if ("Permission".Equals(@ViewData["PermissionAge"]))
                {

#line default
#line hidden
            BeginContext(3103, 100, true);
            WriteLiteral("                    <h3>\r\n                        To Under Of 18 Ages :  [\r\n                        ");
            EndContext();
            BeginContext(3204, 25, false);
#line 103 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
                   Write(ViewData["PermissionAge"]);

#line default
#line hidden
            EndContext();
            BeginContext(3229, 31, true);
            WriteLiteral(" ]\r\n                    </h3>\r\n");
            EndContext();
#line 105 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3320, 167, true);
            WriteLiteral("                    <h3 style=\"background: darkred; color: white; padding: 10px 0 10px 0;\">\r\n                        To Under Of 18 Ages :  [\r\n                        ");
            EndContext();
            BeginContext(3488, 25, false);
#line 110 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
                   Write(ViewData["PermissionAge"]);

#line default
#line hidden
            EndContext();
            BeginContext(3513, 31, true);
            WriteLiteral(" ]\r\n                    </h3>\r\n");
            EndContext();
#line 112 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(3563, 171, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\" style=\"padding: 30px 0 30px 0;\">\r\n    <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 121 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
             if (User.Identity.Name == "admin@admin.com" || permission == true)
            {

#line default
#line hidden
            BeginContext(3830, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3846, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "721a09375adb40cc8bb3f309072f65d3", async() => {
                BeginContext(3925, 4, true);
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
#line 123 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
                                       WriteLiteral(Model.Id);

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
            BeginContext(3933, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 124 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3983, 81, true);
            WriteLiteral("                <button class=\"btn btn-success col-md-8\" disabled>Edit</button>\r\n");
            EndContext();
#line 128 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDShop\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(4079, 83, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(4162, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35c5209d687245b7bf99dff24ab16329", async() => {
                BeginContext(4217, 12, true);
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
            BeginContext(4233, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDbContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DVDMarket.Models.DVDModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
