﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using GitCandy.Models;
using NewLife.GitCandy.Entity;

namespace GitCandy.Extensions
{
    public static class HtmlHelperExtension
    {
        public static RouteValueDictionary OverRoute(this HtmlHelper helper, object routeValues = null, bool withQuery = false)
        {
            var old = helper.ViewContext.RouteData.Values;
            if (routeValues == null) return old;

            var over = new Dictionary<String, object>(old, StringComparer.OrdinalIgnoreCase);
            if (withQuery)
            {
                var qs = helper.ViewContext.HttpContext.Request.QueryString;
                foreach (String key in qs)
                    over[key] = qs[key];
            }
            var values = new RouteValueDictionary(routeValues);
            foreach (var pair in values)
                over[pair.Key] = pair.Value;

            return new RouteValueDictionary(over);
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, String linkText, String actionName, RouteValueDictionary routeValues, object htmlAttributes)
        {
            return LinkExtensions.ActionLink(htmlHelper, linkText, actionName, routeValues, htmlAttributes.CastToDictionary());
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, String linkText, String actionName, String controllerName, RouteValueDictionary routeValues, object htmlAttributes)
        {
            return LinkExtensions.ActionLink(htmlHelper, linkText, actionName, controllerName, routeValues, htmlAttributes.CastToDictionary());
        }

        public static MvcHtmlString CultureActionLink(this HtmlHelper htmlHelper, String langName)
        {
            var culture = CultureInfo.CreateSpecificCulture(langName);
            var displayName = culture.Name.StartsWith("en")
                ? culture.NativeName
                : culture.EnglishName + " - " + culture.NativeName;

            return LinkExtensions.ActionLink(htmlHelper, displayName, "Language", "Home", new { Lang = culture.Name }, null);
        }

        public static dynamic GetRootViewBag(this HtmlHelper html)
        {
            var controller = html.ViewContext.Controller;
            while (controller.ControllerContext.IsChildAction)
            {
                controller = controller.ControllerContext.ParentActionViewContext.Controller;
            }
            return controller.ViewBag;
        }

        public static MvcHtmlString Link(this HtmlHelper html, RepositoryModelBase repo)
        {
            if (repo == null) return null;

            var user = User.FindByName(repo.Owner);
            if (user == null) return null;

            var link1 = html.ActionLink(repo.Owner, "Detail", user.IsTeam ? "Team" : "Account", new { name = repo.Owner }, null);
            //var link2 = html.ActionLink(repo.Name, "Tree", new { owner = repo.Owner, name = repo.Name, path = "" });
            var link2 = html.RouteLink(repo.Name, "UserGitWeb", new { owner = repo.Owner, name = repo.Name });

            return new MvcHtmlString(link1.ToHtmlString() + "/" + link2.ToHtmlString());
        }
    }
}