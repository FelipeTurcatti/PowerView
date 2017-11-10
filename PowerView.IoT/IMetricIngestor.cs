using System;

namespace PowerView.IoT.Ingestion
{
    public interface IMetricIngestor: IDisposable
    {

        void Connect();

        void Disconnect();
    }
}