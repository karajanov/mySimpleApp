#pragma checksum "C:\Users\Borjan\Desktop\mySimpleApp\SimpleCoreApp\SimpleCoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6fd830d05bea742a2fb0dc4e930beec0db11bae"
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
#line 1 "C:\Users\Borjan\Desktop\mySimpleApp\SimpleCoreApp\SimpleCoreApp\Views\_ViewImports.cshtml"
using SimpleCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Borjan\Desktop\mySimpleApp\SimpleCoreApp\SimpleCoreApp\Views\_ViewImports.cshtml"
using SimpleCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6fd830d05bea742a2fb0dc4e930beec0db11bae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa0f41f6bbea8a72e320468c68aeb0481d695d91", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Borjan\Desktop\mySimpleApp\SimpleCoreApp\SimpleCoreApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

    var categoryList = (ViewBag.CategoryTitles as List<Categories>);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<h1>Generic Categories</h1>\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Borjan\Desktop\mySimpleApp\SimpleCoreApp\SimpleCoreApp\Views\Home\Index.cshtml"
 if (categoryList != null && categoryList.Count != 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-hover\">\r\n        <thead>\r\n            <tr class=\"table-primary\">\r\n                <th scope=\"col\">Category</th>\r\n                <th scope=\"col\">Products List</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\Borjan\Desktop\mySimpleApp\SimpleCoreApp\SimpleCoreApp\Views\Home\Index.cshtml"
             foreach (var item in categoryList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Borjan\Desktop\mySimpleApp\SimpleCoreApp\SimpleCoreApp\Views\Home\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 655, "\"", 716, 1);
#nullable restore
#line 29 "C:\Users\Borjan\Desktop\mySimpleApp\SimpleCoreApp\SimpleCoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 662, Url.Action("List", "Products", new { id = @item.Id }), 662, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Display List</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Borjan\Desktop\mySimpleApp\SimpleCoreApp\SimpleCoreApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 35 "C:\Users\Borjan\Desktop\mySimpleApp\SimpleCoreApp\SimpleCoreApp\Views\Home\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"text-warning\">No Categories Found</h4>\r\n");
#nullable restore
#line 40 "C:\Users\Borjan\Desktop\mySimpleApp\SimpleCoreApp\SimpleCoreApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
