#pragma checksum "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af70d55cb9f2dc823f13887b62c938c7f09307c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowProductList), @"mvc.1.0.view", @"/Views/Product/ShowProductList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af70d55cb9f2dc823f13887b62c938c7f09307c3", @"/Views/Product/ShowProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81f263e1772099451cb23423b0f2e82ec412f498", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ModelsLibary.ProductModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
  
    ViewData["Title"] = "ShowProductList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ShowProductList</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 10 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
Write(Html.ActionLink("Back","ShowStoreList","Store"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.Product_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.Product_Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.Product_Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.Product_Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.LocationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n \r\n <tbody>      \r\n");
#nullable restore
#line 40 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product_Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                $");
#nullable restore
#line 52 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
            Write(Html.DisplayFor(modelItem => item.Product_Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product_Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.LocationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
           Write(Html.ActionLink("Buy", "ProductInfoCart","Cart", item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
}    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n        ");
#nullable restore
#line 68 "C:\Users\Guillermo\Desktop\P1Project\P1Shop\Views\Product\ShowProductList.cshtml"
   Write(Html.ActionLink("Stop Shopping", "CartList","Cart"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ModelsLibary.ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
