#pragma checksum "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbf088582e498697f7377899a93b0b1ad5be6cdf"
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
#line 1 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\_ViewImports.cshtml"
using ASP.NET_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
using ASP.NET_Core.APIComunication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
using Nancy.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
using ASP.NET_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbf088582e498697f7377899a93b0b1ad5be6cdf", @"/Views/Home/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cece8e97a48c14dc69f1e4bcc04dd0d337cf55c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiltersSearchDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search.."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", new global::Microsoft.AspNetCore.Html.HtmlString("Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
  
    ViewData["Title"] = "Šop";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container font-sajt\" style=\"background-color:white\">\r\n    <div class=\"text-center\" style=\"margin-top:95px;\">\r\n        <hr />\r\n        <h1 style=\"font-size:2em\">Šop</h1>\r\n    </div>\r\n    <hr />\r\n\r\n    <br />\r\n");
#nullable restore
#line 18 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
      
        var response = APIClient.SetAPIClient("Shop/Filter/Create", HttpMethod.Get);
        JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
        var itemsShop = javaScriptSerializer.Deserialize<FiltersReadDto>(response);
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf088582e498697f7377899a93b0b1ad5be6cdf8053", async() => {
                WriteLiteral("\r\n                <br />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf088582e498697f7377899a93b0b1ad5be6cdf8353", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 27 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <section class=\"mb-4\">\r\n                    <div class=\"md-form md-outline mt-0 d-flex justify-content-between align-items-center\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dbf088582e498697f7377899a93b0b1ad5be6cdf10200", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 30 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Search);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <button type=""submit""><i class=""fa fa-search""></i></button>
                    </div>
                </section>
                <!--NOVI PADAJUCI MENI-->
                <section>
                    <div id=""accordion"">
                        <div class=""card"">
                            <button type=""button"" class=""btn collapsed"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">

                                <h5 class=""mb-0"" style=""text-align:center; color:black"">

                                    SORT

                                </h5>

                            </button>
                            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
                                <div class=""card-body"" style=""color:black"">
                                    <section class=""filters"">
                                        <!-- Section: Condition -->
 ");
                WriteLiteral("                                       <section filter=\"condition\" class=\"mb-4\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf088582e498697f7377899a93b0b1ad5be6cdf13086", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 52 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            <h6 class=\"font-weight-bold mb-3 filter-text\"></h6>\r\n");
                WriteLiteral(@"                                            <div class=""form-check pl-0 mb-3"">
                                                <input type=""radio"" value=""option2"" name=""radiobutton"">
                                                <label for=""male"">Najskuplji</label><br>
                                            </div>
                                            <div class=""form-check pl-0 mb-3"">
                                                <input type=""radio"" value=""option3"" name=""radiobutton"">
                                                <label for=""male"">A-Z</label><br>
                                            </div>
                                            <div class=""form-check pl-0 mb-3 pb-1"">
                                                <input type=""radio"" value=""option4"" name=""radiobutton"">
                                                <label for=""male"">Z-A</label><br>
                                            </div>
                                            <div cla");
                WriteLiteral(@"ss=""form-check pl-0 mb-3 pb-1"">
                                                <input type=""radio"" value=""option5"" name=""radiobutton"">
                                                <label for=""male"">Najnoviji</label><br>
                                            </div>
                                            <div class=""form-check pl-0 mb-3 pb-1"">
                                                <input type=""radio"" value=""option6"" name=""radiobutton"">
                                                <label for=""male"">Popust</label><br>
                                            </div>
                                        </section>
                                    </section>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class=""card"">
                            <button type=""button"" class=""btn collapsed"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expa");
                WriteLiteral(@"nded=""false"" aria-controls=""collapseThree"">

                                <h5 class=""mb-0"" style=""text-align:center; color:black"">

                                    FILTER

                                </h5>

                            </button>
                            <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordion"">
                                <div class=""card-body"" style=""color:black"">
                                    <section class=""filters"">

                                        <!-- Section: Condition -->


                                        <section class=""mb-4"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf088582e498697f7377899a93b0b1ad5be6cdf17809", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 105 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            <h6 class=\"font-weight-bold mb-3\" style=\"text-align:center\">Cena</h6>\r\n                                            <div class=\"slider-price d-flex align-items-center my-4\">\r\n");
                WriteLiteral(@"                                            </div>
                                        </section>
                                        <hr />

                                        <section filter=""condition"" class=""mb-4"">
                                            <h6 class=""font-weight-bold mb-3 filter-text"">Kategorije</h6>
");
                WriteLiteral(@"
                                        </section>
                                        <hr />
                                        <!-- Section: Size -->
                                        <section class=""mb-4"" filter=""size"">
                                            <h6 class=""font-weight-bold mb-3 filter-text"">Veličina</h6>
");
                WriteLiteral(@"

                                        </section>
                                        <hr />
                                        <!-- Section: Size -->
                                        <!-- Section: Gender -->
                                        <section class=""mb-4"" filter=""size"">
                                            <h6 class=""font-weight-bold mb-3 filter-text"">Pol</h6>
");
                WriteLiteral(@"                                        </section>
                                        <!-- Section: Gender -->
                                    </section>

                                </div>
                            </div>
                        </div>

                    </div>
                </section>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 185 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
          
            var jsonString = ViewBag.Shop;
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            var items = jsonSerializer.Deserialize<List<Product>>(jsonString);
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-9\">\r\n            <div class=\"card-deck\" id=\"cardDeck\">\r\n                <div class=\"row\">\r\n                    <div class=\"container\">\r\n");
#nullable restore
#line 194 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                         if (items != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 196 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                             foreach (var item in items)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-md-4 card-space "">
                                    <div class=""flip-box"">
                                        <div class=""flip-box-inner"">
                                            <div class=""flip-box-front"">
                                                <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 12837, "\"", 12855, 1);
#nullable restore
#line 202 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
WriteAttributeValue("", 12843, item.ImgUrl, 12843, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                                                <div class=\"card-body mt-4 mr-1\">\r\n                                                    <h4 class=\"card-title\"><a style=\"color:white\">");
#nullable restore
#line 204 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                                    <div class=\"dropdown-divider\"></div>\r\n                                                    <p class=\"card-text\" style=\"color:white\">Price: ");
#nullable restore
#line 206 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                                                                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf088582e498697f7377899a93b0b1ad5be6cdf25979", async() => {
                WriteLiteral("\r\n                                                <div class=\"flip-box-back\" style=\"font-size: 30px; font-family: Impact;\"> <br /><br /><br /><br />KUPI ODMAH!</div>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 215 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 215 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a>TRENUTNO NEMA PROIZVODA U ŠOPU</a>\r\n");
#nullable restore
#line 220 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf088582e498697f7377899a93b0b1ad5be6cdf28363", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 225 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                 for (int i = 0; i < 2; i++)
                {
                    var counter = i + 1;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dbf088582e498697f7377899a93b0b1ad5be6cdf28945", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 228 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.pageNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 228 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                                                         WriteLiteral(counter);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 229 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FiltersSearchDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
