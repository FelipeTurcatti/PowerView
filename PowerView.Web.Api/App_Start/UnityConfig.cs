using PowerView.DataAccess;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain.Logic;
using PowerView.Domain.Logic.Interface;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace PowerView.Web.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            
            container.RegisterType<ISensorRepository, SensorRepository>();
            container.RegisterType<ISensorService, SensorService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}