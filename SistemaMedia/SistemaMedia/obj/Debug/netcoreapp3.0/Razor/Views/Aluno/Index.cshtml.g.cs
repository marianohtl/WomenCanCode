#pragma checksum "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90c617faf169947b6b7504a675f680150d28bce9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_Index), @"mvc.1.0.view", @"/Views/Aluno/Index.cshtml")]
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
#line 1 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\_ViewImports.cshtml"
using SistemaMedia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\_ViewImports.cshtml"
using SistemaMedia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90c617faf169947b6b7504a675f680150d28bce9", @"/Views/Aluno/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3292a02cc8121ab51e6a8cdaaef71ed1b8ffe772", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaMedia.Models.Aluno>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Alunos</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Nome do Aluno\r\n");
            WriteLiteral("            </th>\r\n\r\n");
            WriteLiteral("            <th>\r\n                Total de Presença\r\n");
            WriteLiteral("            </th>\r\n");
            WriteLiteral("            <th>\r\n                Turma\r\n");
            WriteLiteral("            </th>\r\n            <th>\r\n                Turno\r\n");
            WriteLiteral("            </th>\r\n            <th>\r\n\r\n                ReprovadoFaltas\r\n            </th>\r\n            <th>\r\n\r\n                Total de Presença\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPresenca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sigla));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Turno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReprovadoFaltas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPresenca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 69 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 70 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 73 "C:\Users\maria\Desktop\sinc\WomanCanCode\SistemaMedia\SistemaMedia\Views\Aluno\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaMedia.Models.Aluno>> Html { get; private set; }
    }
}
#pragma warning restore 1591
