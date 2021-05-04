using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC8amKings
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "new", action = "helloworld", id = UrlParameter.Optional }
         );

            routes.MapRoute(
                name: "Default1",
                url: "pistahouse/cake",
                defaults: new { controller = "new", action = "helloworld", id = UrlParameter.Optional }
            );

           
        }
    }
}
