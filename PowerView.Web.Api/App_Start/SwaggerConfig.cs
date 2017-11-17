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
                c.SingleApiVersion("v1", "PowerView API")
                .Description("Power view Web Api services")
                .Contact(cc => cc.Name("Lisandro \"El Lechón\" Schneir")
                .Url("https://github.com/FelipeTurcatti/PowerView")
                .Email("lisandro.schneir@gmail.com"))
                .License(lc => lc.Name("License")
                .Url("https://github.com/FelipeTurcatti/PowerView"));
            }).EnableSwaggerUi();

        }
    }
}