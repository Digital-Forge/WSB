#pragma checksum "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af20fd2cd7257a489b9d1b35ad6c8ab8550c8492"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
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
#line 1 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\_ViewImports.cshtml"
using SystemOfBookHotel.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\_ViewImports.cshtml"
using SystemOfBookHotel.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af20fd2cd7257a489b9d1b35ad6c8ab8550c8492", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2a0b5ed3b6fe74d2a4bb84b6d5e63c3c7269da", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SystemOfBookHotel.Application.ViewModel.AdmReservationDetals>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""booking"" class=""section"">
    <div class=""section-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""booking-form"">
                    <div class=""form-header-2"">
                        <h1>Szczegóły rezerwacji</h1>
                    </div>
                    <div style=""color:white;"">
                        <hr />
                        <dl class=""row"">
                            <dt class=""col-sm-2"">
                                ");
#nullable restore
#line 19 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 22 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 25 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 28 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 31 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 34 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 37 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 40 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 43 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.End));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 46 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayFor(model => model.End));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 49 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.RoomName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 52 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayFor(model => model.RoomName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 55 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.CountAdult));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 58 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayFor(model => model.CountAdult));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 61 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.CountChild));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 64 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                           Write(Html.DisplayFor(model => model.CountChild));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dd class=\"col-sm-12\">\r\n                                ExtraPerk :\r\n                            </dd>\r\n");
#nullable restore
#line 69 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                             foreach (var item in Model.ExtraPerk)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dd class=\"col-sm-12\">\r\n                                    ");
#nullable restore
#line 72 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n");
#nullable restore
#line 74 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </dl>\r\n                    </div>\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af20fd2cd7257a489b9d1b35ad6c8ab8550c849212915", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SystemOfBookHotel.Application.ViewModel.AdmReservationDetals> Html { get; private set; }
    }
}
#pragma warning restore 1591