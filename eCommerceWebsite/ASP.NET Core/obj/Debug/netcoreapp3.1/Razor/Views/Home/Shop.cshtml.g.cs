#pragma checksum "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c43de1d4f9724c74733c01a752c1efefc87c4804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Shop), @"mvc.1.0.view", @"/Views/Home/Shop.cshtml")]
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
#nullable restore
#line 1 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
using ASP.NET_Core.APIComunication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
using Nancy.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c43de1d4f9724c74733c01a752c1efefc87c4804", @"/Views/Home/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cece8e97a48c14dc69f1e4bcc04dd0d337cf55c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("example"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:auto;max-width:300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
  
    ViewData["Title"] = "Šop";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container font-sajt"" style=""background-color:white"">
    <div class=""text-center"" style=""margin-top:95px;"">
        <hr />
        <h1 style=""font-size:2em"">Šop</h1>
    </div>
    <hr />


<br />

    <div class=""row"">

        <div class=""col-md-3"">

            <br />
            <section class=""mb-4"">
                <div class=""md-form md-outline mt-0 d-flex justify-content-between align-items-center"">
");
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43de1d4f9724c74733c01a752c1efefc87c48046685", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" placeholder=\"Search..\" name=\"search2\">\r\n                        <button type=\"submit\"><i class=\"fa fa-search\"></i></button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </section>





            <!--NOVI PADAJUCI MENI-->
            <section>
                <div id=""accordion"">
                    <div class=""card"">
                        <button class=""btn collapsed"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">

                            <h5 class=""mb-0"" style=""text-align:center; color:black"">

                                SORT

                            </h5>

                        </button>
                        <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
                            <div class=""card-body"" style=""color:black"">
                                <section class=""filters"">

                                    <!-- Section: Condition -->
                                    <section filter=""condition"" class=""mb-4"">
                                        <h6 class=""font-weight-bold m");
            WriteLiteral(@"b-3 filter-text""></h6>
                                        <div class=""form-check pl-0 mb-3"">
                                            <input type=""radio"" value=""option1"" name=""radiobutton"">
                                            <label for=""male"">Najeftiniji</label><br>
                                        </div>
                                        <div class=""form-check pl-0 mb-3"">
                                            <input type=""radio""  value=""option2"" name=""radiobutton"">
                                            <label for=""male"">Najskuplji</label><br>
                                        </div>
                                        <div class=""form-check pl-0 mb-3"">
                                            <input type=""radio""  value=""option3"" name=""radiobutton"">
                                            <label for=""male"">A-Z</label><br>
                                        </div>
                                        <div class=""form-check pl-0 mb-");
            WriteLiteral(@"3 pb-1"">
                                            <input type=""radio""  value=""option4"" name=""radiobutton"">
                                            <label for=""male"">Z-A</label><br>
                                        </div>
                                        <div class=""form-check pl-0 mb-3 pb-1"">
                                            <input type=""radio""  value=""option5"" name=""radiobutton"">
                                            <label for=""male"">Najnoviji</label><br>
                                        </div>
                                        <div class=""form-check pl-0 mb-3 pb-1"">
                                            <input type=""radio""  value=""option6"" name=""radiobutton"">
                                            <label for=""male"">Popust</label><br>
                                        </div>
                                    </section>
                                </section>
                            </div>
                        </di");
            WriteLiteral(@"v>
                    </div>
                    <br />
                    <div class=""card"">
                        <button class=""btn collapsed"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">

                            <h5 class=""mb-0"" style=""text-align:center; color:black"">

                                FILTER

                            </h5>

                        </button>
                        <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordion"">
                            <div class=""card-body"" style=""color:black"">
                                <section class=""filters"">

                                    <!-- Section: Condition -->


                                    <section class=""mb-4"">
                                        <h6 class=""font-weight-bold mb-3"" style=""text-align:center"">Cena</h6>
                                        <div class=""slider-pric");
            WriteLiteral(@"e d-flex align-items-center my-4"">
                                            <div class=""price-slider"">
                                                <div class=""row"">
                                                    <span>
                                                        od
                                                        <input type=""number"" value=""0"" min=""0"" max=""3700"" />    do
                                                        <input type=""number"" value=""4000"" min=""0"" max=""4000"" />
                                                    </span>
                                                </div>
                                                <input value=""0"" min=""0"" max=""3700"" step=""300"" type=""range"" />
                                                <input value=""4001"" min=""0"" max=""4000"" step=""100"" type=""range"" />
                                                <svg width=""100%"" height=""24"">
                                                    <line x1=""4"" y1=""0"" x2=""");
            WriteLiteral(@"300"" y2=""0"" stroke=""#212121"" stroke-width=""12"" stroke-dasharray=""1 28""></line>
                                                </svg>
                                            </div>
                                        </div>
                                    </section>
                                    <hr />

                                    <section filter=""condition"" class=""mb-4"">
                                        <h6 class=""font-weight-bold mb-3 filter-text"">Kategorije</h6>
                                        <div class=""form-check pl-0 mb-3"">
                                            <input type=""checkbox"">
                                            <label for=""male"">Majice</label><br>
                                        </div>
                                        <div class=""form-check pl-0 mb-3"">
                                            <input type=""checkbox"">
                                            <label for=""male"">Duksevi</label><br>
         ");
            WriteLiteral(@"                               </div>
                                        <div class=""form-check pl-0 mb-3"">
                                            <input type=""checkbox"">
                                            <label for=""male"">Kape</label><br>
                                        </div>
                                        <div class=""form-check pl-0 mb-3 pb-1"">
                                            <input type=""checkbox"">
                                            <label for=""male"">Rancevi</label><br>
                                        </div>
                                    </section>
                                    <hr />
                                    <!-- Section: Size -->
                                    <section class=""mb-4"" filter=""size"">
                                        <h6 class=""font-weight-bold mb-3 filter-text"">Veličina</h6>
                                        <div class=""form-check pl-0 mb-3"">
                            ");
            WriteLiteral(@"                <input type=""radio"" value=""option1"" name=""radiobutton"">
                                            <label for=""male"">XS</label><br>
                                        </div>
                                        <div class=""form-check pl-0 mb-3"">
                                            <input type=""radio"" value=""option2"" name=""radiobutton"">
                                            <label for=""male"">S</label><br>
                                        </div>
                                        <div class=""form-check pl-0 mb-3"">
                                            <input type=""radio"" value=""option3"" name=""radiobutton"">
                                            <label for=""male"">M</label><br>
                                        </div>
                                        <div class=""form-check pl-0 mb-3"">
                                            <input type=""radio"" value=""option4"" name=""radiobutton"">
                                            ");
            WriteLiteral(@"<label for=""male"">L</label><br>
                                        </div>
                                        <div class=""form-check pl-0 mb-3"">
                                            <input type=""radio"" value=""option5"" name=""radiobutton"">
                                            <label for=""male"">XL</label><br>
                                        </div>
                                    </section>
                                    <hr />
                                    <!-- Section: Size -->
                                    <!-- Section: Gender -->
                                    <section class=""mb-4"" filter=""size"">
                                        <h6 class=""font-weight-bold mb-3 filter-text"">Pol</h6>

                                        <div class=""form-check pl-0 mb-3"">
                                            <input type=""radio""  value=""option1"" name=""radiobutton"">
                                            <label for=""male"">M</label><br>");
            WriteLiteral(@"
                                        </div>
                                        <div class=""form-check pl-0 mb-3"">
                                            <input type=""radio""  value=""option2"" name=""radiobutton"">
                                            <label for=""male"">Ž</label><br>
                                        </div>
                                    </section>
                                    <!-- Section: Gender -->
                                </section>

                            </div>
                        </div>
                    </div>

                </div>
            </section>
        </div>
");
#nullable restore
#line 197 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
          
            var jsonString = APIClient.SetAPIClient("Product", APIClient.Token,HttpMethod.Get);
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            var items = javaScriptSerializer.Deserialize<List<Product>>(jsonString);
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-9\">\r\n            <div class=\"card-deck\" id=\"cardDeck\">\r\n                <div class=\"row\">\r\n                    <div class=\"container\">\r\n");
#nullable restore
#line 206 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                         if (items != null)
                        {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 208 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                         foreach (var item in items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-md-4 card-space "">
                                <div class=""flip-box"">
                                    <div class=""flip-box-inner"">
                                        <div class=""flip-box-front"">
                                            <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 12055, "\"", 12073, 1);
#nullable restore
#line 214 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
WriteAttributeValue("", 12061, item.ImgUrl, 12061, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                                            <div class=\"card-body mt-4 mr-1\">\r\n                                                <h4 class=\"card-title\"><a style=\"color:white\">");
#nullable restore
#line 216 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                                <div class=\"dropdown-divider\"></div>\r\n                                                <p class=\"card-text\" style=\"color:white\">Price: ");
#nullable restore
#line 218 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                                                                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43de1d4f9724c74733c01a752c1efefc87c480421955", async() => {
                WriteLiteral("\r\n                                            <div class=\"flip-box-back\" style=\"font-size: 30px; font-family: Impact;\"> <br /><br /><br /><br />KUPI ODMAH!</div>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 227 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 227 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                         
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a>Jbg</a>\r\n");
#nullable restore
#line 232 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 236 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
             for (int i = 0; i < 10; i++)
            {
                if (i < 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43de1d4f9724c74733c01a752c1efefc87c480424621", async() => {
#nullable restore
#line 240 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                                                  Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 241 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a>....</a>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43de1d4f9724c74733c01a752c1efefc87c480426308", async() => {
                WriteLiteral("10");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
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
