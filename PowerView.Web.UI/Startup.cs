using Newtonsoft.Json.Serialization;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
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

            WebApiConfig.Register(httpConfiguration);

            httpConfiguration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            JsonMediaTypeFormatter jsonFormatter = httpConfiguration.Formatters.OfType<JsonMediaTypeFormatter>().First<JsonMediaTypeFormatter>();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterBundles(BundleTable.Bundles);

            httpConfiguration.DependencyResolver = new UnityDependencyResolver(UnityConfig.Container);
            
            SwaggerConfig.Register(httpConfiguration);

            app.UseWebApi(httpConfiguration);
           
        }

    }
}