#pragma checksum "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6716cd9c2148253b6729df5ba42aa4ec53d86d06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
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
#line 4 "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/Index.cshtml"
using ToDoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6716cd9c2148253b6729df5ba42aa4ec53d86d06", @"/Views/Items/Index.cshtml")]
    #nullable restore
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>List of Items</h1>\n");
#nullable restore
#line 6 "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>Sorry No items to be listed!</p>\n");
#nullable restore
#line 9 "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 11 "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/Index.cshtml"
 foreach (Item item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>");
#nullable restore
#line 13 "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/Index.cshtml"
Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 14 "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/Index.cshtml"
  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
