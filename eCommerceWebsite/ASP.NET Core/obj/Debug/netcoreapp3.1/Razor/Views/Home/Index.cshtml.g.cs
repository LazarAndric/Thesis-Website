#pragma checksum "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1de787bd8f42b009be0c51c7f11a5c1ce7071c6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1de787bd8f42b009be0c51c7f11a5c1ce7071c6d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cece8e97a48c14dc69f1e4bcc04dd0d337cf55c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PROJEKTI\GitHub\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Swift Claw";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container"">    
    <div class=""text-center"" style=""margin-top:95px;"">
        <hr />
        <h1 class=""display-4"">Swift Claw</h1>
    </div>
    <hr />
</div>


<div class=""container"">
    <div class=""jumbotron jumbotron-fluid"" style=""background-image:url(https://s5.gifyu.com/images/IMG_20191208_180520-1-1.png); border-radius:0; max-height:600px; "">
        <div class=""container"">
            <div class=""row mt-5"">
                <div class=""col-md-6 text-center "">                    
                    <p class=""lead mt-5"" style=""color:white; -webkit-text-stroke:3.5px #2E0D5F; font-size:70px; font-family:Impact;""><em>Postani deo Kandžica!</em></p>
                    <p class=""lead"" style=""color:white; -webkit-text-stroke:1.25px #2E0D5F; font-size:25px; font-family:Impact;""><em>Prva kupovina 20% popusta!</em></p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1de787bd8f42b009be0c51c7f11a5c1ce7071c6d4664", async() => {
                WriteLiteral("\r\n                        <input type=\"submit\" class=\"dugmejumbotron\" value=\"Kupi odmah!\" style=\"font-family:Impact;\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
                    <div class=""col-md-6"">
                        <h1></h1>
                    </div>
                </div>
            </div>
        </div>
        <hr />
    </div>


    <div class=""container"">
        <p style=""font-size: 25px;text-align: center""><em>Naši proizvodi</em></p>
        <div class=""row"">
            <div class=""container"">
                <div class=""card-deck"">
                    <div class=""card card-shadow text-center"" style=""background-color: #200843; "">
                        <img class=""card-img-top"" src=""https://s6.gifyu.com/images/IMG_20191207_112344.jpg"" alt=""Card image cap"">
                        <div class=""card-body"">
                            <h4 class=""card-title"" style=""color:white"">Majica swiftclaw</h4>
                            <div class=""dropdown-divider""></div>
                            <p class=""card-text"" style=""color:white"">Price: $0.5</p>
                            <a href=""#"" data-name=""Majic");
            WriteLiteral(@"a_swiftclaw"" data-price=""0.5"" class=""add-to-cart btn btn-light"">Add to cart</a>
                        </div>
                    </div>
                    <div class=""card card-shadow text-center"" style=""background-color: #200843; "">
                        <img class=""card-img-top"" src=""https://s6.gifyu.com/images/IMG_20191207_112344.jpg"" alt=""Card image cap"">
                        <div class=""card-body"">
                            <h4 class=""card-title"" style=""color:white"">Majica swiftclaw</h4>
                            <div class=""dropdown-divider""></div>
                            <p class=""card-text"" style=""color:white"">Price: $0.5</p>
                            <a href=""#"" data-name=""Majica_swiftclaw"" data-price=""0.5"" class=""add-to-cart btn btn-light"">Add to cart</a>
                        </div>
                    </div>
                    <div class=""card card-shadow text-center"" style=""background-color: #200843; "">
                        <img class=""card-img-top"" src=""https");
            WriteLiteral(@"://s6.gifyu.com/images/IMG_20191207_112344.jpg"" alt=""Card image cap"">
                        <div class=""card-body"">
                            <h4 class=""card-title"" style=""color:white"">Duks swiftclaw</h4>
                            <div class=""dropdown-divider""></div>
                            <p class=""card-text"" style=""color:white"">Price: $1</p>
                            <a href=""#"" data-name=""Duks_swiftclaw"" data-price=""1"" class=""add-to-cart btn btn-light"">Add to cart</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <hr />
    </div>
    <br>


    <div class=""container"">
        <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
            <!-- Indicators -->
                    <ol class=""carousel-indicators"">
                        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                        <li data-target=""#myCarousel"" data-slide-t");
            WriteLiteral(@"o=""1""></li>
                        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
                        <li data-target=""#myCarousel"" data-slide-to=""3""></li>
                        <li data-target=""#myCarousel"" data-slide-to=""4""></li>
                    </ol>

                    <!-- Wrapper for slides -->
                    <div class=""carousel-inner"">
                        <div class=""item active"">
                            <img src=""https://s5.gifyu.com/images/IMG_20191208_183750-2.png"" alt=""logogamescon"" style=""width:100%; height:550px;"">
                        </div>

                        <div class=""item"">
                            <img src=""https://s5.gifyu.com/images/IMG-20191207-WA0014.jpg"" alt=""ekipa"" style=""width:100%; height:550px;"">
                        </div>

                        <div class=""item"">
                            <img src=""https://s5.gifyu.com/images/IMG_20191208_180520.jpg"" alt=""majicasc"" style=""width:100%; height:550px;"">
          ");
            WriteLiteral(@"              </div>

                        <div class=""item"">
                            <img src=""https://s5.gifyu.com/images/IMG_20191208_182416.jpg"" alt=""asusrog"" style=""width:100%; height:550px;"">
                        </div>

                        <div class=""item"">
                            <img src=""https://s5.gifyu.com/images/IMG_20191208_174034.jpg"" alt=""monster"" style=""width:100%; height:550px;"">
                        </div>

                    </div>

                    <!-- Left and right controls -->
                    <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">
                        <span class=""glyphicon glyphicon-chevron-left""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">
                        <span class=""glyphicon glyphicon-chevron-right""></span>
                        <span class=""sr-onl");
            WriteLiteral(@"y"">Next</span>
                    </a>
                </div>
</div>

<div class=""container"">
    <div class=""row"">
        <p style=""font-size: 20px; text-align: center; "">
            <strong>

            </strong>
        </p>
    </div>
</div>

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
