#pragma checksum "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c232cb3a6fd4eb51cb4e4e0d7a8ae3ed4bf3e63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScopeListItem), @"mvc.1.0.view", @"/Views/Shared/_ScopeListItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ScopeListItem.cshtml", typeof(AspNetCore.Views_Shared__ScopeListItem))]
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
#line 1 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c232cb3a6fd4eb51cb4e4e0d7a8ae3ed4bf3e63", @"/Views/Shared/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b49bb18fbe88f2fb7e20eb130e64338d7f2c37", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 157, true);
            WriteLiteral("\r\n<li class=\"list-group-item\">\r\n    <label>\r\n        <input class=\"consent-scopecheck\"\r\n               type=\"checkbox\"\r\n               name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("id", "\r\n               id=\"", 180, "\"", 219, 2);
            WriteAttributeValue("", 201, "scopes_", 201, 7, true);
#line 8 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 208, Model.Name, 208, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n               value=\"", 220, "\"", 255, 1);
#line 9 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 244, Model.Name, 244, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\r\n               checked=\"", 256, "\"", 296, 1);
#line 10 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 282, Model.Checked, 282, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\r\n               disabled=\"", 297, "\"", 339, 1);
#line 11 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 324, Model.Required, 324, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(340, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 12 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
            BeginContext(386, 75, true);
            WriteLiteral("            <input type=\"hidden\"\r\n                   name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("value", "\r\n                   value=\"", 461, "\"", 500, 1);
#line 16 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 489, Model.Name, 489, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(501, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 17 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
            BeginContext(517, 16, true);
            WriteLiteral("        <strong>");
            EndContext();
            BeginContext(534, 17, false);
#line 18 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(551, 11, true);
            WriteLiteral("</strong>\r\n");
            EndContext();
#line 19 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
            BeginContext(604, 72, true);
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\r\n");
            EndContext();
#line 22 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
            BeginContext(687, 14, true);
            WriteLiteral("    </label>\r\n");
            EndContext();
#line 24 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
            BeginContext(734, 42, true);
            WriteLiteral("        <span><em>(required)</em></span>\r\n");
            EndContext();
#line 27 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
            BeginContext(783, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 28 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
            BeginContext(827, 61, true);
            WriteLiteral("        <div class=\"consent-description\">\r\n            <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 888, "\"", 912, 2);
            WriteAttributeValue("", 894, "scopes_", 894, 7, true);
#line 31 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 901, Model.Name, 901, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(913, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(915, 17, false);
#line 31 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(932, 26, true);
            WriteLiteral("</label>\r\n        </div>\r\n");
            EndContext();
#line 33 "C:\Users\bsegunto\Desktop\securing-angular-client\Team-Kangkong-2020\Angular api and sts\SecuringAngularApps.STS\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
            BeginContext(965, 5, true);
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
