#pragma checksum "C:\Users\11035904\source\repos\MvcApp001\MvcApp001\Views\RazorDemo\Ex01.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b46a47312a54b10b50eeb93941daef1165ea382"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RazorDemo_Ex01), @"mvc.1.0.view", @"/Views/RazorDemo/Ex01.cshtml")]
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
#line 1 "C:\Users\11035904\source\repos\MvcApp001\MvcApp001\Views\_ViewImports.cshtml"
using MvcApp001;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\11035904\source\repos\MvcApp001\MvcApp001\Views\_ViewImports.cshtml"
using MvcApp001.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b46a47312a54b10b50eeb93941daef1165ea382", @"/Views/RazorDemo/Ex01.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f859fd54dc1555966a28f2096d6c6774fd6046d9", @"/Views/_ViewImports.cshtml")]
    public class Views_RazorDemo_Ex01 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "razordemo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>hiii from ex01</h1>\r\n");
#nullable restore
#line 2 "C:\Users\11035904\source\repos\MvcApp001\MvcApp001\Views\RazorDemo\Ex01.cshtml"
 for (int i = 0; i < 10; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"button\"");
            BeginWriteAttribute("value", " value=", 83, "", 92, 1);
#nullable restore
#line 4 "C:\Users\11035904\source\repos\MvcApp001\MvcApp001\Views\RazorDemo\Ex01.cshtml"
WriteAttributeValue("", 90, i, 90, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 5 "C:\Users\11035904\source\repos\MvcApp001\MvcApp001\Views\RazorDemo\Ex01.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n");
#nullable restore
#line 7 "C:\Users\11035904\source\repos\MvcApp001\MvcApp001\Views\RazorDemo\Ex01.cshtml"
  
    string[] operations = { "Create", "Read", "Update", "Delete" };

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\11035904\source\repos\MvcApp001\MvcApp001\Views\RazorDemo\Ex01.cshtml"
 foreach (string op in operations)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"button\"");
            BeginWriteAttribute("value", " value=", 247, "", 257, 1);
#nullable restore
#line 12 "C:\Users\11035904\source\repos\MvcApp001\MvcApp001\Views\RazorDemo\Ex01.cshtml"
WriteAttributeValue("", 254, op, 254, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 13 "C:\Users\11035904\source\repos\MvcApp001\MvcApp001\Views\RazorDemo\Ex01.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("Goto:\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b46a47312a54b10b50eeb93941daef1165ea3825545", async() => {
                WriteLiteral("Back to Index");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
