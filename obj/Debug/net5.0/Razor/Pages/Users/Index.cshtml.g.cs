#pragma checksum "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c7961d9f5d871924ec4e90ad2c64893605e27ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SparkAuto.Pages.Users.Pages_Users_Index), @"mvc.1.0.razor-page", @"/Pages/Users/Index.cshtml")]
namespace SparkAuto.Pages.Users
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
#line 1 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\_ViewImports.cshtml"
using SparkAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\_ViewImports.cshtml"
using SparkAuto.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\_ViewImports.cshtml"
using SparkAuto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c7961d9f5d871924ec4e90ad2c64893605e27ee", @"/Pages/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d69de3f1e1300da7fddf4fe637537dd02ad215", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-white rounded-pill mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/undraw/grua.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Cars/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block btn btn-indigo rounded-pill btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm rounded-pill px-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm rounded-pill px-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", new global::Microsoft.AspNetCore.Html.HtmlString("Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-light btn-icon btn-sm mr-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-icon btn-indigo btn-sm active mr-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_18 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::SparkAuto.TagHelpers.PageLinkTagHelper __SparkAuto_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header class=\"page-header bg-primary pb-10\">\r\n    <div class=\"container py-4\">\r\n        <div class=\"row\">\r\n            <div class=\"col-8 align-self-end\">\r\n                <h1 class=\"text-white mt-5\">Customer List</h1>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c7961d9f5d871924ec4e90ad2c64893605e27ee10762", async() => {
                WriteLiteral("\r\n                    <i class=\"fal fa-plus\"></i>&nbsp;Create New Customer\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c7961d9f5d871924ec4e90ad2c64893605e27ee12366", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</header>\r\n\r\n\r\n\r\n\r\n<div class=\"container mt-n10\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c7961d9f5d871924ec4e90ad2c64893605e27ee13687", async() => {
                WriteLiteral(@"
        <div class=""card p-5 mt-4"">
            <div class=""row"">
                <div class=""col-12 col-md-11"">
                    <div class=""row"" style=""padding-top:10px"">
                        <div class=""col-12 col-md-3 mb-2 mb-md-0"">
                            ");
#nullable restore
#line 34 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                       Write(Html.Editor("searchPlate", new { htmlAttributes = new { @class = "form-control",
                                        placeholder = "Plate Number..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-12 col-md-3 mb-2 mb-md-0\">\r\n                            ");
#nullable restore
#line 38 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                       Write(Html.Editor("searchEmail", new { htmlAttributes = new { @class = "form-control",
                                        placeholder = "Email..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-12 col-md-3 mb-2 mb-md-0\">\r\n                            ");
#nullable restore
#line 42 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                       Write(Html.Editor("searchName", new { htmlAttributes = new { @class = "form-control", placeholder
                            = "Name..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-12 col-md-3 mb-2 mb-md-0\">\r\n                            ");
#nullable restore
#line 46 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                       Write(Html.Editor("searchPhone", new { htmlAttributes = new { @class = "form-control",
                                        placeholder = "Phone..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-md-1 align-self-end text-right"">
                    <button type=""submit"" name=""submit"" value=""Search"" class=""btn btn-indigo btn-icon"">
                        <i class=""fas fa-search""></i>
                    </button>
                </div>
            </div>

            <hr />

            <div>
                <table class=""table table-bordered table-responsive"" style=""width: 100%;"">
                    <tr");
                BeginWriteAttribute("class", " class=\"", 2664, "\"", 2672, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <th class=\"text-indigo\">\r\n                            ");
#nullable restore
#line 64 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.UsersListVM.ApplicationUserList[0].Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th class=\"text-indigo\">\r\n                            ");
#nullable restore
#line 67 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.UsersListVM.ApplicationUserList[0].PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th class=\"text-indigo\">\r\n                            ");
#nullable restore
#line 70 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.UsersListVM.ApplicationUserList[0].Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>SMS</th>\r\n                        <th>Cars</th>\r\n                        <th>Actions</th>\r\n                    </tr>\r\n");
#nullable restore
#line 76 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                     foreach (var item in Model.UsersListVM.ApplicationUserList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr role=\"row\" >\r\n                            <td class=\"fit\">\r\n                                ");
#nullable restore
#line 80 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                           Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td class=\"fit\">\r\n                                ");
#nullable restore
#line 83 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                           Write(Html.DisplayFor(m => item.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td class=\"fit\">\r\n                                ");
#nullable restore
#line 86 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                           Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td class=\"fit\">\r\n                                <div class=\"custom-control custom-checkbox\">\r\n                                    <input class=\"custom-control-input\"");
                BeginWriteAttribute("id", " id=\"", 4158, "\"", 4181, 2);
#nullable restore
#line 90 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
WriteAttributeValue("", 4163, item.Id, 4163, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4173, "SMSCheck", 4173, 8, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\" name=\"status\"");
                BeginWriteAttribute("checked", " checked=\'", 4212, "\'", 4236, 1);
#nullable restore
#line 90 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
WriteAttributeValue("", 4222, item.SmsAlert, 4222, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"return false;\">\r\n                                    <label class=\"custom-control-label\"");
                BeginWriteAttribute("for", " for=\"", 4335, "\"", 4359, 2);
#nullable restore
#line 91 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
WriteAttributeValue("", 4341, item.Id, 4341, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4351, "SMSCheck", 4351, 8, true);
                EndWriteAttribute();
                WriteLiteral(">Send SMS</label>\r\n                                </div>\r\n                            </td>\r\n                            <td class=\"fit\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c7961d9f5d871924ec4e90ad2c64893605e27ee21339", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fas fa-car\"></i> &nbsp; View Cars\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </td>\r\n                            \r\n                            <td class=\"fit\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c7961d9f5d871924ec4e90ad2c64893605e27ee23960", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fas fa-edit mr-2\"></i> Edit\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c7961d9f5d871924ec4e90ad2c64893605e27ee26477", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fal fa-times mr-2\"></i> Delete\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 111 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                     if (Model.UsersListVM.ApplicationUserList.Count == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td class=\"fit\" colspan=\"5\">No matching results found</td>\r\n");
#nullable restore
#line 115 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c7961d9f5d871924ec4e90ad2c64893605e27ee29752", async() => {
                    WriteLiteral("\r\n                ");
                }
                );
                __SparkAuto_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::SparkAuto.TagHelpers.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__SparkAuto_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 117 "C:\Storage\Develop\Aspnet\SparkAuto\Pages\Users\Index.cshtml"
__SparkAuto_TagHelpers_PageLinkTagHelper.PageModel = Model.UsersListVM.PagingInfo;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __SparkAuto_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __SparkAuto_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __SparkAuto_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                __SparkAuto_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_17.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_18.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_18);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SparkAuto.Pages.Users.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SparkAuto.Pages.Users.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SparkAuto.Pages.Users.IndexModel>)PageContext?.ViewData;
        public SparkAuto.Pages.Users.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
