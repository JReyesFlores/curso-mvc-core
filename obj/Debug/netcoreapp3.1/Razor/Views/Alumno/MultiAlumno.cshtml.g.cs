#pragma checksum "D:\Proyectos\Practicas\.Net Core\curso-mvc-core\Views\Alumno\MultiAlumno.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adb41fcdec62315a65307436d5dd9b45f6735335"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumno_MultiAlumno), @"mvc.1.0.view", @"/Views/Alumno/MultiAlumno.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb41fcdec62315a65307436d5dd9b45f6735335", @"/Views/Alumno/MultiAlumno.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3978741cb92b1bf9ad03c9c2f9c1b8e5c99805e", @"/Views/_ViewImports.cshtml")]
    public class Views_Alumno_MultiAlumno : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Alumno>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Proyectos\Practicas\.Net Core\curso-mvc-core\Views\Alumno\MultiAlumno.cshtml"
  
    ViewData["Title"] = "Lista de alumnos";
    //Layout = "_Simple";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\Proyectos\Practicas\.Net Core\curso-mvc-core\Views\Alumno\MultiAlumno.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1> \r\n\r\n<strong>Lista de Alumno</strong>\r\n");
            WriteLiteral("\r\n<table class=\"table table-dark table-hover table-sm\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Nombre</th>\r\n            <th scope=\"col\">Id</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "D:\Proyectos\Practicas\.Net Core\curso-mvc-core\Views\Alumno\MultiAlumno.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 26 "D:\Proyectos\Practicas\.Net Core\curso-mvc-core\Views\Alumno\MultiAlumno.cshtml"
               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 27 "D:\Proyectos\Practicas\.Net Core\curso-mvc-core\Views\Alumno\MultiAlumno.cshtml"
               Write(item.UniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\Proyectos\Practicas\.Net Core\curso-mvc-core\Views\Alumno\MultiAlumno.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Alumno>> Html { get; private set; }
    }
}
#pragma warning restore 1591