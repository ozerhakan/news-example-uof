#pragma checksum "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d9bd2e89dab86b0a3a4396334d67e4fae773f64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/_ViewImports.cshtml"
using DYG.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/_ViewImports.cshtml"
using DYG.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
using DYG.UI.Domain.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9bd2e89dab86b0a3a4396334d67e4fae773f64", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9230e77f25e85444a66ddca9c72cfadc05202c21", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DYG.UI.DTO.NewsDTO>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
  
    var news = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html xmlns=\"http://www.w3.org/1999/html\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d9bd2e89dab86b0a3a4396334d67e4fae773f643557", async() => {
                WriteLiteral("\n    <title>");
#nullable restore
#line 11 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
      Write(news.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d9bd2e89dab86b0a3a4396334d67e4fae773f644734", async() => {
                WriteLiteral("\n<div class=\"container bootdey\">\n<div class=\"col-md-12\">\n<section class=\"panel\">\n      <div class=\"panel-body\">\n          <div class=\"col-md-6\">\n              <span> <strong>Url:</strong>  ");
#nullable restore
#line 19 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                                       Write(Helper.GetUrl(news.MainCategory.Slug,news.Title,news.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n              <br>\n              <span>");
#nullable restore
#line 21 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
               Write(news.CreatedTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | Güncellenme Tarihi: ");
#nullable restore
#line 21 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                                                       Write(news.PublishedTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n              <div class=\"pro-img-details\">\n                  <img width=\"550\" height=\"380\"");
                BeginWriteAttribute("src", " src=\"", 646, "\"", 668, 1);
#nullable restore
#line 23 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
WriteAttributeValue("", 652, news.MainArtUrl, 652, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 669, "\"", 675, 0);
                EndWriteAttribute();
                WriteLiteral(">\n              </div>\n          </div>\n          <div class=\"col-md-6\">\n              <h4 class=\"pro-d-title\">");
#nullable restore
#line 27 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                                 Write(news.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n              <p>\n                  ");
#nullable restore
#line 29 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
             Write(news.Spot);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n              </p>\n              <p>\n");
#nullable restore
#line 32 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                   foreach (var content in news.Story.Contents)
                  {
                      

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                       if (content._t == "MongoDbTextContent")
                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                          <p> ");
#nullable restore
#line 36 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                         Write(content.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 37 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                       if (content._t == "MongoDbImageContent")
                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                          <img width=\"300\" height=\"300\"");
                BeginWriteAttribute("src", " src=\"", 1274, "\"", 1297, 1);
#nullable restore
#line 40 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
WriteAttributeValue("", 1280, content.ImageUrl, 1280, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n");
#nullable restore
#line 41 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                       
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("              </p>\n              <div class=\"product_meta\">\n                  <span class=\"tagged_as\">\n                      <strong>Tags:</strong>\n");
#nullable restore
#line 47 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                       foreach (var keyword in news.NewsKeywords)
                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                          <a rel=\"tag\" href=\"#\">");
#nullable restore
#line 49 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                                           Write(keyword);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n");
#nullable restore
#line 50 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                      }

#line default
#line hidden
#nullable disable
                WriteLiteral("                  </span>\n                  <br>\n                  <span class=\"post-in\"><strong>Categories: ");
#nullable restore
#line 53 "/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/Views/Home/Detail.cshtml"
                                                       Write(news.MainCategory.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></span>\n              </div>\n          </div>\n      </div>\n  </section>\n  </div>\n  </div>\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DYG.UI.DTO.NewsDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
