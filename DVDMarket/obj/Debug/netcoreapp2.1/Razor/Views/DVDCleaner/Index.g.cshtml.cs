#pragma checksum "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d916fc1c8ee89c39a4a8e2ed1373aa3f9d7d2de7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DVDCleaner_Index), @"mvc.1.0.view", @"/Views/DVDCleaner/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DVDCleaner/Index.cshtml", typeof(AspNetCore.Views_DVDCleaner_Index))]
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
#line 8 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
using DVDMarket.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d916fc1c8ee89c39a4a8e2ed1373aa3f9d7d2de7", @"/Views/DVDCleaner/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4f07274e6063b32dbfa2e6db977ce809043860e", @"/Views/_ViewImports.cshtml")]
    public class Views_DVDCleaner_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DVDMarket.Models.DVDModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(201, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
  
    var today = DateTime.Today;
    var noIndexYear = 0;
    var noIndexMonth = 0;
    var members = context.MemberModel;
    var loans = context.LoanModel;
  

#line default
#line hidden
            BeginContext(376, 333, true);
            WriteLiteral(@"<h2>DVD Manager</h2>

<div class=""row"" style=""padding: 0 0 20px 0;"">
    <div class=""col-md-4"">
        <h3>- DVD older than 365 Days and currently not on Loan</h3>
    </div>
</div>

<table class=""table"">
    <thead>
        <tr>
            <th>
                No
            </th>
            <th>
                ");
            EndContext();
            BeginContext(710, 41, false);
#line 34 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(751, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(807, 41, false);
#line 37 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Actor));

#line default
#line hidden
            EndContext();
            BeginContext(848, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(904, 44, false);
#line 40 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Producer));

#line default
#line hidden
            EndContext();
            BeginContext(948, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1004, 42, false);
#line 43 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Studio));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1102, 40, false);
#line 46 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cast));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1198, 44, false);
#line 49 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Released));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 55 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
         foreach (var item in Model)
        {
            if (today.Subtract(item.Released).TotalDays > 365 && item.Master==false)
            {
                noIndexYear++;

#line default
#line hidden
            BeginContext(1510, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1529, "\"", 1551, 2);
            WriteAttributeValue("", 1534, "year_", 1534, 5, true);
#line 60 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
WriteAttributeValue("", 1539, noIndexYear, 1539, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1552, 53, true);
            WriteLiteral(">\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1606, 11, false);
#line 62 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
                   Write(noIndexYear);

#line default
#line hidden
            EndContext();
            BeginContext(1617, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1697, 40, false);
#line 65 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1737, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1817, 40, false);
#line 68 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Actor));

#line default
#line hidden
            EndContext();
            BeginContext(1857, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1937, 43, false);
#line 71 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Producer));

#line default
#line hidden
            EndContext();
            BeginContext(1980, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2060, 41, false);
#line 74 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Studio));

#line default
#line hidden
            EndContext();
            BeginContext(2101, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2181, 39, false);
#line 77 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cast));

#line default
#line hidden
            EndContext();
            BeginContext(2220, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2300, 33, false);
#line 80 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
                   Write(item.Released.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2333, 105, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 85 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(2464, 200, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"row\" style=\"padding: 0 0 50px 0; border-bottom: 2px dashed gray;\">\r\n    <h3 style=\"text-align: right;\">\r\n        <button class=\"btn btn-danger\" style=\"width: 100%;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2664, "\"", 2704, 3);
            WriteAttributeValue("", 2674, "deleteAll365Days(", 2674, 17, true);
#line 91 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
WriteAttributeValue("", 2691, noIndexYear, 2691, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2703, ")", 2703, 1, true);
            EndWriteAttribute();
            BeginContext(2705, 500, true);
            WriteLiteral(@">Delete All</button>
    </h3>
</div>

<br />
<h3>
Users that have not rented in the past 31 days
</h3>

<table class=""table"">
    <thead>
        <tr>
            <th>
                No
            </th>
            <th>
                Name
            </th>
            <th>
                Email
            </th>
          
            <th>
                Last time the User Loaned 
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>

");
            EndContext();
#line 121 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
         foreach (var item in members)
        {
            
             noIndexMonth++;

#line default
#line hidden
            BeginContext(3300, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3311, "\"", 3335, 2);
            WriteAttributeValue("", 3316, "month_", 3316, 6, true);
#line 125 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
WriteAttributeValue("", 3322, noIndexMonth, 3322, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3336, "\"", 3396, 5);
            WriteAttributeValue("", 3346, "setMemberIndex(", 3346, 15, true);
#line 125 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
WriteAttributeValue("", 3361, item.MemberStockId, 3361, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 3380, ",", 3380, 1, true);
#line 125 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
WriteAttributeValue(" ", 3381, noIndexMonth, 3382, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3395, ")", 3395, 1, true);
            EndWriteAttribute();
            BeginContext(3397, 37, true);
            WriteLiteral(">\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3435, 12, false);
#line 127 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
           Write(noIndexMonth);

#line default
#line hidden
            EndContext();
            BeginContext(3447, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3503, 45, false);
#line 130 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MemberName));

#line default
#line hidden
            EndContext();
            BeginContext(3548, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3604, 46, false);
#line 133 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MemberEmail));

#line default
#line hidden
            EndContext();
            BeginContext(3650, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 135 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
             if (loans.Where(s => s.MemberEmail == item.MemberEmail).ToArray().Count() > 0)
            {
                var date = loans.Where(s => s.MemberEmail == item.MemberEmail).OrderByDescending(s => s.BorrowDate).First();
                var title = loans.Where(s => s.MemberEmail == item.MemberEmail).OrderByDescending(s => s.BorrowDate).First().Dvd.Title;
                DateTime days = loans.Where(s => s.MemberEmail == item.MemberEmail).OrderByDescending(s => s.BorrowDate).First().BorrowDate;
                var CopyNo = loans.Where(s => s.MemberEmail == item.MemberEmail).OrderByDescending(s => s.BorrowDate).First().Dvd.Copies;


                if (days > DateTime.Today.AddDays(-31))
                {

#line default
#line hidden
            BeginContext(4403, 80, true);
            WriteLiteral("                    <td>\r\n                        <p>Loaned in the last 31 days ");
            EndContext();
            BeginContext(4484, 4, false);
#line 146 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
                                                 Write(days);

#line default
#line hidden
            EndContext();
            BeginContext(4488, 33, true);
            WriteLiteral("</p>\r\n                    </td>\r\n");
            EndContext();
#line 148 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(4555, 179, true);
            WriteLiteral("            <td>\r\n                <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#questionModal\">Remove</button>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 154 "E:\Islington\Application develpoment\testAD\DVDMarket\DVDMarket\Views\DVDCleaner\Index.cshtml"
                            
                        }

#line default
#line hidden
            BeginContext(4791, 903, true);
            WriteLiteral(@"
        </tbody>
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
                <h4 style=""color: #ff0000"">You want to remove this member. Really?</h4>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"" onclick=""removeMember()"">Remove</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DVDMarket.Models.DVDModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591