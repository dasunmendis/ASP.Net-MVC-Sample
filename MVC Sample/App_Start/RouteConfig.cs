using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Sample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute("MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new { Controller = "Movies", Action = "ByRelaseDate" },
                //new { year = @"\d{4}", month = @"\d{2}" },
                new { year = @"2015|2016", month = @"\d{2}" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
