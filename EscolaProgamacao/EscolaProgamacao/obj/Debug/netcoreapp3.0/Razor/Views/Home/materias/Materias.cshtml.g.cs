#pragma checksum "C:\Users\fic\source\repos\EscolaProgamacao\EscolaProgamacao\Views\Home\materias\Materias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72ac0b1ee7e24707eedd44c1ba96d6d5033cb197"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_materias_Materias), @"mvc.1.0.view", @"/Views/Home/materias/Materias.cshtml")]
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
#line 1 "C:\Users\fic\source\repos\EscolaProgamacao\EscolaProgamacao\Views\_ViewImports.cshtml"
using EscolaProgamacao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fic\source\repos\EscolaProgamacao\EscolaProgamacao\Views\_ViewImports.cshtml"
using EscolaProgamacao.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ac0b1ee7e24707eedd44c1ba96d6d5033cb197", @"/Views/Home/materias/Materias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef4df8c2808b01c9201ee86469593efc71a0c0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_materias_Materias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Materia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fic\source\repos\EscolaProgamacao\EscolaProgamacao\Views\Home\materias\Materias.cshtml"
  
    ViewData["Title"] = "Materias do curso";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Materias do Curso</h1>\r\n<!--o rizor entende que a cada ítem refenciado acima está em Model?\r\n-->\r\n");
#nullable restore
#line 10 "C:\Users\fic\source\repos\EscolaProgamacao\EscolaProgamacao\Views\Home\materias\Materias.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 12 "C:\Users\fic\source\repos\EscolaProgamacao\EscolaProgamacao\Views\Home\materias\Materias.cshtml"
   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 13 "C:\Users\fic\source\repos\EscolaProgamacao\EscolaProgamacao\Views\Home\materias\Materias.cshtml"
     if (string.IsNullOrEmpty(item.Descricao)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Sem Descrição</p>\r\n");
#nullable restore
#line 15 "C:\Users\fic\source\repos\EscolaProgamacao\EscolaProgamacao\Views\Home\materias\Materias.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 18 "C:\Users\fic\source\repos\EscolaProgamacao\EscolaProgamacao\Views\Home\materias\Materias.cshtml"
  Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 19 "C:\Users\fic\source\repos\EscolaProgamacao\EscolaProgamacao\Views\Home\materias\Materias.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n");
#nullable restore
#line 21 "C:\Users\fic\source\repos\EscolaProgamacao\EscolaProgamacao\Views\Home\materias\Materias.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\fic\source\repos\EscolaProgamacao\EscolaProgamacao\Views\Home\materias\Materias.cshtml"
Write(Html.Partial("/Views/partials/Opcoes.cshtml"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Materia>> Html { get; private set; }
    }
}
#pragma warning restore 1591