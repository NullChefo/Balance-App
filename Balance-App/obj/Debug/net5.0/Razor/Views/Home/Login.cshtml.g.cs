#pragma checksum "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c49581e8e94964f816b5dee206485651266b34c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c49581e8e94964f816b5dee206485651266b34c", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balance_App.ViewModels.Home.LoginVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Home\Login.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"status\">\r\n    <h1>Login or Register</h1>\r\n\r\n\r\n</div>\r\n\r\n\r\n<form action=\"/Home/Login\" method=\"post\">\r\n    <div class=\"grid\">\r\n        <div class=\"row\">\r\n            <h2 class=\"padd\"> Username: </h2>\r\n            <div class=\"col-2\">");
#nullable restore
#line 19 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Home\Login.cshtml"
                          Write(Html.TextBoxFor(m => m.Username, new { @class = "form", placeholder = "Enter your username..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-2\">");
#nullable restore
#line 20 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Home\Login.cshtml"
                          Write(Html.ValidationMessageFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <h2 class=\"padd\"> Password: </h2>\r\n            <div class=\"col-2\">");
#nullable restore
#line 24 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Home\Login.cshtml"
                          Write(Html.PasswordFor(m => m.Password, new { @class = "form", placeholder = "Enter your password..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-2\">");
#nullable restore
#line 25 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Home\Login.cshtml"
                          Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-3\">");
#nullable restore
#line 28 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Home\Login.cshtml"
                          Write(Html.ValidationMessage("AuthenticationFailed"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

        </div>
        <div class=""sign-up"">
            <p>Maybe new here  <a href=""/Users/Create"">sign up here</a> for a account </p>
        </div>

        <div class=""flex-rowsmargin03"">
            <input class=""SubmitButton"" type=""submit"" value=""Login"" />
        </div>
    </div>
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balance_App.ViewModels.Home.LoginVM> Html { get; private set; }
    }
}
#pragma warning restore 1591