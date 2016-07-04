using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace mi9cc
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "Index",
            //    routeTemplate: "",
            //    defaults: new { controller = "Values", action = "Index" }
            //);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional, controller = "FilterShows" }
            );


        }
    }
}
