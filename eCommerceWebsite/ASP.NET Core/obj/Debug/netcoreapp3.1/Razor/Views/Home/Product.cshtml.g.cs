#pragma checksum "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0171fbd30af64012dd584a52dbc3c8792fa07dec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Product), @"mvc.1.0.view", @"/Views/Home/Product.cshtml")]
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
#line 1 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\_ViewImports.cshtml"
using ASP.NET_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\_ViewImports.cshtml"
using ASP.NET_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0171fbd30af64012dd584a52dbc3c8792fa07dec", @"/Views/Home/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cece8e97a48c14dc69f1e4bcc04dd0d337cf55c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
  
    ViewData["Title"] = "Proizvod";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n       \r\n        <div class=\"text-center\" style=\"margin-top:95px;\">\r\n            <hr />\r\n            <h1 style=\"font-size:2em\">");
#nullable restore
#line 10 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
        </div>
        <hr />
    </div>  

    <main >
        <div class=""container dark-grey-text mt-5"">

            <!--Grid row-->
            <div class=""row wow fadeIn"">

                <!--Grid column-->
                <div class=""col-md-6 mb-4"">

                    <img");
            BeginWriteAttribute("src", " src=\"", 532, "\"", 551, 1);
#nullable restore
#line 24 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
WriteAttributeValue("", 538, Model.ImgUrl, 538, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 570, "\"", 576, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                </div>
                <!--Grid column-->
                <!--Grid column-->
                <div class=""col-md-6 mb-4"">

                    <!--Content-->
                    <div class=""p-4"">
                        <!--FILTERs-->
                        <div class=""mb-3"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 914, "\"", 921, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 36 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                                 if (Model.Category != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge purple mr-1\">");
#nullable restore
#line 38 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                                                               Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 39 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </a>\r\n                        </div>\r\n\r\n                        <p class=\"lead\">\r\n                            <!--<span class=\"mr-1\">\r\n            <del>$200</del>\r\n        </span>-->\r\n                            <span>");
#nullable restore
#line 47 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                             Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </p>\r\n\r\n                        <p class=\"lead font-weight-bold\">Opis</p>\r\n\r\n                        <p>\r\n                            ");
#nullable restore
#line 53 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n\r\n                        <p class=\"lead font-weight-bold\">Veličina</p>                        \r\n");
#nullable restore
#line 57 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                         if (Model.Size != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0171fbd30af64012dd584a52dbc3c8792fa07dec9019", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 60 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                             foreach (var size in Model.Size)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <label class=\"radio-inline\">\r\n                                <input type=\"radio\" name=\"optradio\" checked");
                BeginWriteAttribute("value", " value=\"", 2062, "\"", 2078, 1);
#nullable restore
#line 63 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
WriteAttributeValue("", 2070, size.Id, 2070, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >");
#nullable restore
#line 63 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                                                                                         Write(size.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </label>\r\n");
#nullable restore
#line 65 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 67 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0171fbd30af64012dd584a52dbc3c8792fa07dec11951", async() => {
                WriteLiteral("\r\n                            <!-- Default input -->\r\n                            <a href=\"#\" data-name=\"");
#nullable restore
#line 71 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                                              Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-price=\"");
#nullable restore
#line 71 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Product.cshtml"
                                                                       Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"add-to-cart btn btn-primary\" style=\"width:100%\">Dodaj u korpu</a>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <br />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0171fbd30af64012dd584a52dbc3c8792fa07dec14125", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0171fbd30af64012dd584a52dbc3c8792fa07dec14412", async() => {
                    WriteLiteral("Nastavi pregled proizvoda");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </div>
                    <!--Content-->

                </div>
                <!--Grid column-->

            </div>
            <!--Grid row-->

            <hr>
            </div>
            </main>













    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
