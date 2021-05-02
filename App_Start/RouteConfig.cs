using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FootballLeague
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Admin", // Route name
                "League/Index", // URL 
                new { controller = "League", action = "Index" } // Parameter defaults
            );

            routes.MapRoute(
                name: "User",
                url: "UserLeague/Index",
                defaults: new {controller = "User/UserLeague", action = "Index"}
                );
        }
    }
}
