#pragma checksum "D:\Proyectos\Practicas\.Net Core\curso-mvc-core\Views\Shared\_AsignaturaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "598771583ecd0f950b5ef96e42784718a7c53051"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AsignaturaSimple), @"mvc.1.0.view", @"/Views/Shared/_AsignaturaSimple.cshtml")]
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
#line 1 "D:\Proyectos\Practicas\.Net Core\curso-mvc-core\Views\_ViewImports.cshtml"
using curso_mvc_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\Practicas\.Net Core\curso-mvc-core\Views\_ViewImports.cshtml"
using curso_mvc_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"598771583ecd0f950b5ef96e42784718a7c53051", @"/Views/Shared/_AsignaturaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3978741cb92b1bf9ad03c9c2f9c1b8e5c99805e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AsignaturaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asignatura>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    Nombre: ");
#nullable restore
#line 4 "D:\Proyectos\Practicas\.Net Core\curso-mvc-core\Views\Shared\_AsignaturaSimple.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n    Id: ");
#nullable restore
#line 5 "D:\Proyectos\Practicas\.Net Core\curso-mvc-core\Views\Shared\_AsignaturaSimple.cshtml"
   Write(Model.UniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asignatura> Html { get; private set; }
    }
}
#pragma warning restore 1591
