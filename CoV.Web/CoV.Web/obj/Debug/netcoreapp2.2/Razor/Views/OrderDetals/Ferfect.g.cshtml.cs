#pragma checksum "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dddaeaf45a114574e9777885dcf970cc8077b05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetals_Ferfect), @"mvc.1.0.view", @"/Views/OrderDetals/Ferfect.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderDetals/Ferfect.cshtml", typeof(AspNetCore.Views_OrderDetals_Ferfect))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dddaeaf45a114574e9777885dcf970cc8077b05", @"/Views/OrderDetals/Ferfect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b215e98a6ad750c14dffef89b4c27c357a9e3b89", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderDetals_Ferfect : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoV.Service.DataModel.OrderDetailsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrderDetals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(134, 96, true);
            WriteLiteral("\r\n <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h1 style=\"text-align: center\" >");
            EndContext();
            BeginContext(230, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dddaeaf45a114574e9777885dcf970cc8077b055397", async() => {
                BeginContext(279, 25, true);
                WriteLiteral("Đơn hàng giao thành công ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(308, 826, true);
            WriteLiteral(@"</h1>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-12 table-responsive"">
            <table  id=""ShowClass"" class=""table table-bordered table-hover"">
                <thead class=""thead-light"">       
                <tr style=""background-color: darkgrey"">
                    <td >Shipper</td>
                    <td >Tên khách hàng </td>
                    <td >Số điện thoại </td>
                    <td >Tên sản phẩm </td>
                    <td >Số lượng</td>
                    <td > Tổng tiền </td>
                    <td >Địa chỉ</td>
                    <td >Ngày đặt</td>
                    <td >Ngày Giao</td>
                    <td >Trạng thái</td>
                    <td >Chi tiết...</td>
                </tr>
                
                <tbody>
");
            EndContext();
#line 32 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                 foreach(var item in Model)
                { 

#line default
#line hidden
            BeginContext(1199, 84, true);
            WriteLiteral("                    <tr style=\"text-align: center\" > \r\n                        <td >");
            EndContext();
            BeginContext(1284, 12, false);
#line 35 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                        Write(item.Shipper);

#line default
#line hidden
            EndContext();
            BeginContext(1296, 37, true);
            WriteLiteral("</td> \r\n                        <td >");
            EndContext();
            BeginContext(1334, 17, false);
#line 36 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                        Write(item.NameCustomer);

#line default
#line hidden
            EndContext();
            BeginContext(1351, 37, true);
            WriteLiteral("</td> \r\n                        <td >");
            EndContext();
            BeginContext(1389, 16, false);
#line 37 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                        Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1405, 37, true);
            WriteLiteral("</td> \r\n                        <td >");
            EndContext();
            BeginContext(1443, 16, false);
#line 38 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                        Write(item.NameProduct);

#line default
#line hidden
            EndContext();
            BeginContext(1459, 37, true);
            WriteLiteral("</td> \r\n                        <td >");
            EndContext();
            BeginContext(1497, 18, false);
#line 39 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                        Write(item.NumberProduct);

#line default
#line hidden
            EndContext();
            BeginContext(1515, 40, true);
            WriteLiteral(" SP</td> \r\n                        <td >");
            EndContext();
            BeginContext(1556, 15, false);
#line 40 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                        Write(item.TotalMoney);

#line default
#line hidden
            EndContext();
            BeginContext(1571, 37, true);
            WriteLiteral("</td> \r\n                        <td >");
            EndContext();
            BeginContext(1609, 12, false);
#line 41 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                        Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1621, 37, true);
            WriteLiteral("</td> \r\n                        <td >");
            EndContext();
            BeginContext(1659, 15, false);
#line 42 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                        Write(item.CreateDate);

#line default
#line hidden
            EndContext();
            BeginContext(1674, 37, true);
            WriteLiteral("</td> \r\n                        <td >");
            EndContext();
            BeginContext(1712, 12, false);
#line 43 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                        Write(item.EndDate);

#line default
#line hidden
            EndContext();
            BeginContext(1724, 64, true);
            WriteLiteral("</td> \r\n                        <td style=\"color: blue\" ><button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1788, "\"", 1801, 1);
#line 44 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
WriteAttributeValue("", 1793, item.Id, 1793, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1802, 33, true);
            WriteLiteral(" class=\" btn btn-primary status\">");
            EndContext();
            BeginContext(1836, 23, false);
#line 44 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                                                                                                  Write(item.StatusOrder.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1859, 104, true);
            WriteLiteral(" </button> </td> \r\n                        <td style=\"text-align: center\">\r\n                            ");
            EndContext();
            BeginContext(1963, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dddaeaf45a114574e9777885dcf970cc8077b0512478", async() => {
                BeginContext(2069, 36, true);
                WriteLiteral("<i class=\"far fa-address-card\"></i> ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2109, 61, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr> \r\n");
            EndContext();
#line 49 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Ferfect.cshtml"
                } 

#line default
#line hidden
            BeginContext(2190, 106, true);
            WriteLiteral("                </tbody>\r\n                </thead>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2313, 287, true);
                WriteLiteral(@"
    <script>    
        $(document).ready(function() {
            $('#ShowClass').DataTable();
            $('.dataTables_empty').text(""Danh sách rỗng"");
            $('.next').text(""Trang tiếp"");
            $('.previous').text(""Trang trước"");

        });
    </script>

");
                EndContext();
            }
            );
            BeginContext(2603, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoV.Service.DataModel.OrderDetailsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591