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
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<ISensorRepository, SensorRepository>();
            container.RegisterType<ISensorService, SensorService>();
            
            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}