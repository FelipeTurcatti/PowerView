using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Swashbuckle.Application;

namespace PowerView.Web.UI
{
    /// <summary>
    /// Swagger documentation configration
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// Registering and configuring swagger documentation.-
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "PowerView API");
                c.IncludeXmlComments(string.Format(@"{0}\bin\PowerView.Web.UI.XML", System.AppDomain.CurrentDomain.BaseDirectory));
                
            }).EnableSwaggerUi();

        }
    }
}