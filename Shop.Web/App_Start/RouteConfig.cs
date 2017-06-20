using Shop.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Shop.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new
                {
                    serverRooute = new ServerRouteConstraint(url =>
                    {
                        return url.PathAndQuery.StartsWith("/swagger",
                            StringComparison.InvariantCultureIgnoreCase);
                    })
                }
            );

            routes.MapRoute(
               name: "angular",
               url: "{*url}",
               defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
