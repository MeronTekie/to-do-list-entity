#pragma checksum "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ed580b5bd43d6b20fcf0af38d9833ca7776fe61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_New), @"mvc.1.0.view", @"/Views/Items/New.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ed580b5bd43d6b20fcf0af38d9833ca7776fe61", @"/Views/Items/New.cshtml")]
    #nullable restore
    public class Views_Items_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Add a new item to ");
#nullable restore
#line 5 "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/New.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<form");
            BeginWriteAttribute("action", " action=\"", 73, "\"", 109, 3);
            WriteAttributeValue("", 82, "/categories/", 82, 12, true);
#nullable restore
#line 7 "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/New.cshtml"
WriteAttributeValue("", 94, Model.Id, 94, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 103, "/items", 103, 6, true);
            EndWriteAttribute();
            WriteLiteral(" method=\"post\">\n  <input id=\"categoryId\" name=\"categoryId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 182, "\"", 199, 1);
#nullable restore
#line 8 "/Users/ramenimo/Desktop/to-do-list-db/ToDoList/Views/Items/New.cshtml"
WriteAttributeValue("", 190, Model.Id, 190, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n  <label for=\"itemDescription\">Item Description</label>\n  <input id=\"itemDescription\" name=\"itemDescription\" type=\"text\">\n  <button type=\'submit\'>Add Item</button>\n</form>");
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
