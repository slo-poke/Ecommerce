#pragma checksum "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "007094ed0081b6f97bfea2c655b763c683be6f86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\_ViewImports.cshtml"
using ECommerce;

#line default
#line hidden
#line 2 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\_ViewImports.cshtml"
using ECommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"007094ed0081b6f97bfea2c655b763c683be6f86", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "NavPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0298c50c5328452cb8e3fc6dcf8f3a8e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(29, 31, true);
            WriteLiteral("\r\n\r\n<div class=\"sidebar\">\r\n    ");
            EndContext();
            BeginContext(60, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec75b8fef4884453a17b34eb47e481d9", async() => {
                BeginContext(97, 129, true);
                WriteLiteral("\r\n        <input type=\"text\" name=\"Search\" placeholder=\"Search...\" /><br />\r\n        <input type=\"submit\" value=\"Search\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            BeginContext(233, 76, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"main_content\">\r\n    <div class=\"products_preview\">\r\n");
            EndContext();
#line 12 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
          
            foreach (Product prod in ViewBag.Products)
            {

#line default
#line hidden
            BeginContext(392, 83, true);
            WriteLiteral("                <div class=\"product\">\r\n                    <img class=\"product_img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 475, "\"", 495, 1);
#line 16 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
WriteAttributeValue("", 481, prod.ImageUrl, 481, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 496, "\"", 519, 2);
#line 16 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
WriteAttributeValue("", 502, prod.Name, 502, 10, false);

#line default
#line hidden
            WriteAttributeValue("  ", 512, "Image", 514, 7, true);
            EndWriteAttribute();
            BeginContext(520, 28, true);
            WriteLiteral(" />\r\n                    <p>");
            EndContext();
            BeginContext(549, 9, false);
#line 17 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
                  Write(prod.Name);

#line default
#line hidden
            EndContext();
            BeginContext(558, 30, true);
            WriteLiteral("</p>\r\n                    <p>(");
            EndContext();
            BeginContext(589, 13, false);
#line 18 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
                   Write(prod.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(602, 36, true);
            WriteLiteral(" left)</p>\r\n                </div>\r\n");
            EndContext();
#line 20 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(664, 127, true);
            WriteLiteral("    </div>\r\n    <div class=\"recent_orders\">\r\n        <h3 style=\"text-decoration: underline;\">Recent Orders</h3>\r\n        <ul>\r\n");
            EndContext();
#line 26 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
           
            foreach(Order order in ViewBag.Orders)
            {

#line default
#line hidden
            BeginContext(871, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(892, 19, false);
#line 29 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
               Write(order.Customer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(911, 11, true);
            WriteLiteral(" purchased ");
            EndContext();
            BeginContext(923, 14, false);
#line 29 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
                                              Write(order.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(937, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(939, 18, false);
#line 29 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
                                                              Write(order.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(957, 3, true);
            WriteLiteral("  (");
            EndContext();
            BeginContext(961, 50, false);
#line 29 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
                                                                                    Write(String.Format("{0: MMMM d yyyy}", order.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 8, true);
            WriteLiteral(")</li>\r\n");
            EndContext();
#line 30 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1045, 142, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"new_customers\">\r\n        <h3 style=\"text-decoration: underline;\">New Customers</h3>\r\n        <ul>\r\n");
            EndContext();
#line 37 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
               
                foreach(Customer cust in ViewBag.Customers)
                {

#line default
#line hidden
            BeginContext(1284, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(1309, 9, false);
#line 40 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
                   Write(cust.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1318, 19, true);
            WriteLiteral(" joined the store (");
            EndContext();
            BeginContext(1338, 49, false);
#line 40 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
                                                Write(String.Format("{0: MMMM d yyyy}", cust.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 8, true);
            WriteLiteral(")</li>\r\n");
            EndContext();
#line 41 "D:\CodingDojo\C_Sharp\ORM\Entity\ECommerce\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1429, 33, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
