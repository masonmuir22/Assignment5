#pragma checksum "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d66be4c4b399e604f6c327565c35ff9c3fcfb09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Assignment5.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
namespace Assignment5.Pages
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
#line 2 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/_ViewImports.cshtml"
using Assignment5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/_ViewImports.cshtml"
using Assignment5.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d66be4c4b399e604f6c327565c35ff9c3fcfb09", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31be41990995fdcba6145271dfb55c96b912387f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<h2>Your Cart</h2>\n\n<table class=\"table table-bordered table-striped\">\n\n    <thead>\n        <tr>\n            <th>Book</th>\n            <th>Quantity</th>\n            <th>Price</th>\n            <th>Subtotal</th>\n        </tr>\n\n        <tbody>\n");
#nullable restore
#line 20 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/Cart.cshtml"
             foreach(var line in Model.Cart.Lines)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td class=\"text-left\">");
#nullable restore
#line 23 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/Cart.cshtml"
                                 Write(line.Books.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-center\">");
#nullable restore
#line 24 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/Cart.cshtml"
                                   Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-right\">");
#nullable restore
#line 25 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/Cart.cshtml"
                                  Write(line.Books.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-right\">$");
#nullable restore
#line 26 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/Cart.cshtml"
                                    Write((line.Books.Price * line.Quantity).ToString(""));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-center\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d66be4c4b399e604f6c327565c35ff9c3fcfb095659", async() => {
                WriteLiteral("\n                        <input type=\"hidden\" name=\"BookID\"");
                BeginWriteAttribute("value", "\n                               value=\"", 816, "\"", 873, 1);
#nullable restore
#line 30 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/Cart.cshtml"
WriteAttributeValue("", 855, line.Books.BookID, 855, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", "\n                               value=\"", 939, "\"", 994, 1);
#nullable restore
#line 32 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/Cart.cshtml"
WriteAttributeValue("", 978, Model.ReturnUrl, 978, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">\n                            Remove\n                        </button>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 39 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/Cart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n\n    </thead>\n\n    <tfoot>\n        <tr>\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\n            <td class=\"text-right\">$");
#nullable restore
#line 47 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/Cart.cshtml"
                               Write(Model.Cart.ComputeTotalSum().ToString(""));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tfoot>\n\n</table>\n\n<div class=\"text-center\">\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1521, "\"", 1544, 1);
#nullable restore
#line 54 "/Users/masonmuir/Projects/Assignment5/Assignment5/Pages/Cart.cshtml"
WriteAttributeValue("", 1528, Model.ReturnUrl, 1528, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment5.Pages.CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Assignment5.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Assignment5.Pages.CartModel>)PageContext?.ViewData;
        public Assignment5.Pages.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591