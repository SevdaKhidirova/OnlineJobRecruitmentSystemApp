#pragma checksum "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa5d1269c883ab52191d472d5bd330c41d920d40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vacancies_Summary), @"mvc.1.0.view", @"/Views/Vacancies/Summary.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa5d1269c883ab52191d472d5bd330c41d920d40", @"/Views/Vacancies/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebedb13385d77239009d2f7d49e9ae587e4574d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Vacancies_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SummaryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section id=\"vacancies\">\r\n    <div class=\"own-container\">\r\n        <div class=\"container\">\r\n            <h2 class=\"mb-5\">");
#nullable restore
#line 6 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
                        Write(Model.jobVacancy.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</h2>\r\n            <a href=\"/Vacancies/vacancy\">\r\n                <i class=\"bi bi-arrow-left\"></i>Vacancies\r\n            </a>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section id=\"summary\">\r\n    <div class=\"container mt-5\">\r\n        <h2>Company : ");
#nullable restore
#line 16 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
                 Write(Model.jobVacancy.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2 class=\"mb-3\">Summary</h2>\r\n        ");
#nullable restore
#line 18 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
   Write(Html.Raw(Model.jobVacancy.Summary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
         if (Model.jobVacancy.Responsibilities != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"mt-5 mb-3\">Responsibilities:</h2>\r\n            <div class=\"responsibilites\">\r\n                ");
#nullable restore
#line 23 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
           Write(Html.Raw(Model.jobVacancy.Responsibilities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h2 class=\"my-5\">Requirements</h2>\r\n        <div class=\"requritments\">\r\n            ");
#nullable restore
#line 29 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
       Write(Html.Raw(Model.jobVacancy.Requirements));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
         if (Model.jobVacancy.ReasonToJoinUs != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"my-5\">Reasons to join us</h2>\r\n            <div class=\"reason\">\r\n                ");
#nullable restore
#line 39 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
           Write(Html.Raw(Model.jobVacancy.ReasonToJoinUs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 41 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
         if (User.Identity.IsAuthenticated)
        {


            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
             if (Model.apliedVacancy != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
                 if (Model.apliedVacancy.VacancyId == Model.jobVacancy.Id)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\" class=\"btn btn-light my-3 apply disabled\" id=\"aply_button\">Applied</a>\r\n");
#nullable restore
#line 52 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1768, "\"", 1830, 2);
            WriteAttributeValue("", 1775, "/Vacancies/UserToVacancyConnection/", 1775, 35, true);
#nullable restore
#line 55 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
WriteAttributeValue("", 1810, Model.jobVacancy.Id, 1810, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light my-3 apply\" id=\"aply_button\">Apply</a>\r\n");
#nullable restore
#line 56 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 1978, "\"", 2040, 2);
            WriteAttributeValue("", 1985, "/Vacancies/UserToVacancyConnection/", 1985, 35, true);
#nullable restore
#line 60 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
WriteAttributeValue("", 2020, Model.jobVacancy.Id, 2020, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light my-3 apply\" id=\"aply_button\">Apply</a>\r\n");
#nullable restore
#line 61 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Views\Vacancies\Summary.cshtml"
             

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SummaryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
