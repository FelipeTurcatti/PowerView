using PowerView.DataAccess;
using PowerView.DataAccess.Abstractions;
using PowerView.IoT.Ingestion;
using System;
using System.Collections.Generic;
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
            container.RegisterType<IMetricIngestor, MetricIngestor>();

            container.RegisterType<IMeasurementRepository, MeasurementRepository>();
        }
    }

}
