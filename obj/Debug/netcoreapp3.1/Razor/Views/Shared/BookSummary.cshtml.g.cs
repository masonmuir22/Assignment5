#pragma checksum "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/Shared/BookSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e153e526a588fb581681a9d9232285db20b9d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BookSummary), @"mvc.1.0.view", @"/Views/Shared/BookSummary.cshtml")]
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
#line 1 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/_ViewImports.cshtml"
using Assignment5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/_ViewImports.cshtml"
using Assignment5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/_ViewImports.cshtml"
using Assignment5.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e153e526a588fb581681a9d9232285db20b9d5", @"/Views/Shared/BookSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1206ecdea36fcb6ead1db6f88555177fef3dcbca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Books>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"bg-dark text-info\">\n    <h2>");
#nullable restore
#line 4 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/Shared/BookSummary.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <h3>");
#nullable restore
#line 5 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/Shared/BookSummary.cshtml"
   Write(Model.AuthorFirst);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/Shared/BookSummary.cshtml"
                      Write(Model.AuthorMiddle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/Shared/BookSummary.cshtml"
                                          Write(Model.AuthorLast);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <p>");
#nullable restore
#line 6 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/Shared/BookSummary.cshtml"
  Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>");
#nullable restore
#line 7 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/Shared/BookSummary.cshtml"
  Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>");
#nullable restore
#line 8 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/Shared/BookSummary.cshtml"
  Write(Model.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>");
#nullable restore
#line 9 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/Shared/BookSummary.cshtml"
  Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p class=\"list-group-item-dark\">");
#nullable restore
#line 10 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/Shared/BookSummary.cshtml"
                               Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>");
#nullable restore
#line 11 "/Users/masonmuir/Projects/Assignment5/Assignment5/Views/Shared/BookSummary.cshtml"
  Write(Model.NumPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Books> Html { get; private set; }
    }
}
#pragma warning restore 1591