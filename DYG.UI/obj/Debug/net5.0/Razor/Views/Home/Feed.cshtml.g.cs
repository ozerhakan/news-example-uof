#pragma checksum "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Feed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b266b494feea08146962a9279a57253edb7f1b20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Feed), @"mvc.1.0.view", @"/Views/Home/Feed.cshtml")]
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
#line 1 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Feed.cshtml"
using DYG.UI.Domain.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b266b494feea08146962a9279a57253edb7f1b20", @"/Views/Home/Feed.cshtml")]
    public class Views_Home_Feed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DYG.Domain.DTO.NewsDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Feed.cshtml"
  
    var newsList = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container pb-5 mt-n2 mt-md-n3\">\n    <div class=\"row\">\n        <div class=\"col-xl-9 col-md-8\">\n");
#nullable restore
#line 9 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Feed.cshtml"
            foreach(var news in newsList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-sm-flex justify-content-between my-4 pb-4 border-bottom\">\n            <div class=\"media d-block d-sm-flex text-center text-sm-left\">\n                <a class=\"cart-item-thumb mx-auto mr-sm-4\"><img width=\"300\" height=\"300\"");
            BeginWriteAttribute("src", " src=\"", 493, "\"", 515, 1);
#nullable restore
#line 13 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Feed.cshtml"
WriteAttributeValue("", 499, news.MainArtUrl, 499, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product\"></a>\n                <div class=\"media-body pt-3\">\n                    <h3 class=\"product-card-title font-weight-semibold border-0 pb-0\"><a");
            BeginWriteAttribute("href", " href=\"", 670, "\"", 790, 1);
#nullable restore
#line 15 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Feed.cshtml"
WriteAttributeValue("", 677, Url.Action("Detail","Home",new { mainCategory= news.MainCategory?.Slug,title= news.Title.ToLink(), id= news.Id}), 677, 113, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Feed.cshtml"
                                                                                                                                                                                                             Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\n                    <div class=\"font-size-sm\"><span class=\"text-muted mr-2\">");
#nullable restore
#line 16 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Feed.cshtml"
                                                                       Write(news.Spot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 20 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Feed.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DYG.Domain.DTO.NewsDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
