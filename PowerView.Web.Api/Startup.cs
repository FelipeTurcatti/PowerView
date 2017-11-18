using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;



namespace PowerView.Web.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration httpConfiguration = new HttpConfiguration();

            WebApiConfig.Register(httpConfiguration);

            SwaggerConfig.Register(httpConfiguration);           

            appBuilder.UseWebApi(httpConfiguration);

        }

    }
}