﻿using System.Web.Mvc;
using System.Web.Routing;

namespace MessageBoard
{
    public class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("MyMessages", "MyMessages", new {controller = "Home", action = "MyMessages"});

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}
                );
        }

    }
}