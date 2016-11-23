﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using GitCandy;
    using GitCandy.App_GlobalResources;
    using GitCandy.Base;
    using GitCandy.Configuration;
    using GitCandy.Extensions;
    using GitCandy.Models;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 2 "..\..\Views\Team\Users.cshtml"
    using NewLife.Serialization;
    
    #line default
    #line hidden
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Team/Users.cshtml")]
    public partial class _Views_Team_Users_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.TeamModel>
    {
        public _Views_Team_Users_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\Team\Users.cshtml"
  
    ViewBag.Title = String.Format(SR.Shared_TitleFormat, String.Format(SR.Team_ChooseUserTitle, Model.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h4>");

            
            #line 8 "..\..\Views\Team\Users.cshtml"
Write(String.Format(SR.Team_ChooseUserTitle, Model.Name));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n\r\n");

            
            #line 10 "..\..\Views\Team\Users.cshtml"
 if (Model != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"chooser\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 17 "..\..\Views\Team\Users.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        var team = \"");

            
            #line 19 "..\..\Views\Team\Users.cshtml"
               Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\";\r\n        var chooser_params = [];\r\n        chooser_params.push(\r\n            {" +
"\r\n                data: ");

            
            #line 23 "..\..\Views\Team\Users.cshtml"
                 Write(Html.Raw(Model.MembersRole.ToJson()));

            
            #line default
            #line hidden
WriteLiteral(",\r\n                controller: \"Account\",\r\n                container: \"#chooser\"," +
"\r\n                add_label: \"");

            
            #line 26 "..\..\Views\Team\Users.cshtml"
                       Write(SR.Shared_Add);

            
            #line default
            #line hidden
WriteLiteral("\",\r\n                del_label: \"");

            
            #line 27 "..\..\Views\Team\Users.cshtml"
                       Write(SR.Shared_Remove);

            
            #line default
            #line hidden
WriteLiteral("\",\r\n                add_action: { url: \"");

            
            #line 28 "..\..\Views\Team\Users.cshtml"
                               Write(Url.Action("ChooseUser","Team"));

            
            #line default
            #line hidden
WriteLiteral("\", query: function (item) { return { name: team, user: item, act: \"add\" }; } },\r\n" +
"                del_action: { url: \"");

            
            #line 29 "..\..\Views\Team\Users.cshtml"
                               Write(Url.Action("ChooseUser","Team"));

            
            #line default
            #line hidden
WriteLiteral("\", query: function (item) { return { name: team, user: item, act: \"del\" }; } },\r\n" +
"                action_array: [\r\n                    {\r\n                        " +
"key: \"IsAdministrator\",\r\n                        on_label: \"");

            
            #line 33 "..\..\Views\Team\Users.cshtml"
                              Write(SR.Team_ShortAdministrator);

            
            #line default
            #line hidden
WriteLiteral("\",\r\n                        off_label: \"");

            
            #line 34 "..\..\Views\Team\Users.cshtml"
                               Write(SR.Team_ShortNonAdministrator);

            
            #line default
            #line hidden
WriteLiteral("\",\r\n                        checked: { url: \"");

            
            #line 35 "..\..\Views\Team\Users.cshtml"
                                    Write(Url.Action("ChooseUser","Team"));

            
            #line default
            #line hidden
WriteLiteral("\", query: function (item) { return { name: team, user: item, act: \"admin\" }; } }," +
"\r\n                        unchecked: { url: \"");

            
            #line 36 "..\..\Views\Team\Users.cshtml"
                                      Write(Url.Action("ChooseUser","Team"));

            
            #line default
            #line hidden
WriteLiteral("\", query: function (item) { return { name: team, user: item, act: \"member\" }; } }" +
",\r\n                    }\r\n                ]\r\n            });\r\n    </script>\r\n");

            
            #line 41 "..\..\Views\Team\Users.cshtml"
}

            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\Team\Users.cshtml"
Write(Html.ActionLink(SR.Shared_Back, "Detail", new { Model.Name }, new { @class = "btn btn-default" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
