#pragma checksum "C:\Users\fic\source\repos\Floricultura2\Floricultura2\Views\Flores\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cec533572a5d2ece702b77986b3249c9e423c91a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flores_Detalhes), @"mvc.1.0.view", @"/Views/Flores/Detalhes.cshtml")]
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
#line 1 "C:\Users\fic\source\repos\Floricultura2\Floricultura2\Views\_ViewImports.cshtml"
using Floricultura2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fic\source\repos\Floricultura2\Floricultura2\Views\_ViewImports.cshtml"
using Floricultura2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cec533572a5d2ece702b77986b3249c9e423c91a", @"/Views/Flores/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf7f31316f6119ec7b48f55b6ea37763fba4f5e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Flores_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Flor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fic\source\repos\Floricultura2\Floricultura2\Views\Flores\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes da ");
#nullable restore
#line 6 "C:\Users\fic\source\repos\Floricultura2\Floricultura2\Views\Flores\Detalhes.cshtml"
           Write(Model.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>");
#nullable restore
#line 7 "C:\Users\fic\source\repos\Floricultura2\Floricultura2\Views\Flores\Detalhes.cshtml"
Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Flor> Html { get; private set; }
    }
}
#pragma warning restore 1591
