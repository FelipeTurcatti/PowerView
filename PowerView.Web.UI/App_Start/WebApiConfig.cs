using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PowerView.Web.UI
{
    /// <summary>
    /// Web api configuration
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Register web api routes.-
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
