#pragma checksum "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51c9022638580341647ae3e88d2e2c4d072f0fbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Balance_Share), @"mvc.1.0.view", @"/Views/Balance/Share.cshtml")]
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
#line 2 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
using Balance_App.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51c9022638580341647ae3e88d2e2c4d072f0fbb", @"/Views/Balance/Share.cshtml")]
    public class Views_Balance_Share : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balance_App.ViewModels.Balance.ShareVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
  
    ViewBag.Title = "Share Balance";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"grid\">\r\n    <row class=\"col-3\">\r\n        <h1>Share Balance:</h1>\r\n        <span class=\"b\">Balance Name: </span> ");
#nullable restore
#line 11 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
                                         Write(Model.Balance.NameOrType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        <span class=\"b\">Ex. Date: </span> ");
#nullable restore
#line 12 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
                                     Write(Model.Balance.ExDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        <span class=\"b\">Balance Amount: </span> ");
#nullable restore
#line 13 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
                                           Write(Model.Balance.BalancesAmound);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </row>\r\n\r\n");
#nullable restore
#line 16 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
     foreach (User item in Model.SharedWith)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 18 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 19 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
      Write(item.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div class=\"row\">\r\n            <div class=\"col-2\"> First Name : ");
#nullable restore
#line 21 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
                                        Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-2\">Last Name :");
#nullable restore
#line 22 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
                                     Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-2\">Username :");
#nullable restore
#line 23 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
                                    Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-2\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 876, "\"", 948, 4);
            WriteAttributeValue("", 883, "/Balance/RevokeAccess?UserId=", 883, 29, true);
#nullable restore
#line 25 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
WriteAttributeValue("", 912, item.Id, 912, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 920, "&BalanceId=", 920, 11, true);
#nullable restore
#line 25 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
WriteAttributeValue("", 931, Model.Balance.Id, 931, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remove access</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 28 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n    <form action=\"/Balance/Share\" method=\"post\">\r\n        <input type=\"hidden\" name=\"BalanceId\"");
            BeginWriteAttribute("value", " value=\"", 1115, "\"", 1140, 1);
#nullable restore
#line 34 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
WriteAttributeValue("", 1123, Model.Balance.Id, 1123, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n        <div class=\"row\">\r\n            <h2>Shere Balance:</h2>\r\n        </div>\r\n\r\n");
#nullable restore
#line 41 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
         foreach (User item in Model.Users)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-3\">\r\n                    <input");
            BeginWriteAttribute("id", " id=\"", 1382, "\"", 1404, 2);
            WriteAttributeValue("", 1387, "lblUser", 1387, 7, true);
#nullable restore
#line 45 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
WriteAttributeValue("", 1394, item.Id, 1394, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\" name=\"UserIds\"");
            BeginWriteAttribute("value", " value=\"", 1436, "\"", 1453, 2);
#nullable restore
#line 45 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
WriteAttributeValue("", 1444, item.Id, 1444, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1452, "", 1453, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <label");
            BeginWriteAttribute("for", " for=\"", 1485, "\"", 1508, 2);
            WriteAttributeValue("", 1491, "lblUser", 1491, 7, true);
#nullable restore
#line 46 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
WriteAttributeValue("", 1498, item.Id, 1498, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
                                              Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
                                                              Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 50 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Share.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



        <div class=""row"">
            <div class=""col-2"">
                <input class=""SubmitButton"" type=""submit"" value=""Share"" />
            </div>
        </div>
    </form>


    <div class=""row"">
        <h2>This balance is shared with:</h2>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balance_App.ViewModels.Balance.ShareVM> Html { get; private set; }
    }
}
#pragma warning restore 1591