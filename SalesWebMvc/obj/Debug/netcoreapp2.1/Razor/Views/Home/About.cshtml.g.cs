#pragma checksum "D:\Aréa de Trabalho\New folder (2)\SistemaWeb\SalesWebMvc\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d81d6ec17460b2ae34c4ed366591357eba0eced7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "D:\Aréa de Trabalho\New folder (2)\SistemaWeb\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "D:\Aréa de Trabalho\New folder (2)\SistemaWeb\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d81d6ec17460b2ae34c4ed366591357eba0eced7", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5200951b578265d5d6ccc50a38cf6b49023e2553", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Aréa de Trabalho\New folder (2)\SistemaWeb\SalesWebMvc\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(48, 17, false);
#line 5 "D:\Aréa de Trabalho\New folder (2)\SistemaWeb\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(65, 12, true);
            WriteLiteral(" </h2>\r\n<h3>");
            EndContext();
            BeginContext(78, 19, false);
#line 6 "D:\Aréa de Trabalho\New folder (2)\SistemaWeb\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(97, 24, true);
            WriteLiteral(" </h3>\r\n\r\n<p> Professor ");
            EndContext();
            BeginContext(122, 21, false);
#line 8 "D:\Aréa de Trabalho\New folder (2)\SistemaWeb\SalesWebMvc\Views\Home\About.cshtml"
         Write(ViewData["Professor"]);

#line default
#line hidden
            EndContext();
            BeginContext(143, 132, true);
            WriteLiteral(" </p>\r\n\r\n<address>\r\n    <strong>More information: </strong> <a href=\"http://educandoweb.com.br\">Educandoweb.com.br</a>\r\n</address>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
