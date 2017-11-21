using Owin;
using PowerView.DataAccess;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain.Logic;
using PowerView.Domain.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace PowerView.Web.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration httpConfiguration = new HttpConfiguration();

            UnityConfig.Register(httpConfiguration);

            WebApiConfig.Register(httpConfiguration);

            SwaggerConfig.Register(httpConfiguration);           

            appBuilder.UseWebApi(httpConfiguration);

        }

    }
}