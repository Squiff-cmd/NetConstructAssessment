#pragma checksum "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\Home\Partials\_BlogItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd2d3297080e6cd037f29a78d5e0729aa43aeb55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Partials__BlogItem), @"mvc.1.0.view", @"/Views/Home/Partials/_BlogItem.cshtml")]
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
#line 1 "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\_ViewImports.cshtml"
using NetConstructBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\_ViewImports.cshtml"
using NetConstructBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2d3297080e6cd037f29a78d5e0729aa43aeb55", @"/Views/Home/Partials/_BlogItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22da013e5296003d6ba6ad9b49900c2b62127693", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Partials__BlogItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetConstructBlog.Models.Data.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\Home\Partials\_BlogItem.cshtml"
  
    var postUrl = $"Post/{@Model.Id}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card blog-card mb-3\">\r\n    <div class=\"blog-card-image\"");
            BeginWriteAttribute("style", " style=\"", 160, "\"", 202, 3);
            WriteAttributeValue("", 168, "background-image:url(", 168, 21, true);
#nullable restore
#line 8 "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\Home\Partials\_BlogItem.cshtml"
WriteAttributeValue("", 189, Model.Image, 189, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 201, ")", 201, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\Home\Partials\_BlogItem.cshtml"
                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\Home\Partials\_BlogItem.cshtml"
                        Write(Html.Raw(@Model.Summary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\"><small class=\"text-muted\">Posted: ");
#nullable restore
#line 13 "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\Home\Partials\_BlogItem.cshtml"
                                                          Write(Model.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 475, "\"", 490, 1);
#nullable restore
#line 14 "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\Home\Partials\_BlogItem.cshtml"
WriteAttributeValue("", 482, postUrl, 482, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"stretched-link\"></a>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetConstructBlog.Models.Data.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591