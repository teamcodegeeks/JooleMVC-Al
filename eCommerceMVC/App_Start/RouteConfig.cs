﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eCommerceMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //routes.MapRoute(
            //    name: "Search",
            //    url: "{controller}/{action}/{id}",
            //    new { controller = "Search", action = "Search", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Searchbar",
                url: "{controller}/{action}/{id}",
                new { controller = "Search", action = "_Searchbarpartial", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
