#pragma checksum "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d924792b21b07159b2b724d41f9598d8dcb97f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetails_OrderDetails), @"mvc.1.0.view", @"/Views/OrderDetails/OrderDetails.cshtml")]
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
#line 1 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\_ViewImports.cshtml"
using P1Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\_ViewImports.cshtml"
using P1Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d924792b21b07159b2b724d41f9598d8dcb97f3", @"/Views/OrderDetails/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81f263e1772099451cb23423b0f2e82ec412f498", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderDetails_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ModelsLibary.OrderDetailModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
  
    ViewData["Title"] = "OrderDetails";
    decimal total = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>OrderDetails</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Obtain_Qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Total_Qty_Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Obtain_Qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                $");
#nullable restore
#line 42 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
            Write(Html.DisplayFor(modelItem => item.Total_Qty_Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 45 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
                        
                        total += item.Total_Qty_Price;
                   

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<p><b>Total Amount:</b>$");
#nullable restore
#line 53 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\OrderDetails\OrderDetails.cshtml"
                   Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ModelsLibary.OrderDetailModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
