#pragma checksum "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "138ac6e9b801830941a862151920a90e999815f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"138ac6e9b801830941a862151920a90e999815f1", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22da013e5296003d6ba6ad9b49900c2b62127693", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetConstructBlog.Models.View.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container blog-list\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\Home\Home.cshtml"
         foreach (var blog in Model.Blogs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-md-6\">\r\n");
#nullable restore
#line 12 "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\Home\Home.cshtml"
                   await Html.RenderPartialAsync("Partials/_BlogItem", blog); 

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 14 "C:\Users\Ben.Asquith\Desktop\Publish\NetConstruct\NetConstructBlog\NetConstructBlog\Views\Home\Home.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetConstructBlog.Models.View.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591