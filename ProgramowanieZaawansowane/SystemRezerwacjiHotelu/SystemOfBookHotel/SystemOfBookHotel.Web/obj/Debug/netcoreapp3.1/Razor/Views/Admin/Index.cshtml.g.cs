#pragma checksum "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95d6156f8bd0a2f052dfe02eb6e3e12c79816f87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d6156f8bd0a2f052dfe02eb6e3e12c79816f87", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2a0b5ed3b6fe74d2a4bb84b6d5e63c3c7269da", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SystemOfBookHotel.Application.ViewModel.AdmReservationVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Obecne Rezerwacje</h1>\r\n<div style=\"float:right; text-align:center;\">\r\n    ");
#nullable restore
#line 9 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
Write(Html.ActionLink("Logout", "Logout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div style=\"background-color: grey\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 16 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.End));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.RoomNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 31 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.End));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RoomNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { roomReservationId = item.RoomReservationId }, FormMethod.Get));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
                   Write(Html.ActionLink("Remove", "Remove", new { roomReservationId = item.RoomReservationId }, FormMethod.Get));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 53 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Admin\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SystemOfBookHotel.Application.ViewModel.AdmReservationVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
