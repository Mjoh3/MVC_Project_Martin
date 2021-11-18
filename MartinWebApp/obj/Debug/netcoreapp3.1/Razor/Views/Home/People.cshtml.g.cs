#pragma checksum "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0041fbe21bb43018585ef0612deed3613c8c585e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_People), @"mvc.1.0.view", @"/Views/Home/People.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0041fbe21bb43018585ef0612deed3613c8c585e", @"/Views/Home/People.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42fb08e7ce2edc7db02210b9299a5c086668841", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_People : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MartinWebApp.Models.PeopleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partialPerson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
  
    ViewData["Title"] = "People";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>People</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
 foreach (var item in MartinWebApp.Models.PeopleViewModel.peopleResult)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0041fbe21bb43018585ef0612deed3613c8c585e3555", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 12 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Search People</h2>\r\n");
#nullable restore
#line 15 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
 using (Html.BeginForm("PeopleSearch", "Home", FormMethod.Post, new { id = "searchForm" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>Name:</label>\r\n    <input type=\"text\" name=\"name\" />\r\n    <label>Tele:</label>\r\n    <input type=\"text\" name=\"phonenumber\" />\r\n    <label>City:</label>\r\n    <input type=\"text\" name=\"city\" />\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Search\" />\r\n");
#nullable restore
#line 25 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Add Person</h2>\r\n");
#nullable restore
#line 28 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
 using (Html.BeginForm("People", "Home", FormMethod.Post, new { id = "addForm" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>Name:</label>\r\n    <input type=\"text\" name=\"name\" />\r\n    <label>Tele:</label>\r\n    <input type=\"text\" name=\"phonenumber\" />\r\n    <label>City:</label>\r\n    <input type=\"text\" name=\"city\" />\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Add\" />\r\n");
#nullable restore
#line 38 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
 if (ViewBag.ErrorMess != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 41 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
  Write(ViewBag.ErrorMess);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 42 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Results</h2>\r\n<table>\r\n");
#nullable restore
#line 46 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
     foreach (var p in MartinWebApp.Models.PeopleViewModel.peopleResult)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>Name: ");
#nullable restore
#line 49 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
                 Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>Tele: ");
#nullable restore
#line 50 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
                 Write(p.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>City: ");
#nullable restore
#line 51 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
                 Write(p.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n\r\n");
#nullable restore
#line 54 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
                 using (Html.BeginForm("PeopleDelete", "Home", FormMethod.Post, new { id = "deleteForm" }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=", 1585, "", 1599, 1);
#nullable restore
#line 56 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
WriteAttributeValue("", 1592, p.Name, 1592, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"name\" />\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=", 1656, "", 1677, 1);
#nullable restore
#line 57 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
WriteAttributeValue("", 1663, p.PhoneNumber, 1663, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"phonenumber\" />\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=", 1741, "", 1755, 1);
#nullable restore
#line 58 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
WriteAttributeValue("", 1748, p.City, 1748, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"city\" />\r\n                    <input type=\"submit\" value=\"Delete\" />\r\n");
#nullable restore
#line 60 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Martin Johansson\source\repos\MartinWebApp\MartinWebApp\Views\Home\People.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MartinWebApp.Models.PeopleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
