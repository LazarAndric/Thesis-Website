#pragma checksum "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84cdc30c7b1fb7de81e1d02ddbfb605efaf7ec3f"
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
#line 2 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\_ViewImports.cshtml"
using ASP.NET_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84cdc30c7b1fb7de81e1d02ddbfb605efaf7ec3f", @"/Views/Home/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cece8e97a48c14dc69f1e4bcc04dd0d337cf55c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Shop.cshtml"
  
    ViewData["Title"] = "Šop";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""text-center"" style=""margin-top:95px;"">
        <hr />
        <h1 class=""display-4"">Šop</h1>
    </div>
    <hr />
</div>

<br />
<div class=""container"">
    <div class=""row"">
        <div class=""container"">
            <div class=""col-md-3"">
                <section class=""mb-4"">
                    <h5 class=""filter-text"">Pretraga</h5><hr />
                    <div class=""md-form md-outline mt-0 d-flex justify-content-between align-items-center"">
                        <input class=""form-control mr-sm-2"" type=""search"" onkeyup=""myFunction()"" placeholder=""Pretraga"" id=""search"" aria-label=""search"">
                    </div>
                </section>

                <section class=""filters"">
                    <h5 class=""filter-text"">Sortiranje</h5><hr />
                    <!-- Section: Condition -->
                    <section filter=""condition"" class=""mb-4"">
                        <h6 class=""font-weight-bold mb-3 filter-text""></h6>
 ");
            WriteLiteral(@"                       <div class=""form-check pl-0 mb-3"">
                            <input type=""radio"">
                            <label for=""male"">Najeftiniji</label><br>
                        </div>
                        <div class=""form-check pl-0 mb-3"">
                            <input type=""radio"">
                            <label for=""male"">Najskuplji</label><br>
                        </div>
                        <div class=""form-check pl-0 mb-3"">
                            <input type=""radio"">
                            <label for=""male"">A-Z</label><br>
                        </div>
                        <div class=""form-check pl-0 mb-3 pb-1"">
                            <input type=""radio"">
                            <label for=""male"">Z-A</label><br>
                        </div>
                        <div class=""form-check pl-0 mb-3 pb-1"">
                            <input type=""radio"">
                            <label for=""male"">Najnoviji</label><br>
 ");
            WriteLiteral(@"                       </div>
                        <div class=""form-check pl-0 mb-3 pb-1"">
                            <input type=""radio"">
                            <label for=""male"">Popust</label><br>
                        </div>
                    </section>
                </section>

                <section class=""filters"">
                    <h5 class=""filter-text"">Filteri</h5><hr />
                    <!-- Section: Condition -->

                    <section class=""mb-4"">
                        <h6 class=""font-weight-bold mb-3"">Cena</h6>
                        <div class=""slider-price d-flex align-items-center my-4"">
                            <div class=""price-slider"">
                                <div class=""row"">
                                    <span>
                                        od
                                        <input  style=""color:black"" type=""number"" value=""0"" min=""0"" max=""3700"" />    do
                                        <input  ");
            WriteLiteral(@"style=""color:black"" type=""number"" value=""4000"" min=""0"" max=""4000"" />
                                    </span>
                                </div>
                                <input value=""0"" min=""0"" max=""3700"" step=""300"" type=""range"" />
                                <input value=""4001"" min=""0"" max=""4000"" step=""100"" type=""range"" />
                                <svg width=""100%"" height=""24"">
                                    <line x1=""4"" y1=""0"" x2=""300"" y2=""0"" stroke=""#212121"" stroke-width=""12"" stroke-dasharray=""1 28""></line>
                                </svg>
                            </div>
                        </div>
                    </section>
                    <hr />
                    <!-- Section: Size -->
                    <section filter=""condition"" class=""mb-4"">
                        <h6 class=""font-weight-bold mb-3 filter-text"">Kategorije</h6>
                        <div class=""form-check pl-0 mb-3"">
                            <input type=""checkbo");
            WriteLiteral(@"x"">
                            <label for=""male"">Majice &nbsp;<label style=""color:darkgray"">(0)</label></label><br>
                        </div>
                        <div class=""form-check pl-0 mb-3"">
                            <input type=""checkbox"">
                            <label for=""male"">Duksevi &nbsp;<label style=""color:darkgray"">(0)</label></label><br>
                        </div>
                        <div class=""form-check pl-0 mb-3"">
                            <input type=""checkbox"">
                            <label for=""male"">Kape &nbsp;<label style=""color:darkgray"">(0)</label></label><br>
                        </div>
                        <div class=""form-check pl-0 mb-3 pb-1"">
                            <input type=""checkbox"">
                            <label for=""male"">Rancevi &nbsp;<label style=""color:darkgray"">(0)</label></label><br>
                        </div>
                    </section>
                    <hr />

                    <section ");
            WriteLiteral(@"class=""mb-4"" filter=""size"">
                        <h6 class=""font-weight-bold mb-3 filter-text"">Veličina</h6>
                        <div class=""form-check pl-0 mb-3"">
                            <input type=""radio"" value=""option1"" name=""radiobutton"">
                            <label for=""male"">XS  &nbsp;<label style=""color:darkgray"">(0)</label></label><br>
                        </div>
                        <div class=""form-check pl-0 mb-3"">
                            <input type=""radio"" value=""option2"" name=""radiobutton"">
                            <label for=""male"">S  &nbsp;<label style=""color:darkgray"">(0)</label></label><br>
                        </div>
                        <div class=""form-check pl-0 mb-3"">
                            <input type=""radio"" value=""option3"" name=""radiobutton"">
                            <label for=""male"">M  &nbsp;<label style=""color:darkgray"">(0)</label></label><br>
                        </div>
                        <div class=""form-check p");
            WriteLiteral(@"l-0 mb-3"">
                            <input type=""radio"" value=""option4"" name=""radiobutton"">
                            <label for=""male"">L  &nbsp;<label style=""color:darkgray"">(0)</label></label><br>
                        </div>
                        <div class=""form-check pl-0 mb-3"">
                            <input type=""radio"" value=""option5"" name=""radiobutton"">
                            <label for=""male"">XL  &nbsp;<label style=""color:darkgray"">(0)</label></label><br>
                        </div>
                    </section>
                    <hr />
                    <!-- Section: Size -->
                    <!-- Section: Gender -->
                    <section class=""mb-4"" filter=""size"">
                        <h6 class=""font-weight-bold mb-3 filter-text"">Pol</h6>

                        <div class=""form-check pl-0 mb-3"">
                            <input type=""radio"" value=""option1"" name=""radiobutton"">
                            <label for=""male"">M  &nbsp;<label ");
            WriteLiteral(@"style=""color:darkgray"">(0)</label></label><br>
                        </div>
                        <div class=""form-check pl-0 mb-3"">
                            <input type=""radio"" value=""option2"" name=""radiobutton"">
                            <label for=""male"">Ž  &nbsp;<label style=""color:darkgray"">(0)</label></label><br>
                        </div>
                    </section>
                    <!-- Section: Gender -->
                </section>
            </div>

            <div class=""col-md-9"">                
                    <div class=""card-deck"" id=""cardDeck"">
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <div class=""flip-box"">
                                    <div class=""flip-box-inner"">
                                        <div class=""flip-box-front"">
                                            <img class=""card-img-top"" src=""https://s6.gifyu.com/images/IMG_20191207_112344.jpg"" alt");
            WriteLiteral(@"=""Card image cap"">
                                            <div class=""card-body mt-4"">
                                                <h4 class=""card-title""><a style=""color:white"">Duks swiftclaw</a></h4>
                                                <div class=""dropdown-divider""></div>
                                                <p class=""card-text"" style=""color:white"">Price: $0.5</p>
                                            </div>
                                        </div>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84cdc30c7b1fb7de81e1d02ddbfb605efaf7ec3f12908", async() => {
                WriteLiteral("\r\n                                            <div class=\"flip-box-back\" style=\"font-size: 30px; font-family: Impact;\"> <br /><br /><br /><br />KUPI ODMAH!</div>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-4"">
                                <div class=""flip-box"">
                                    <div class=""flip-box-inner"">
                                        <div class=""flip-box-front"">
                                            <img class=""card-img-top"" src=""https://s6.gifyu.com/images/IMG_20191207_112344.jpg"" alt=""Card image cap"">
                                            <div class=""card-body mt-4"">
                                                <h4 class=""card-title""><a style=""color:white"">Duks swiftclaw</a></h4>
                                                <div class=""dropdown-divider""></div>
                                                <p class=""card-text"" style=""color:white"">Price: $0.5</p>
                                            </div>
                                        </div>
                      ");
            WriteLiteral("                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84cdc30c7b1fb7de81e1d02ddbfb605efaf7ec3f15365", async() => {
                WriteLiteral("\r\n                                            <div class=\"flip-box-back\" style=\"font-size: 30px; font-family: Impact;\"> <br /><br /><br /><br />KUPI ODMAH!</div>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-4"">
                                <div class=""flip-box"">
                                    <div class=""flip-box-inner"">
                                        <div class=""flip-box-front"">
                                            <img class=""card-img-top"" src=""https://s6.gifyu.com/images/IMG_20191207_112344.jpg"" alt=""Card image cap"">
                                            <div class=""card-body mt-4"">
                                                <h4 class=""card-title""><a style=""color:white"">Duks swiftclaw</a></h4>
                                                <div class=""dropdown-divider""></div>
                                                <p class=""card-text"" style=""color:white"">Price: $0.5</p>
                                            </div>
                                        </div>
                      ");
            WriteLiteral("                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84cdc30c7b1fb7de81e1d02ddbfb605efaf7ec3f17822", async() => {
                WriteLiteral("\r\n                                            <div class=\"flip-box-back\" style=\"font-size: 30px; font-family: Impact;\"> <br /><br /><br /><br />KUPI ODMAH!</div>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            </div>

                        <div class=""row my-3"">

                            <div class=""col-md-4"">
                                <div class=""flip-box"">
                                    <div class=""flip-box-inner"">
                                        <div class=""flip-box-front"">
                                            <img class=""card-img-top"" src=""https://s6.gifyu.com/images/IMG_20191207_112344.jpg"" alt=""Card image cap"">
                                            <div class=""card-body mt-4"">
                                                <h4 class=""card-title""><a style=""color:white"">Duks swiftclaw</a></h4>
                                                <div class=""dropdown-divider""></div>
                                                <p class=""card-text"" style=""color:white"">Price: $0.5</p>
                                  ");
            WriteLiteral("          </div>\r\n                                        </div>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84cdc30c7b1fb7de81e1d02ddbfb605efaf7ec3f20373", async() => {
                WriteLiteral("\r\n                                            <div class=\"flip-box-back\" style=\"font-size: 30px; font-family: Impact;\"> <br /><br /><br /><br />KUPI ODMAH!</div>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-4"">
                                <div class=""flip-box"">
                                    <div class=""flip-box-inner"">
                                        <div class=""flip-box-front"">
                                            <img class=""card-img-top"" src=""https://s6.gifyu.com/images/IMG_20191207_112344.jpg"" alt=""Card image cap"">
                                            <div class=""card-body mt-4"">
                                                <h4 class=""card-title""><a style=""color:white"">Duks swiftclaw</a></h4>
                                                <div class=""dropdown-divider""></div>
                                                <p class=""card-text"" style=""color:white"">Price: $0.5</p>
                                            </div>
                                        </div>
                      ");
            WriteLiteral("                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84cdc30c7b1fb7de81e1d02ddbfb605efaf7ec3f22830", async() => {
                WriteLiteral("\r\n                                            <div class=\"flip-box-back\" style=\"font-size: 30px; font-family: Impact;\"> <br /><br /><br /><br />KUPI ODMAH!</div>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-4"">
                                <div class=""flip-box"">
                                    <div class=""flip-box-inner"">
                                        <div class=""flip-box-front"">
                                            <img class=""card-img-top"" src=""https://s6.gifyu.com/images/IMG_20191207_112344.jpg"" alt=""Card image cap"">
                                            <div class=""card-body mt-4"">
                                                <h4 class=""card-title""><a style=""color:white"">Duks swiftclaw</a></h4>
                                                <div class=""dropdown-divider""></div>
                                                <p class=""card-text"" style=""color:white"">Price: $0.5</p>
                                            </div>
                                        </div>
                      ");
            WriteLiteral("                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84cdc30c7b1fb7de81e1d02ddbfb605efaf7ec3f25287", async() => {
                WriteLiteral("\r\n                                            <div class=\"flip-box-back\" style=\"font-size: 30px; font-family: Impact;\"> <br /><br /><br /><br />KUPI ODMAH!</div>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>

                        </div>
                        </div>  
             </div>
        </div>
    </div>
</div>




    <!--<div class=""layout-margin-8 mt-4"">
        <div class=""container"">
            <div class=""col-md-2"">

            </div>
            <div class=""col-md-10"">

            </div>
        </div>
    </div>-->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
