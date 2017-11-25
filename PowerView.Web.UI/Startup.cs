using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity.AspNet.WebApi;

namespace PowerView.Web.UI
{
    /// <summary>
    /// Application's entry point.-
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Configuring and start the application.-
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {

            HttpConfiguration httpConfiguration = new HttpConfiguration();

            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterBundles(BundleTable.Bundles);

            httpConfiguration.DependencyResolver = new UnityDependencyResolver(UnityConfig.Container);

            WebApiConfig.Register(httpConfiguration);

            SwaggerConfig.Register(httpConfiguration);

            app.UseWebApi(httpConfiguration);
           
        }

    }
}