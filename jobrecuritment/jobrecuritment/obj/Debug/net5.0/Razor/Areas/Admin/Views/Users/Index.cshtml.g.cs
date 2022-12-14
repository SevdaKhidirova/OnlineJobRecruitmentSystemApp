#pragma checksum "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c414eabd681d50a3f01b4c3a8f9c7d52855c1c7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\_ViewImports.cshtml"
using jobrecuritment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\_ViewImports.cshtml"
using jobrecuritment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\_ViewImports.cshtml"
using jobrecuritment.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c414eabd681d50a3f01b4c3a8f9c7d52855c1c7f", @"/Areas/Admin/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344ca41097b66c3967798e25e66039035635eaf0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"d-flex justify-content-between align-items-center\">\n    <h1 class=\"mb-4\">Users</h1>\n");
            WriteLiteral("</div>\n<table class=\"table table-hover\">\n    <thead>\n        <tr>\n            <th>Name</th>\n            <th>Email</th>\n            <th>Username</th>\n            <th>Settings</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 16 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
         foreach (AppUser item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 19 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
              Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n    <td>");
#nullable restore
#line 20 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 21 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
   Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n");
#nullable restore
#line 23 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
         if (item.Status)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 608, "\"", 642, 2);
            WriteAttributeValue("", 615, "/admin/users/block/", 615, 19, true);
#nullable restore
#line 25 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 634, item.Id, 634, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">\n        <i class=\"fa fa-lock\"></i>\n    </a> ");
#nullable restore
#line 27 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
         }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 727, "\"", 763, 2);
            WriteAttributeValue("", 734, "/admin/users/unblock/", 734, 21, true);
#nullable restore
#line 30 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 755, item.Id, 755, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">\n        <i class=\"fa fa-lock-open\"></i>\n    </a>");
#nullable restore
#line 32 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 850, "\"", 890, 2);
            WriteAttributeValue("", 857, "/admin/users/manageRoles/", 857, 25, true);
#nullable restore
#line 33 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 882, item.Id, 882, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">\n            <i class=\"fa fa-crown\"></i>\n        </a>\n        <a");
            BeginWriteAttribute("href", " href=\"", 980, "\"", 1022, 2);
            WriteAttributeValue("", 987, "/admin/users/ResetPassword/", 987, 27, true);
#nullable restore
#line 36 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 1014, item.Id, 1014, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">\n            <i class=\"fa fa-edit\"></i>\n        </a>\n        <a");
            BeginWriteAttribute("href", " href=\"", 1111, "\"", 1150, 2);
            WriteAttributeValue("", 1118, "/admin/users/RemoveUser/", 1118, 24, true);
#nullable restore
#line 39 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 1142, item.Id, 1142, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">\n            <i class=\"fa fa-trash\"></i>\n        </a>\n    </td>\n</tr>");
#nullable restore
#line 43 "C:\Users\daniz\Desktop\20AugPro\jobrecuritment\jobrecuritment\Areas\Admin\Views\Users\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
