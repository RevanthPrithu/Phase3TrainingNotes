#pragma checksum "C:\Users\11035904\source\repos\RpMVCApp\RpMVCApp\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86fd9eb2c1bd41d0359a6a4b470b92403cf10b72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "C:\Users\11035904\source\repos\RpMVCApp\RpMVCApp\Views\_ViewImports.cshtml"
using RpMVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\11035904\source\repos\RpMVCApp\RpMVCApp\Views\_ViewImports.cshtml"
using RpMVCApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86fd9eb2c1bd41d0359a6a4b470b92403cf10b72", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f61504ce5e5f59845e6d5496654c5e3d482a665", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Student Index View</h1>\r");
#nullable restore
#line 2 "C:\Users\11035904\source\repos\RpMVCApp\RpMVCApp\Views\Students\Index.cshtml"
 using (Html.BeginForm()){

#line default
#line hidden
#nullable disable
            WriteLiteral("<button name=\"b1\" value=\"sqlserver\">Sql Server</button>\r                <button name=\"b1\" value=\"mysqlserver\">My Sql Server</button>");
#nullable restore
#line 5 "C:\Users\11035904\source\repos\RpMVCApp\RpMVCApp\Views\Students\Index.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\11035904\source\repos\RpMVCApp\RpMVCApp\Views\Students\Index.cshtml"
Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r");
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
