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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/About.cshtml")]
    public partial class _Views_Home_About_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_About_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\About.cshtml"
  
    ViewBag.Title = String.Format(SR.Shared_TitleFormat, SR.Home_AboutTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h4>");

            
            #line 5 "..\..\Views\Home\About.cshtml"
Write(SR.Home_AboutTitle);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n\r\n<div");

WriteLiteral(" id=\"md\"");

WriteLiteral(">\r\n");

            
            #line 8 "..\..\Views\Home\About.cshtml"
Write(Html.Raw(SR.Home_AboutDescription));

            
            #line default
            #line hidden
WriteLiteral("\r\n* [ASP.NET MVC](http://aspnetwebstack.codeplex.com/) ");

WriteLiteral("@ [Apache License 2.0](http://aspnetwebstack.codeplex.com/license)\r\n* [Bootstrap]" +
"(http://github.com/twbs/bootstrap) ");

WriteLiteral("@ [MIT License](http://github.com/twbs/bootstrap/blob/master/LICENSE)\r\n* [Bootstr" +
"ap-switch](http://github.com/nostalgiaz/bootstrap-switch) ");

WriteLiteral("@ [Apache License 2.0](http://github.com/nostalgiaz/bootstrap-switch/blob/master/" +
"LICENSE)\r\n* [EntityFramework](http://entityframework.codeplex.com/) ");

WriteLiteral("@ [Apache License 2.0](http://entityframework.codeplex.com/license)\r\n* [FxSsh](ht" +
"tp://github.com/Aimeast/FxSsh) ");

WriteLiteral("@ [MIT license](http://github.com/Aimeast/FxSsh/blob/master/LICENSE.md)\r\n* [Highl" +
"ight.js](http://github.com/isagalaev/highlight.js) ");

WriteLiteral("@ [New BSD License](http://github.com/isagalaev/highlight.js/blob/master/LICENSE)" +
"\r\n* [jQuery](http://github.com/jquery/jquery) ");

WriteLiteral("@ [MIT License](http://github.com/jquery/jquery/blob/master/MIT-LICENSE.txt)\r\n* [" +
"LibGit2Sharp](http://github.com/libgit2/libgit2sharp) ");

WriteLiteral("@ [MIT License](http://github.com/libgit2/libgit2sharp/blob/master/LICENSE.md)\r\n*" +
" [marked](http://github.com/chjj/marked) ");

WriteLiteral("@ [MIT License](http://github.com/chjj/marked/blob/master/LICENSE)\r\n* [Microsoft." +
"Composition (MEF2)](http://mef.codeplex.com/) ");

WriteLiteral("@ [Microsoft Public License](http://mef.codeplex.com/license)\r\n* [Newtonsoft.Json" +
"](http://json.codeplex.com/) ");

WriteLiteral("@ [MIT License](http://json.codeplex.com/license)\r\n* [SharpZipLib](http://github." +
"com/icsharpcode/SharpZipLib) ");

WriteLiteral("@ [GPL License v2](http://github.com/icsharpcode/SharpZipLib/blob/master/doc/COPY" +
"ING.txt)\r\n</div>\r\n<!--\r\n");

            
            #line 23 "..\..\Views\Home\About.cshtml"
Write(AppInfomation.BuildingInformation);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\nVersion: ");

            
            #line 25 "..\..\Views\Home\About.cshtml"
    Write(AppInfomation.Version);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\nTracing: ");

            
            #line 27 "..\..\Views\Home\About.cshtml"
    Write(AppInfomation.DateTimeOffsetFormatedNow);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\nStarting: ");

            
            #line 29 "..\..\Views\Home\About.cshtml"
     Write(AppInfomation.StartingTime);

            
            #line default
            #line hidden
WriteLiteral("\r\n-->");

        }
    }
}
#pragma warning restore 1591
