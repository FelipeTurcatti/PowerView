using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Swashbuckle.Application;

namespace PowerView.Web.Api
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "PowerView API");
                c.IncludeXmlComments(string.Format(@"{0}\bin\PowerView.Web.Api.XML", System.AppDomain.CurrentDomain.BaseDirectory));
                
            }).EnableSwaggerUi();

        }
    }
}