#pragma checksum "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d2e2d6953ff2cb40519a72612f67975849c70c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profil_PostAd), @"mvc.1.0.view", @"/Views/Profil/PostAd.cshtml")]
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
#line 1 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\_ViewImports.cshtml"
using jobrecuritment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\_ViewImports.cshtml"
using jobrecuritment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\_ViewImports.cshtml"
using jobrecuritment.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d2e2d6953ff2cb40519a72612f67975849c70c2", @"/Views/Profil/PostAd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebedb13385d77239009d2f7d49e9ae587e4574d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Profil_PostAd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfilViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <section id=\"post_ad\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"add-card\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e2d6953ff2cb40519a72612f67975849c70c24114", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""mb-3 col-sm-6"">
                                    <label for=""exampleFormControlInput1"" class=""form-label"">Job Title</label>
                                    <input type=""text"" class=""form-control"" name=""JobTitle"" id=""exampleFormControlInput1"" placeholder=""Title"">
                                </div>
                                <div class=""mb-3 col-sm-6"">
                                    <label for=""exampleFormControlInput2"" class=""form-label"">Company Name</label>
                                    <input type=""text"" class=""form-control"" name=""CompanyName"" id=""exampleFormControlInput2"" placeholder=""Company"">
                                </div>
                                <div class=""mb-3 col-sm-6"">
                                    <label for=""exampleFormControlInput3"" class=""form-label"">Due Time</label>
                                    <input type=""text"" class=""form-control""name=""");
                WriteLiteral(@"DueTime""  id=""exampleFormControlInput3"" placeholder=""Time"">
                                </div>
                                <div class=""mb-3 col-sm-6"">
                                    <label for=""exampleFormControlInput4"" class=""form-label"">Salary</label>
                                    <input type=""text"" class=""form-control"" name=""Salary"" id=""exampleFormControlInput4"" placeholder=""Salary"">
                                </div>
                                <div class=""mb-3 col-sm-6"">
                                    <label for=""exampleFormControlInput6"" class=""form-label"">Work Time</label>
                                    <input type=""text"" class=""form-control"" name=""WorkTime"" id=""exampleFormControlInput6"" placeholder=""Time"">
                                </div>
                                <div class=""mb-3 col-sm-6"">
                                    <label for=""exampleFormControlInput7"" class=""form-label"">Education</label>
                                    <inpu");
                WriteLiteral(@"t type=""text"" class=""form-control"" name=""RequiredEducation"" id=""exampleFormControlInput7"" placeholder=""Education"">
                                </div>
                                <div class=""mb-3 col-sm-6"">
                                    <label for=""exampleFormControlInput6"" class=""form-label"">Age</label>
                                    <input type=""text"" class=""form-control"" name=""RequiredAge"" id=""exampleFormControlInput6"" placeholder=""Age"">
                                </div>
                                <div class=""mb-3 col-sm-6"">
                                    <label for=""exampleFormControlInput5"" class=""form-label"">Employment Type</label>
                                    <select class=""form-select job_type"" aria-label=""Default select example"" name=""JobTypeId"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e2d6953ff2cb40519a72612f67975849c70c27470", async() => {
                    WriteLiteral("Select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                         foreach (JobType item in Model.jobType)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e2d6953ff2cb40519a72612f67975849c70c29504", async() => {
#nullable restore
#line 44 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 44 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
AddHtmlAttributeValue("", 3375, item.Id, 3375, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </select>
                                </div>
                                <div class=""mb-3 col-sm-6"">
                                    <label for=""exampleFormControlInput5"" class=""form-label"">Category</label>
                                    <select class=""form-select job_type"" aria-label=""Default select example"" name=""CategoryId"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e2d6953ff2cb40519a72612f67975849c70c212618", async() => {
                    WriteLiteral("Select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                         foreach (Category item in Model.category)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e2d6953ff2cb40519a72612f67975849c70c214652", async() => {
#nullable restore
#line 54 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </select>
                                </div>
                                <div class=""mb-3 col-sm-6"">
                                    <label for=""exampleFormControlInput5"" class=""form-label"">Level</label>
                                    <select class=""form-select job_type"" name=""LevelId"" aria-label=""Default select example"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e2d6953ff2cb40519a72612f67975849c70c217253", async() => {
                    WriteLiteral("Select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                         foreach (Level item in Model.levels)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e2d6953ff2cb40519a72612f67975849c70c219285", async() => {
#nullable restore
#line 64 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </select>
                                </div>
                                <div class=""mb-3 "">
                                    <label for=""txthtml3"" class=""form-label"">Summary</label>
                                    <textarea class=""form-control"" name=""Summary"" id=""txthtml3"" rows=""3""></textarea>
                                </div>
                                <div class=""mb-3 "">
                                    <label for=""txthtml"" class=""form-label"">Requritments</label>
                                    <textarea class=""form-control"" id=""txthtml"" name=""Requirements"" rows=""3""></textarea>
                                </div>
");
                WriteLiteral(@"                                <div class=""mb-3 "">
                                    <label for=""txthtml2"" class=""form-label"">Reasons to join us</label>
                                    <textarea class=""form-control"" id=""txthtml2"" name=""ReasonToJoinUs"" rows=""3""></textarea>
                                </div>
                            </div>
                            <button type=""submit"" class=""btn btn-outline-danger post_ad_button"">Post ad</button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <p class=\"bold\">My Ads</p>\r\n");
#nullable restore
#line 91 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                     foreach (JobVacancy item in Model.jobVacancy)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"my_post\">\r\n                            <p class=\"bold\">");
#nullable restore
#line 94 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                       Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <span>");
#nullable restore
#line 95 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                             Write(item.Level.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <p>");
#nullable restore
#line 96 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                          Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p>Last date of vacancy ");
#nullable restore
#line 97 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                                               Write(item.DueTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a class=\"btn btn-outline-info\"");
            BeginWriteAttribute("href", " href=\"", 7012, "\"", 7042, 2);
            WriteAttributeValue("", 7019, "/profil/delete/", 7019, 15, true);
#nullable restore
#line 98 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
WriteAttributeValue("", 7034, item.Id, 7034, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remove</a>\r\n                            <a class=\"btn btn-outline-info\"");
            BeginWriteAttribute("href", " href=\"", 7115, "\"", 7145, 2);
            WriteAttributeValue("", 7122, "/profil/editad/", 7122, 15, true);
#nullable restore
#line 99 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
WriteAttributeValue("", 7137, item.Id, 7137, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                        </div>\r\n");
#nullable restore
#line 101 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Profil\PostAd.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

        </div>
    </section>


    <script src=""//cdn.ckeditor.com/4.19.1/standard/ckeditor.js""></script>
    <script>
          CKEDITOR.replace('txthtml')
          CKEDITOR.replace('txthtml2')
          CKEDITOR.replace('txthtml3')
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfilViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
