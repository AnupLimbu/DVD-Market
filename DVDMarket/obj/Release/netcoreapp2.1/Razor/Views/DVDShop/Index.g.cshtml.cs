#pragma checksum "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8070ae67283cd5904424c2ddd62d8df3579a5a51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DVDShop_Index), @"mvc.1.0.view", @"/Views/DVDShop/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DVDShop/Index.cshtml", typeof(AspNetCore.Views_DVDShop_Index))]
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
#line 1 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\_ViewImports.cshtml"
using DVDMarket;

#line default
#line hidden
#line 2 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\_ViewImports.cshtml"
using DVDMarket.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8070ae67283cd5904424c2ddd62d8df3579a5a51", @"/Views/DVDShop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4f07274e6063b32dbfa2e6db977ce809043860e", @"/Views/_ViewImports.cshtml")]
    public class Views_DVDShop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DVDMarket.Models.DVDModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
  
    ViewData["Title"] = "DVD Shop";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 124, true);
            WriteLiteral("\r\n<h2>DVD Shop</h2>\r\n\r\n<div class=\"row\" style=\"padding: 10px 0px 10px 0px; text-align: left;\">\r\n    <div class=\"col-md-6\">\r\n");
            EndContext();
            BeginContext(307, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(315, 531, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d84729ac631449db06c32e8f7b4a708", async() => {
                BeginContext(373, 186, true);
                WriteLiteral("\r\n            <div class=\"input-group\">\r\n                <span class=\"input-group-addon\">Find by Actor</span>\r\n                <input type=\"text\" class=\"form-control\" name=\"searchString\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 559, "\"", 593, 1);
#line 16 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
WriteAttributeValue("", 567, ViewData["CurrentFilter"], 567, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(594, 245, true);
                WriteLiteral(" placeholder=\"Search...\">\r\n                <div class=\"input-group-btn\">\r\n                    <button class=\"btn btn-default\" type=\"submit\"><i class=\"glyphicon glyphicon-search\"></i></button>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(846, 69, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\" style=\"text-align: right;\">\r\n");
            EndContext();
#line 25 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
             if (User.Identity.Name == "admin@admin.com")
            {

#line default
#line hidden
            BeginContext(1001, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1017, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d82083d6d7414491b99c853e1851b45f", async() => {
                BeginContext(1061, 15, true);
                WriteLiteral("New DVD Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1080, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1108, 245, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<table class=\"table\" style=\"font-size: 1.5em;\">\r\n    <thead>\r\n        <tr>\r\n            <th style=\"text-align: center;\">\r\n                No\r\n            </th>\r\n            <th style=\"text-align: center;\">\r\n                ");
            EndContext();
            BeginContext(1354, 41, false);
#line 40 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Actor));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 83, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align: center;\">\r\n                ");
            EndContext();
            BeginContext(1479, 41, false);
#line 43 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 83, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align: center;\">\r\n                ");
            EndContext();
            BeginContext(1604, 39, false);
#line 46 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Url));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 83, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align: center;\">\r\n                ");
            EndContext();
            BeginContext(1727, 45, false);
#line 49 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Productor));

#line default
#line hidden
            EndContext();
            BeginContext(1772, 83, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align: center;\">\r\n                ");
            EndContext();
            BeginContext(1856, 42, false);
#line 52 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Studio));

#line default
#line hidden
            EndContext();
            BeginContext(1898, 83, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align: center;\">\r\n                ");
            EndContext();
            BeginContext(1981, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32aa4a0e51ec46539669760a4a8629ee", async() => {
                BeginContext(2057, 44, false);
#line 55 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
                                                                                      Write(Html.DisplayNameFor(model => model.Released));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
                                               WriteLiteral(ViewData["ReleasedSortParam"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2105, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 61 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
          
            var noIndex = 0;
        

#line default
#line hidden
            BeginContext(2244, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 64 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
         foreach (var item in Model)
        {
            noIndex++;

#line default
#line hidden
            BeginContext(2317, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2332, "\"", 2349, 2);
            WriteAttributeValue("", 2337, "dvd_", 2337, 4, true);
#line 67 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
WriteAttributeValue("", 2341, item.Id, 2341, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2350, "\"", 2381, 3);
            WriteAttributeValue("", 2360, "setDvdIndex(", 2360, 12, true);
#line 67 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
WriteAttributeValue("", 2372, item.Id, 2372, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2380, ")", 2380, 1, true);
            EndWriteAttribute();
            BeginContext(2382, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2428, 7, false);
#line 69 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
               Write(noIndex);

#line default
#line hidden
            EndContext();
            BeginContext(2435, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2503, 40, false);
#line 72 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Actor));

#line default
#line hidden
            EndContext();
            BeginContext(2543, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2611, 40, false);
#line 75 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(2651, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2719, 38, false);
#line 78 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Url));

#line default
#line hidden
            EndContext();
            BeginContext(2757, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2825, 44, false);
#line 81 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Productor));

#line default
#line hidden
            EndContext();
            BeginContext(2869, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2937, 41, false);
#line 84 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Studio));

#line default
#line hidden
            EndContext();
            BeginContext(2978, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
            BeginContext(3074, 33, false);
#line 88 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
                   Write(item.Released.ToShortDateString());

#line default
#line hidden
            EndContext();
#line 88 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
                                                          ;
                    

#line default
#line hidden
            BeginContext(3133, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 92 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
                     if (User.Identity.Name == "admin@admin.com")
                    {

#line default
#line hidden
            BeginContext(3268, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3292, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbf838c484804948963f4810ad06cffa", async() => {
                BeginContext(3361, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3369, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3395, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76438174b7d246d18cfed82297245e08", async() => {
                BeginContext(3467, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3478, 137, true);
            WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#questionModal\">Delete</button>\r\n");
            EndContext();
#line 97 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3687, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3711, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3caacf789c55447f937057b23e603679", async() => {
                BeginContext(3783, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3794, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 101 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3819, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 104 "E:\Freelance_WWW\DVD-Shop@ASP.NET\03_Project\DVDMarket_Core2.1\DVDMarket\Views\DVDShop\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3872, 892, true);
            WriteLiteral(@"    </tbody>
</table>

<!-- Question Modal -->
<div class=""modal fade"" id=""questionModal"" role=""dialog"" data-bind=""id"">
    <div class=""modal-dialog modal-md"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h2 class=""modal-title"" style=""color: #0094ff"">Question</h2>
            </div>
            <div class=""modal-body"">
                <h4 style=""color: #ff0000"">You want to delete this data. Really?</h4>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"" onclick=""removeDvd()"">Delete</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DVDMarket.Models.DVDModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
