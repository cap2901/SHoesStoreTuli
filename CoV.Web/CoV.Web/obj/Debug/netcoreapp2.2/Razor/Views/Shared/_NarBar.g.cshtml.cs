#pragma checksum "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Shared/_NarBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3220b75cd3f43259b51d66fc4d99b164f62bf714"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NarBar), @"mvc.1.0.view", @"/Views/Shared/_NarBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_NarBar.cshtml", typeof(AspNetCore.Views_Shared__NarBar))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/_ViewImports.cshtml"
using CoV.Web;

#line default
#line hidden
#line 2 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/_ViewImports.cshtml"
using CoV.Web.Models;

#line default
#line hidden
#line 3 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 4 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3220b75cd3f43259b51d66fc4d99b164f62bf714", @"/Views/Shared/_NarBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b215e98a6ad750c14dffef89b4c27c357a9e3b89", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NarBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline ml-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 557, true);
            WriteLiteral(@"<!-- Navbar -->
  <nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
    <!-- Left navbar links -->
    <ul class=""navbar-nav"">
      <li class=""nav-item"">
        <a class=""nav-link"" data-widget=""pushmenu"" href=""#""><i class=""fas fa-bars""></i></a>
      </li>
      <li class=""nav-item d-none d-sm-inline-block"">
        <a href=""index3.html"" class=""nav-link"">Home</a>
      </li>
      <li class=""nav-item d-none d-sm-inline-block"">
        <a href=""#"" class=""nav-link"">Contact</a>
      </li>
    </ul>

    <!-- SEARCH FORM -->
    ");
            EndContext();
            BeginContext(557, 389, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3220b75cd3f43259b51d66fc4d99b164f62bf7144440", async() => {
                BeginContext(588, 351, true);
                WriteLiteral(@"
      <div class=""input-group input-group-sm"">
        <input class=""form-control form-control-navbar"" type=""search"" placeholder=""Search"" aria-label=""Search"">
        <div class=""input-group-append"">
          <button class=""btn btn-navbar"" type=""submit"">
            <i class=""fas fa-search""></i>
          </button>
        </div>
      </div>
    ");
                EndContext();
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
            EndContext();
            BeginContext(946, 4280, true);
            WriteLiteral(@"

    <!-- Right navbar links -->
    <ul class=""navbar-nav ml-auto"">
      <!-- Messages Dropdown Menu -->
      <li class=""nav-item dropdown"">
        <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
          <i class=""far fa-comments""></i>
          <span class=""badge badge-danger navbar-badge"">3</span>
        </a>
        <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
          <a href=""#"" class=""dropdown-item"">
            <!-- Message Start -->
            <div class=""media"">
              <img src=""dist/img/user1-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 mr-3 img-circle"">
              <div class=""media-body"">
                <h3 class=""dropdown-item-title"">
                  Brad Diesel
                  <span class=""float-right text-sm text-danger""><i class=""fas fa-star""></i></span>
                </h3>
                <p class=""text-sm"">Call me whenever you can...</p>
                <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
    ");
            WriteLiteral(@"          </div>
            </div>
            <!-- Message End -->
          </a>
          <div class=""dropdown-divider""></div>
          <a href=""#"" class=""dropdown-item"">
            <!-- Message Start -->
            <div class=""media"">
              <img src=""dist/img/user8-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 img-circle mr-3"">
              <div class=""media-body"">
                <h3 class=""dropdown-item-title"">
                  John Pierce
                  <span class=""float-right text-sm text-muted""><i class=""fas fa-star""></i></span>
                </h3>
                <p class=""text-sm"">I got your message bro</p>
                <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
              </div>
            </div>
            <!-- Message End -->
          </a>
          <div class=""dropdown-divider""></div>
          <a href=""#"" class=""dropdown-item"">
            <!-- Message Start -->
            <div class=""media"">
              <img src=""dist/im");
            WriteLiteral(@"g/user3-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 img-circle mr-3"">
              <div class=""media-body"">
                <h3 class=""dropdown-item-title"">
                  Nora Silvester
                  <span class=""float-right text-sm text-warning""><i class=""fas fa-star""></i></span>
                </h3>
                <p class=""text-sm"">The subject goes here</p>
                <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
              </div>
            </div>
            <!-- Message End -->
          </a>
          <div class=""dropdown-divider""></div>
          <a href=""#"" class=""dropdown-item dropdown-footer"">See All Messages</a>
        </div>
      </li>
      <!-- Notifications Dropdown Menu -->
      <li class=""nav-item dropdown"">
        <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
          <i class=""far fa-bell""></i>
          <span class=""badge badge-warning navbar-badge"">15</span>
        </a>
        <div class=""dropdown-menu dropdown-men");
            WriteLiteral(@"u-lg dropdown-menu-right"">
          <span class=""dropdown-item dropdown-header"">15 Notifications</span>
          <div class=""dropdown-divider""></div>
          <a href=""#"" class=""dropdown-item"">
            <i class=""fas fa-envelope mr-2""></i> 4 new messages
            <span class=""float-right text-muted text-sm"">3 mins</span>
          </a>
          <div class=""dropdown-divider""></div>
          <a href=""#"" class=""dropdown-item"">
            <i class=""fas fa-users mr-2""></i> 8 friend requests
            <span class=""float-right text-muted text-sm"">12 hours</span>
          </a>
          <div class=""dropdown-divider""></div>
          <a href=""#"" class=""dropdown-item"">
            <i class=""fas fa-file mr-2""></i> 3 new reports
            <span class=""float-right text-muted text-sm"">2 days</span>
          </a>
          <div class=""dropdown-divider""></div>
          <a href=""#"" class=""dropdown-item dropdown-footer"">See All Notifications</a>
        </div>
      </li>
      <li class=""nav-item"">
        ");
            WriteLiteral("<a class=\"nav-link\" data-widget=\"control-sidebar\" data-slide=\"true\" href=\"#\">\n          <i class=\"fas fa-th-large\"></i>\n        </a>\n      </li>\n    </ul>\n  </nav>\n  <!-- /.navbar -->\n");
            EndContext();
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
