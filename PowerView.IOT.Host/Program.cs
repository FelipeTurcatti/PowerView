using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace PowerView.IOT.Host
{
    static class Program
    {
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {

            UnityContainer container = new UnityContainer();

            UnityConfig.RegisterComponents(container);

            if (Environment.UserInteractive)
            {
                container.Resolve<MetricIngestionService>().RunAsConsole(args);
            }
            else
            {
                ServiceBase[] ServicesToRun;

                ServicesToRun = new ServiceBase[]
                {
                container.Resolve<MetricIngestionService>()
                };

                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
