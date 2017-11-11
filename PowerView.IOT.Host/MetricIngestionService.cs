using PowerView.IoT.Ingestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace PowerView.IoT.Host
{
    public partial class MetricIngestionService : ServiceBase
    {

        #region Members

        private readonly IUnityContainer _diContainer;

        private readonly IMetricIngestor _ingestor;

        #endregion

        #region Constructor

        public MetricIngestionService(IUnityContainer diContainer, IMetricIngestor ingestor)
        {
            this._diContainer = diContainer;

            this._ingestor = ingestor;

            InitializeComponent();
        }

        #endregion

        #region Methods

        public void RunAsConsole(String[] args)
        {
            this.OnStart(args);

            Console.WriteLine("PowerView IOT host is running in console mode. Press any key to exit...");

            Console.ReadLine();

            this.OnStop();
        }


        protected override void OnShutdown()
        {
            base.OnShutdown();

            this.EventLog.WriteEntry("MetricIngestionService is shutting Down...");

            this._ingestor.Disconnect();
        }

        protected override void OnStart(String[] args)
        {
            base.OnStart(args);

            this.EventLog.WriteEntry("MetricIngestionService is warming up...");

            this._ingestor.Connect();
            
        }

        protected override void OnPause()
        {
            base.OnPause();

            this.EventLog.WriteEntry("MetricIngestionService is paused...");

            this._ingestor.Disconnect();
        }

        protected override void OnContinue()
        {
            base.OnContinue();

            this.EventLog.WriteEntry("MetricIngestionService continues running after a pause...");

            this._ingestor.Connect();
        }

        protected override void OnStop()
        {
            base.OnStop();

            this.EventLog.WriteEntry("MetricIngestionService is stopped...");

            this._ingestor.Dispose();
        }

        #endregion

    }
}
