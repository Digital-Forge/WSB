#pragma checksum "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0735160bb76d24f091016ab62a0ca32e9d61f32c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_RoomDefault), @"mvc.1.0.view", @"/Views/Reservation/RoomDefault.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0735160bb76d24f091016ab62a0ca32e9d61f32c", @"/Views/Reservation/RoomDefault.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2a0b5ed3b6fe74d2a4bb84b6d5e63c3c7269da", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_RoomDefault : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SystemOfBookHotel.Application.ViewModel.ListOfRoomVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExtraPerk", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
  
    ViewData["Title"] = "RoomDefault";

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
                        <h1>WYBIERZ LICZB?? OS??B</h1>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0735160bb76d24f091016ab62a0ca32e9d61f32c5496", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 16 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                         for (int i = 0; i < Model.Rooms.Count; i++)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-3\">\r\n                                <div class=\"adult_child\"> </div>\r\n                                <div class=\"room_number\">Pok??j ");
#nullable restore
#line 21 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                                                           Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                            </div>
                            <div class=""col-5 col-md-4"">
                                <div class=""adult_child"">Doro??li</div>
                                <div class=""form-group"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0735160bb76d24f091016ab62a0ca32e9d61f32c6958", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 27 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                                         for (int j = 0; j <= Model.Rooms[i].MaxCount; j++)
                                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0735160bb76d24f091016ab62a0ca32e9d61f32c7671", async() => {
#nullable restore
#line 29 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                                               Write(j);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 26 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Rooms[i].CountOld);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onchange", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1134, "DropChange(\'Rooms_", 1134, 18, true);
#nullable restore
#line 26 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
AddHtmlAttributeValue("", 1152, i, 1152, 4, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 1156, "__CountOld\',", 1156, 12, true);
                AddHtmlAttributeValue(" ", 1168, "\'Rooms_", 1169, 8, true);
#nullable restore
#line 26 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
AddHtmlAttributeValue("", 1176, i, 1176, 4, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 1180, "__CountChild\',", 1180, 14, true);
#nullable restore
#line 26 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
AddHtmlAttributeValue(" ", 1194, Model.Rooms[i].MaxCount, 1195, 24, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 1219, ")", 1219, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    <span class=""select-arrow""></span>
                                    <span class=""form-label"">doro??li</span>
                                </div>
                            </div>
                            <div class=""col-5 col-md-4"">
                                <div class=""adult_child"">Dzieci</div>
                                <div class=""form-group"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0735160bb76d24f091016ab62a0ca32e9d61f32c13048", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 40 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                                         for (int j = 0; j <= (Model.Rooms[i].MaxCount - Model.Rooms[i].CountOld); j++)
                                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0735160bb76d24f091016ab62a0ca32e9d61f32c13790", async() => {
#nullable restore
#line 42 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                                               Write(j);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 43 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 39 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Rooms[i].CountChild);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onchange", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2041, "DropChange(\'Rooms_", 2041, 18, true);
#nullable restore
#line 39 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
AddHtmlAttributeValue("", 2059, i, 2059, 4, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 2063, "__CountOld\',", 2063, 12, true);
                AddHtmlAttributeValue(" ", 2075, "\'Rooms_", 2076, 8, true);
#nullable restore
#line 39 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
AddHtmlAttributeValue("", 2083, i, 2083, 4, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 2087, "__CountChild\',", 2087, 14, true);
#nullable restore
#line 39 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
AddHtmlAttributeValue(" ", 2101, Model.Rooms[i].MaxCount, 2102, 24, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 2126, ")", 2126, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <span class=\"select-arrow\"></span>\r\n                                    <span class=\"form-label\">dzieci</span>\r\n                                </div>\r\n                            </div>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0735160bb76d24f091016ab62a0ca32e9d61f32c18981", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 50 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Rooms[i].MaxCount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0735160bb76d24f091016ab62a0ca32e9d61f32c20787", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 51 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Rooms[i].RoomId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 52 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                             if (i != 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-1\">\r\n                                    <div class=\"room_close\">\r\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 3075, "\"", 3133, 3);
                WriteAttributeValue("", 3082, "javascript:ActionRemoveRoom(", 3082, 28, true);
#nullable restore
#line 56 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
WriteAttributeValue("", 3110, Model.Rooms[i].RoomId, 3110, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3132, ")", 3132, 1, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-times\"></i></a>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 59 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n");
#nullable restore
#line 61 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                         if (Model.RoomOut == false)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""add-button"">
                                <p id=""add"">
                                    <button onClick=""ActionProviderAdd()"" class=""add-btn"">
                                        <i class=""fas fa-plus""></i> dodaj pok??j
                                    </button>
                                </p>
                            </div>
");
#nullable restore
#line 71 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"form-btn\">\r\n                            <input type =\"submit\" value=\"ZATWIERD??\" class=\"submit-btn\"/>\r\n                        </div>\r\n\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0735160bb76d24f091016ab62a0ca32e9d61f32c25633", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 77 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoomOut);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0735160bb76d24f091016ab62a0ca32e9d61f32c27425", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 78 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ToRemove);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0735160bb76d24f091016ab62a0ca32e9d61f32c29218", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 79 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Dates.DateStart);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0735160bb76d24f091016ab62a0ca32e9d61f32c31018", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 80 "D:\Project\WSB\WSB\ProgramowanieZaawansowane\SystemRezerwacjiHotelu\SystemOfBookHotel\SystemOfBookHotel.Web\Views\Reservation\RoomDefault.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Dates.DateEnd);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        function ActionProviderAdd()
        {
            document.forms[0].action = ""/Reservation/AddRoom"";
            document.forms[0].submit();
        }

        function ActionRemoveRoom(index) {
            document.getElementById(""ToRemove"").value = index;
            document.forms[0].action = ""/Reservation/RemoveRoom"";
            document.forms[0].submit();
        }

        function DropChange(drop1, drop2, max) {
            var x = document.getElementById(drop1);
            var x_v = x.selectedIndex;
            var y = document.getElementById(drop2);
            var y_v = y.selectedIndex;

            x.options.length = 0;
            y.options.length = 0;

            for (var i = 0; i <= max; i++) {
                if (i <= max - y_v) {
                    var opt = document.createElement('option');
                    opt.value = i;
                    opt.text = i;
                    x.options.add(opt);
                }");
                WriteLiteral(@"
                if (i <= max - x_v) {
                    var opt2 = document.createElement('option');
                    opt2.value = i;
                    opt2.text = i;
                    y.options.add(opt2);
                }
            }
            x.selectedIndex = x_v;
            y.selectedIndex = y_v;
        }
    </script>
    <script src=""https://kit.fontawesome.com/d73f199e71.js"" crossorigin=""anonymous""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SystemOfBookHotel.Application.ViewModel.ListOfRoomVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
