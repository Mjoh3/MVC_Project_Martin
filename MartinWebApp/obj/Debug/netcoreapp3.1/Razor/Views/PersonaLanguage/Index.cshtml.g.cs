#pragma checksum "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\PersonaLanguage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8649d96b55b6d6e8fe65b59ad359a6209c64bbf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonaLanguage_Index), @"mvc.1.0.view", @"/Views/PersonaLanguage/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8649d96b55b6d6e8fe65b59ad359a6209c64bbf9", @"/Views/PersonaLanguage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42fb08e7ce2edc7db02210b9299a5c086668841", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonaLanguage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MartinWebApp.Models.Persona_Language>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\PersonaLanguage\Index.cshtml"
  
    ViewData["Title"] = "List of Persona_Language";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>List of personaLanguagesfrom database</h1>\r\n<table>\r\n");
#nullable restore
#line 7 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\PersonaLanguage\Index.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>LanguageId: ");
#nullable restore
#line 10 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\PersonaLanguage\Index.cshtml"
                       Write(p.LanguageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>PersonaId: ");
#nullable restore
#line 11 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\PersonaLanguage\Index.cshtml"
                      Write(p.PersonaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 15 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\PersonaLanguage\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MartinWebApp.Models.Persona_Language>> Html { get; private set; }
    }
}
#pragma warning restore 1591