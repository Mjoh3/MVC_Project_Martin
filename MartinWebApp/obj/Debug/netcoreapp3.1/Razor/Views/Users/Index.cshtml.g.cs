#pragma checksum "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0efb3769e72cd07836d484ab5eb0143e2ece8035"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 5 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0efb3769e72cd07836d484ab5eb0143e2ece8035", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22a00661d241bf740cd3ecd8c082193e663d567", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MartinWebApp.Models.ApplicationUser>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "List of users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List of people from database</h1>\r\n<table>\r\n");
#nullable restore
#line 8 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Users\Index.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n\r\n        <td>First Name: ");
#nullable restore
#line 12 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Users\Index.cshtml"
                   Write(p.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>Last Name: ");
#nullable restore
#line 13 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Users\Index.cshtml"
                  Write(p.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>E-mail: ");
#nullable restore
#line 14 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Users\Index.cshtml"
               Write(p.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>Birthday: ");
#nullable restore
#line 15 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Users\Index.cshtml"
                 Write(p.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Users\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<select name=\"dog-names\" id=\"dog-names\">\r\n    \r\n");
#nullable restore
#line 23 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Users\Index.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0efb3769e72cd07836d484ab5eb0143e2ece80355117", async() => {
#nullable restore
#line 25 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Users\Index.cshtml"
                         Write(p.Email);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Users\Index.cshtml"
           WriteLiteral(p.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Users\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</select>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MartinWebApp.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
