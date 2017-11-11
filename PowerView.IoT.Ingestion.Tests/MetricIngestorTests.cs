using NUnit.Framework;
using PowerView.DataAccess.Abstractions;
using PowerView.Infrastructure;
using PowerView.IoT.Ingestion;
using PowerView.IoT.Ingestion.Mqtt;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.IoT.Ingestion.Tests
{
    [TestFixture]
    public class MetricIngestorTests
    {

        #region Members

        private MetricIngestor _target;

        private IMeasurementRepository _measurementRepository;

        private IConfiguration _configuration;

        private IMqttClient _mqttClient;

        #endregion

        #region Methods

        [SetUp]
        public void SetUp()
        {
            this._measurementRepository = MockRepository.GenerateMock<IMeasurementRepository>();

            this._mqttClient = MockRepository.GenerateMock<IMqttClient>();

            this._configuration = MockRepository.GenerateMock<IConfiguration>();

            this._target = new MetricIngestor(this._mqttClient, this._measurementRepository, this._configuration);
        }

        #endregion

    }
}
