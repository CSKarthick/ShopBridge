#pragma checksum "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3027d91d09e17cee8d3c2f93af68dc70fb17bb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\_ViewImports.cshtml"
using ShopBridge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\_ViewImports.cshtml"
using ShopBridge.Base;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\_ViewImports.cshtml"
using ShopBridge.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\_ViewImports.cshtml"
using ShopBridge.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3027d91d09e17cee8d3c2f93af68dc70fb17bb3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ae84b4144181fc857297643737193c6b85d57ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/product.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Product List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3027d91d09e17cee8d3c2f93af68dc70fb17bb34467", async() => {
                WriteLiteral("\r\n    <title>Product List</title>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3027d91d09e17cee8d3c2f93af68dc70fb17bb35472", async() => {
                WriteLiteral(@"
    <div class=""col-md-12 p-a-0 content-body"">
        <a class=""act-btn addProduct text-right"" href=""/Home/ProductEditor"" title=""Add""><i class=""fa fa-plus""></i> Add Product</a>
        <table id=""product-table"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead>
                <tr>
                    <th hidden></th>
                    <th>Product Name</th>
                    <th>Product Description</th>
                    <th class=""text-right"">MRP Rate(₹)</th>
                    <th class=""text-right"">Selling Price(₹)</th>
                    <th class=""text-right"">Quantity</th>
                    <th>Product Unit</th>
                    <th>Status</th>
                    <th> Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 29 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
                 foreach (var produt in Model.ProductInformationList)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td hidden class=\"Id\">");
#nullable restore
#line 32 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
                                         Write(produt.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"</td>\r\n                        <td class=\"name\">");
#nullable restore
#line 33 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
                                    Write(produt.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td class=\"desc\">");
#nullable restore
#line 34 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
                                    Write(produt.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td class=\"mrpRate text-right\">");
#nullable restore
#line 35 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
                                                  Write(produt.MRPRate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td class=\"sellingPrice text-right\">");
#nullable restore
#line 36 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
                                                       Write(produt.SellingPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td class=\"quantity text-right\">");
#nullable restore
#line 37 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
                                                   Write(produt.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td class=\"unit\">");
#nullable restore
#line 38 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
                                    Write(produt.BaseUnit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td class=\"status\">");
#nullable restore
#line 39 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
                                      Write(produt.ProductStatus);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td class=\"action\">\r\n                            <a class=\"act-btn editProduct\"");
                BeginWriteAttribute("href", " href=\"", 1759, "\"", 1813, 2);
                WriteAttributeValue("", 1766, "/Home/ProductEditor?productId=", 1766, 30, true);
#nullable restore
#line 41 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
WriteAttributeValue("", 1796, produt.ProductId, 1796, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" title=\"Edit\"><i class=\"fa fa-pencil\"></i></a>\r\n                            <a class=\"act-btn deleteProduct pull-right\"");
                BeginWriteAttribute("href", " href=\"", 1933, "\"", 1988, 2);
                WriteAttributeValue("", 1940, "/Home/DeleteProduct?idToDelete=", 1940, 31, true);
#nullable restore
#line 42 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
WriteAttributeValue("", 1971, produt.ProductId, 1971, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" title=\"Remove\"><i class=\"fa fa-trash\"></i></a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 45 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3027d91d09e17cee8d3c2f93af68dc70fb17bb311888", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 51 "D:\WebProject\OwnProject\ShopBridge\ShopBridge.WebApp\ShopBridge\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
