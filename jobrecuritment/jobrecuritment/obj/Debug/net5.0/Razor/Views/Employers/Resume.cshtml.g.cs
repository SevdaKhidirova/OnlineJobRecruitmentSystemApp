#pragma checksum "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af6010df5f2f785e38fad990d3c788420d12f4ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employers_Resume), @"mvc.1.0.view", @"/Views/Employers/Resume.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6010df5f2f785e38fad990d3c788420d12f4ab", @"/Views/Employers/Resume.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebedb13385d77239009d2f7d49e9ae587e4574d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Employers_Resume : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResumeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/user/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <section id=""resume"">
        <div class=""container pt-3 pb-5 own-card"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""resume-title"">
                        <p>
                            <a href=""/employers/index"">Resumes</a> / Resume
                        </p>
                    </div>
                </div>
                <div class=""col-md-4"">
");
#nullable restore
#line 14 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                     foreach (PersonalInfo item in Model.personalInfosLs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-12\">\r\n                            <div class=\"search-card\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 683, "\"", 716, 2);
            WriteAttributeValue("", 690, "/employers/resume/", 690, 18, true);
#nullable restore
#line 18 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
WriteAttributeValue("", 708, item.Id, 708, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-6 text-center\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af6010df5f2f785e38fad990d3c788420d12f4ab5931", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"col-6\">\r\n                                            <p>\r\n                                                ");
#nullable restore
#line 25 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                           Write(Model.documentsLs.Where(x=>x.UserId==item.UserId).Select(x=>x.Position).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n");
            WriteLiteral("                                            <p>");
#nullable restore
#line 28 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                                     Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <h5 class=\"salary\">");
#nullable restore
#line 29 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                                          Write(Model.documentsLs.Where(x => x.UserId == item.UserId).Select(x => x.Salary).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                        </div>
                                        <hr>
                                        <div class=""col-12"">
                                            <div class=""d-flex mx-2 card-footer"">
                                                <div class=""location"">
                                                    <i class=""bi bi-geo-alt""></i>");
#nullable restore
#line 35 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                                                            Write(Model.personalInfosLs.Where(x=>x.UserId==item.UserId).Select(x=>x.Adress).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                                <div class=\"calendar\">\r\n                                                    <i class=\"bi bi-calendar3\"></i>&nbsp; ");
#nullable restore
#line 38 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                                                                     Write(item.RegistrationTime.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                            </div>
                        </div>
");
#nullable restore
#line 46 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                
                <div class=""col-md-8"">
                    <div class=""main-card"">
                        <div class=""row"">
                            <div class=""col-4"">
                                <div class=""image-container text-center pt-3"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af6010df5f2f785e38fad990d3c788420d12f4ab11049", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-3\">\r\n                                <div class=\"info\">\r\n                                    <p class=\"name\">");
#nullable restore
#line 60 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                               Write(Model.personalInfos.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 60 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                                                            Write(Model.personalInfos.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 60 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                                                                                      Write(Model.personalInfos.FatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>+(994)-");
#nullable restore
#line 61 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                         Write(Model.appUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                    <p class=\"mail\">");
#nullable restore
#line 62 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                               Write(Model.appUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>");
#nullable restore
#line 63 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                  Write(Model.personalInfos.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""col-3"">
                                <div class=""info"">
                                        <p class=""profession"">
                                               ");
#nullable restore
#line 69 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                          Write(Model.Documents.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                         </p>\r\n                                    <h5>\r\n                                        ");
#nullable restore
#line 72 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                   Write(Model.Documents.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </h5>
                                    </div>
                            </div>
                        </div>
                    </div>
                    <div class=""note mt-4 px-5"">
                        <h5>Motivation Letter</h5>
");
#nullable restore
#line 80 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                         if (Model.Documents.MotivationLetter == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"note-text\">\r\n                                Not Added\r\n                            </p>\r\n");
#nullable restore
#line 85 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"note-text\">\r\n                                ");
#nullable restore
#line 89 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                           Write(Model.Documents.MotivationLetter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n");
#nullable restore
#line 91 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <div class=""personal-info mt-4 px-5"">
                        <p class=""title"">Personal Information</p>
                        <div class=""row"">
                            <div class=""col-6 first"">
                                <p class=""gender"">Gender:</p>
                                <p class=""age"">Age:</p>
                                <p class=""place"">Place of Birth:</p>
                                <p class=""adress"">Adress:</p>
                            </div>
                            <div class=""col-6 second"">
                                <p class=""gender"">");
#nullable restore
#line 104 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                             Write(Model.personalInfos.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"age\">\r\n");
#nullable restore
#line 106 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                       
                                        int now = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                                        int age = Convert.ToInt32(Model.personalInfos.DateOfBiirth.ToString("yyyy"));
                                        int res = now - age;
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   ");
#nullable restore
#line 111 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                              Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n");
#nullable restore
#line 113 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                 if (Model.personalInfos.RegistrAdress != null)
                                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <p class=\"place\">");
#nullable restore
#line 115 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                                 Write(Model.personalInfos.RegistrAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 116 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                  }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <p class=\"adress\">");
#nullable restore
#line 119 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                                Write(Model.personalInfos.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 120 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"adress\">");
#nullable restore
#line 121 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                             Write(Model.personalInfos.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"skills mt-4 px-5\">\r\n");
#nullable restore
#line 126 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                         foreach (var item in Model.interests)
                        {
                         

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>");
#nullable restore
#line 129 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                             Write(item.InterestItem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 130 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </div>\r\n                    <div class=\"education mt-4 px-5\">\r\n                        <div class=\"row\">\r\n                            <p class=\"edu\">Education</p>\r\n");
#nullable restore
#line 144 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                             foreach (Education item in Model.education)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-6\">\r\n                                    <p class=\"edu\">");
#nullable restore
#line 147 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                              Write(item.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                    <p>Graduation year ");
#nullable restore
#line 148 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                                  Write(item.GraduationYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                </div>\r\n                                <div class=\"col-6 line\">\r\n                                    <p>");
#nullable restore
#line 151 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                  Write(item.University);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n");
#nullable restore
#line 153 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"experience mt-4 px-5 pb-2\">\r\n                        <p class=\"exp\">Experience</p>\r\n");
#nullable restore
#line 159 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                         if (Model.experience.Count==0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>No experience</p>\r\n");
#nullable restore
#line 162 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                             foreach (Experience item in Model.experience)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"company\">");
#nullable restore
#line 167 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                              Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <span class=\"start-time\">");
#nullable restore
#line 168 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                                    Write(item.StartToWork);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -</span>\r\n                                <span class=\"end-time\">");
#nullable restore
#line 169 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                                  Write(item.EndToWork);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <p class=\"profesion\">");
#nullable restore
#line 170 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                                Write(item.Responsibilities);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 171 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"languages link mt-4 px-5 pb-2 d-flex\">\r\n                        <div class=\"col-6\">\r\n                            <div class=\"language\">\r\n                                <p>Language</p>\r\n");
#nullable restore
#line 179 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                 foreach (Language item in Model.languages)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 182 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                  Write(item.LanguageItem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
            WriteLiteral("                                    <hr />\r\n");
#nullable restore
#line 187 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-6\">\r\n                            <div class=\"links\">\r\n                                <p>Social Media Links</p>\r\n");
#nullable restore
#line 195 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                 if (Model.links.Facebook != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 10220, "\"", 10248, 1);
#nullable restore
#line 197 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
WriteAttributeValue("", 10227, Model.links.Facebook, 10227, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"bi bi-facebook\"></i></a>\r\n");
#nullable restore
#line 198 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 199 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                 if (Model.links.Linkedin != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 10478, "\"", 10506, 1);
#nullable restore
#line 201 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
WriteAttributeValue("", 10485, Model.links.Linkedin, 10485, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"bi bi-linkedin\"></i></a>\r\n");
#nullable restore
#line 202 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 203 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                 if (Model.links.Github != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 10734, "\"", 10760, 1);
#nullable restore
#line 205 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
WriteAttributeValue("", 10741, Model.links.Github, 10741, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"bi bi-github\"></i></a>\r\n");
#nullable restore
#line 206 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Employers\Resume.cshtml"
                                }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResumeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
