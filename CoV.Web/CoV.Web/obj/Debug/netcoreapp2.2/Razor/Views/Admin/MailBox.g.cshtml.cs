#pragma checksum "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Admin/MailBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45fc2606f615a84e09e6a54320a34f96889bb58a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_MailBox), @"mvc.1.0.view", @"/Views/Admin/MailBox.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/MailBox.cshtml", typeof(AspNetCore.Views_Admin_MailBox))]
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
#line 1 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Admin/MailBox.cshtml"
using CoV.Service.DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45fc2606f615a84e09e6a54320a34f96889bb58a", @"/Views/Admin/MailBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b215e98a6ad750c14dffef89b4c27c357a9e3b89", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_MailBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Admin/MailBox.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_AdminLayout";
     var contact = (IEnumerable<ContactViewModel>)ViewBag.contact;

#line default
#line hidden
            BeginContext(165, 2219, true);
            WriteLiteral(@"
    <!-- Main content -->
    <section class=""content"">
      <div class=""row"">
        <div class=""col-md-3"">
          <a href=""compose.html"" class=""btn btn-primary btn-block mb-3"">Soạn</a>

          <div class=""card"">
            <div class=""card-header"">
              <h3 class=""card-title"">Thư mục</h3>

              <div class=""card-tools"">
                <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse""><i class=""fas fa-minus""></i>
                </button>
              </div>
            </div>
            <div class=""card-body p-0"">
              <ul class=""nav nav-pills flex-column"">
                <li class=""nav-item active"">
                  <a href=""#"" class=""nav-link"">
                    <i class=""fas fa-inbox""></i> Hộp thử đến
                    <span class=""badge bg-primary float-right"">12</span>
                  </a>
                </li>
                <li class=""nav-item"">
                  <a href=""#"" class=""nav-link"">
              ");
            WriteLiteral(@"      <i class=""far fa-envelope""></i> Gửi
                  </a>
                </li>
                <li class=""nav-item"">
                  <a href=""#"" class=""nav-link"">
                    <i class=""far fa-trash-alt""></i> Thùng rác
                  </a>
                </li>
              </ul>
            </div>
            <!-- /.card-body -->
          </div>
          
        </div>
        <!-- /.col -->
        <div class=""col-md-9"">
          <div class=""card card-primary card-outline"">
            <div class=""card-header"">
              <h3 class=""card-title"">Hộp thử đến </h3>

              <div class=""card-tools"">
                <div class=""input-group input-group-sm"">
                  <input type=""text"" class=""form-control"" placeholder=""Tìm kiếm mail"">
                  <div class=""input-group-append"">
                    <div class=""btn btn-primary"">
                      <i class=""fas fa-search""></i>
                    </div>
                  </div>
         ");
            WriteLiteral("       </div>\r\n              </div>\r\n              <!-- /.card-tools -->\r\n            </div>\r\n            <!-- /.card-header -->\r\n            <div class=\"card-body p-0\">\r\n");
            EndContext();
            BeginContext(3673, 155, true);
            WriteLiteral("              <div class=\"table-responsive mailbox-messages\">\r\n                <table class=\"table table-hover table-striped\">\r\n                  <tbody>\r\n");
            EndContext();
#line 91 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Admin/MailBox.cshtml"
                   foreach (var item in contact)
                  {

#line default
#line hidden
            BeginContext(3899, 281, true);
            WriteLiteral(@"                    <tr>
                      <td class=""mailbox-star"" style=""height: 72px; width: 42px"" ><a href=""#""><i class=""fas fa-star text-warning""></i></a></td>
                      <td class=""mailbox-name"" style=""height: 129px; width: 73px""><a href=""read-mail.html""><b>");
            EndContext();
            BeginContext(4181, 23, false);
#line 95 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Admin/MailBox.cshtml"
                                                                                                         Write(item.Customer.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(4204, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4206, 22, false);
#line 95 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Admin/MailBox.cshtml"
                                                                                                                                  Write(item.Customer.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(4228, 69, true);
            WriteLiteral(" </b></a></td>\r\n                      <td class=\"mailbox-subject\"><b>");
            EndContext();
            BeginContext(4298, 22, false);
#line 96 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Admin/MailBox.cshtml"
                                                Write(item.Customer.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(4320, 7, true);
            WriteLiteral("</b> - ");
            EndContext();
            BeginContext(4328, 16, false);
#line 96 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Admin/MailBox.cshtml"
                                                                              Write(item.Information);

#line default
#line hidden
            EndContext();
            BeginContext(4344, 160, true);
            WriteLiteral("\r\n                      </td>\r\n                      <td class=\"mailbox-attachment\"></td>\r\n                      <td class=\"mailbox-date\" style=\"float: right\"> ");
            EndContext();
            BeginContext(4505, 17, false);
#line 99 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Admin/MailBox.cshtml"
                                                                Write(item.CreaDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(4522, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 101 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Admin/MailBox.cshtml"
                  }

#line default
#line hidden
            BeginContext(4577, 1715, true);
            WriteLiteral(@"                  </tbody>
                </table>
                <!-- /.table -->
              </div>
              <!-- /.mail-box-messages -->
            </div>
            <!-- /.card-body -->
            <div class=""card-footer p-0"">
              <div class=""mailbox-controls"">
                <!-- Check all button -->
                <button type=""button"" class=""btn btn-default btn-sm checkbox-toggle""><i class=""far fa-square""></i>
                </button>
                <div class=""btn-group"">
                  <button type=""button"" class=""btn btn-default btn-sm""><i class=""far fa-trash-alt""></i></button>
                  <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-reply""></i></button>
                  <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-share""></i></button>
                </div>
                <!-- /.btn-group -->
                <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-sync-alt""></i></bu");
            WriteLiteral(@"tton>
                <div class=""float-right"">
                  1-50/200
                  <div class=""btn-group"">
                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-chevron-left""></i></button>
                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-chevron-right""></i></button>
                  </div>
                  <!-- /.btn-group -->
                </div>
                <!-- /.float-right -->
              </div>
            </div>
          </div>
          <!-- /.card -->
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->
    </section>
    <!-- /.content -->");
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
