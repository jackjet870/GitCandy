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
    using NewLife.Serialization;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Team/Detail.cshtml")]
    public partial class _Views_Team_Detail_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.TeamModel>
    {
        public _Views_Team_Detail_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Team\Detail.cshtml"
  
    ViewBag.Title = String.Format(SR.Shared_TitleFormat, String.Format(SR.Team_DetailTitle, Model.Name));
    var token = GitCandy.Security.Token.Current;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h3>");

            
            #line 8 "..\..\Views\Team\Detail.cshtml"
Write(String.Format(SR.Team_DetailTitle, Model.Name));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n\r\n");

            
            #line 11 "..\..\Views\Team\Detail.cshtml"
 if (Model != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n\r\n        <dt>");

            
            #line 15 "..\..\Views\Team\Detail.cshtml"
       Write(Html.DisplayNameFor(s => s.Name));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 16 "..\..\Views\Team\Detail.cshtml"
       Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 18 "..\..\Views\Team\Detail.cshtml"
       Write(Html.DisplayNameFor(s => s.Members));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 19 "..\..\Views\Team\Detail.cshtml"
       Write(Html.DisplayFor(s => s.Members));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 21 "..\..\Views\Team\Detail.cshtml"
       Write(Html.DisplayNameFor(s => s.Repositories));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 22 "..\..\Views\Team\Detail.cshtml"
       Write(Html.DisplayFor(s => s.Repositories));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 24 "..\..\Views\Team\Detail.cshtml"
       Write(Html.DisplayNameFor(s => s.Description));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 25 "..\..\Views\Team\Detail.cshtml"
       Write(Model.Description);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n");

            
            #line 27 "..\..\Views\Team\Detail.cshtml"
        
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Team\Detail.cshtml"
         if (token != null &&  token.IsSystemAdministrator)
        {

            
            #line default
            #line hidden
WriteLiteral("        <dt></dt>\r\n");

WriteLiteral("        <dd>\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..\Views\Team\Detail.cshtml"
       Write(Html.ActionLink(SR.Shared_Edit, "Edit", new { name = Model.Name }, new { @class = "btn btn-primary" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 32 "..\..\Views\Team\Detail.cshtml"
       Write(Html.ActionLink(SR.Team_Members, "Users", new { name = Model.Name }, new { @class = "btn btn-info" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n");

            
            #line 34 "..\..\Views\Team\Detail.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </dl>\r\n");

            
            #line 36 "..\..\Views\Team\Detail.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
