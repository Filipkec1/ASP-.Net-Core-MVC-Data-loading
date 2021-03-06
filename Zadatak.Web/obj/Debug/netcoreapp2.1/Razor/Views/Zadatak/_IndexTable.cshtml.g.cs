#pragma checksum "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3928c06fafeed23e1e8ee81d7993b4df00d87acf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zadatak__IndexTable), @"mvc.1.0.view", @"/Views/Zadatak/_IndexTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Zadatak/_IndexTable.cshtml", typeof(AspNetCore.Views_Zadatak__IndexTable))]
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
#line 1 "C:\Span\Zadatak.Web\Views\_ViewImports.cshtml"
using Zadatak.Web;

#line default
#line hidden
#line 2 "C:\Span\Zadatak.Web\Views\_ViewImports.cshtml"
using Zadatak.Web.Models;

#line default
#line hidden
#line 3 "C:\Span\Zadatak.Web\Views\_ViewImports.cshtml"
using Zadatak.DAL;

#line default
#line hidden
#line 4 "C:\Span\Zadatak.Web\Views\_ViewImports.cshtml"
using Zadatak.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3928c06fafeed23e1e8ee81d7993b4df00d87acf", @"/Views/Zadatak/_IndexTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0ca4deae9e95a527e1ecc9490c1e2261e8e5776", @"/Views/_ViewImports.cshtml")]
    public class Views_Zadatak__IndexTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 382, true);
            WriteLiteral(@"
<table style=""margin-top: 20px;"" class=""table table-condensed"" id=""TablePeople"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Ime</th>
            <th>Prezime</th>
            <th>Grad</th>
            <th>Postanski broj</th>
            <th>Broj mobitela</th>
            <th> </th>
            <th> </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 17 "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(452, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(491, 7, false);
#line 20 "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml"
               Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(498, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(526, 14, false);
#line 21 "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml"
               Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(540, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(568, 13, false);
#line 22 "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml"
               Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(581, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(609, 13, false);
#line 23 "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml"
               Write(item.CityName);

#line default
#line hidden
            EndContext();
            BeginContext(622, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(650, 15, false);
#line 24 "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml"
               Write(item.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(665, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(693, 17, false);
#line 25 "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml"
               Write(item.MobileNumber);

#line default
#line hidden
            EndContext();
            BeginContext(710, 116, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <button type=\"button\" class=\"btn btn-toolbar EditButton\" data-url=\"");
            EndContext();
            BeginContext(827, 28, false);
#line 27 "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml"
                                                                                  Write(Url.Action("Edit","Zadatak"));

#line default
#line hidden
            EndContext();
            BeginContext(855, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(857, 7, false);
#line 27 "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml"
                                                                                                                Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(864, 205, true);
            WriteLiteral("\">\r\n                        Uredi osobu\r\n                    </button>\r\n                </td>\r\n                <td>\r\n                    <button type=\"submit\" class=\"btn btn-danger DeleteButton\" data-url=\"");
            EndContext();
            BeginContext(1070, 30, false);
#line 32 "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml"
                                                                                   Write(Url.Action("Delete","Zadatak"));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(1102, 7, false);
#line 32 "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml"
                                                                                                                   Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1109, 115, true);
            WriteLiteral("\">\r\n                        Obriši osobu\r\n                    </button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 37 "C:\Span\Zadatak.Web\Views\Zadatak\_IndexTable.cshtml"
        }

#line default
#line hidden
            BeginContext(1235, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
