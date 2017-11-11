using PowerView.DataAccess;
using PowerView.DataAccess.Abstractions;
using PowerView.Infrastructure;
using PowerView.IoT.Ingestion;
using PowerView.IoT.Ingestion.Mqtt;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace PowerView.IOT.Host
{
    public static class UnityConfig
    {
        public static void RegisterComponents(IUnityContainer container)
        {
            container.RegisterType<IConfiguration, PowerView.Infrastructure.Configuration>();

            container.RegisterType<IMetricIngestor, MetricIngestor>();

            container.RegisterType<IMeasurementRepository, MeasurementRepository>();

            container.RegisterType<IMqttClient, MqttClient>(new Unity.Injection.InjectionConstructor(ConfigurationManager.AppSettings["MQTTBrokerAdsress"]));
        }
    }

}
