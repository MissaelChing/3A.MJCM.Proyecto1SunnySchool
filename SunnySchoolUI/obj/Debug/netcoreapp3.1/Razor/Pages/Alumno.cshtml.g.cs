#pragma checksum "C:\Users\jaime\Source\Repos\SunnySchool\SunnySchoolUI\Pages\Alumno.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eae0dd2a6f62d4bd7ce2afe08dc33256531b01ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SunnySchoolUI.Pages.Pages_Alumno), @"mvc.1.0.razor-page", @"/Pages/Alumno.cshtml")]
namespace SunnySchoolUI.Pages
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
#line 1 "C:\Users\jaime\Source\Repos\SunnySchool\SunnySchoolUI\Pages\_ViewImports.cshtml"
using SunnySchoolUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eae0dd2a6f62d4bd7ce2afe08dc33256531b01ee", @"/Pages/Alumno.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f5a8f7688f7cbaa57e4a503cd988537969a424", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Alumno : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\jaime\Source\Repos\SunnySchool\SunnySchoolUI\Pages\Alumno.cshtml"
  
    ViewData["Title"] = "Alumno";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <h1 class=""title"">Datos del Alumno</h1>
        </div>
        <div class=""col-md-12"">
            <div class=""form-group"">
                <label>Nombre del Alumno</label>
                <input type=""text"" class=""form-control"">
            </div>
        </div>

        <div class=""col-md-4"">
            <div class=""form-group"">
                <label>Nombre del Padre o tutor</label>
                <input type=""text"" class=""form-control"">
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label>Fecha De Nacimiento</label>
                <input type=""date"" class=""form-control"">
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label>Nacionalidad</label>
                <input type=""text"" class=""form-control"">
            </div>
        </div>
   ");
            WriteLiteral(@"     <div class=""col-md-6"">
            <div class=""form-group"">
                <label>Ocupacion</label>
                <input type=""text"" class=""form-control"">
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""form-group"">
                <label>Ingreso</label>
                <input type=""number"" class=""form-control"">
            </div>


        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label>Nombre del Madre o tutora</label>
                <input type=""text"" class=""form-control"">
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label>Fecha De Nacimiento</label>
                <input type=""date"" class=""form-control"">
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label>Nacionalidad</label>
                <input ");
            WriteLiteral(@"type=""text"" class=""form-control"">
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""form-group"">
                <label>Ocupacion</label>
                <input type=""text"" class=""form-control"">
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""form-group"">
                <label>Ingreso</label>
                <input type=""number"" class=""form-control"">
            </div>
        </div>

    </div>
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label>Colonia</label>
                <input type=""text"" class=""form-control"">
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label>Municipio</label>
                <input type=""text"" class=""form-control"">
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label>C");
            WriteLiteral(@"omnunidad o Localidad</label>
                <input type=""text"" class=""form-control"">
            </div>
        </div>
        <div class=""col-md-12"">
            <input type=""button"" class=""btn btn-info btn-block"" value=""Guardar"">
        </div>
    </div>



</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SunnySchoolUI.Pages.AlumnoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SunnySchoolUI.Pages.AlumnoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SunnySchoolUI.Pages.AlumnoModel>)PageContext?.ViewData;
        public SunnySchoolUI.Pages.AlumnoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591