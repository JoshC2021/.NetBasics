#pragma checksum "C:\Users\Josh\source\repos\IntroMVCApp\IntroMVCApp\Views\Home\LogResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39cf981e0abc7e77d35514597dde7b42b2387f16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LogResult), @"mvc.1.0.view", @"/Views/Home/LogResult.cshtml")]
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
#line 1 "C:\Users\Josh\source\repos\IntroMVCApp\IntroMVCApp\Views\_ViewImports.cshtml"
using IntroMVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josh\source\repos\IntroMVCApp\IntroMVCApp\Views\_ViewImports.cshtml"
using IntroMVCApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39cf981e0abc7e77d35514597dde7b42b2387f16", @"/Views/Home/LogResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a11e84b8a6b408d40535dfb727f59684f20d81a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LogResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LogResult>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>USER Info</p>\r\n<p>Name: ");
#nullable restore
#line 4 "C:\Users\Josh\source\repos\IntroMVCApp\IntroMVCApp\Views\Home\LogResult.cshtml"
    Write(Model.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Password: ");
#nullable restore
#line 5 "C:\Users\Josh\source\repos\IntroMVCApp\IntroMVCApp\Views\Home\LogResult.cshtml"
        Write(Model.userPassword);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Age: ");
#nullable restore
#line 6 "C:\Users\Josh\source\repos\IntroMVCApp\IntroMVCApp\Views\Home\LogResult.cshtml"
   Write(Model.userAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogResult> Html { get; private set; }
    }
}
#pragma warning restore 1591