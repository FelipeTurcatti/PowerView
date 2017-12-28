using Newtonsoft.Json;
using PowerView.DataAccess;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain;
using PowerView.Infrastructure;
using PowerView.IoT.Ingestion.Mqtt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace PowerView.IoT.Ingestion
{
    public class MetricIngestor : IMetricIngestor
    {

        #region Members

        private readonly IMqttClient _client;

        private readonly IMeasurementRepository _measurementRepository;

        private readonly IConfiguration _configuration;

        private readonly String _clientId;

        #endregion

        #region Constructor

        public MetricIngestor(IMqttClient mqttClient, IMeasurementRepository measurementRepository, IConfiguration configuration)
        {

            this._measurementRepository = measurementRepository;

            this._configuration = configuration;

            this._client = mqttClient;            

            // use a unique id as client id, each time we start the application 
            this._clientId = Guid.NewGuid().ToString();
        }

        #endregion

        #region Methods

        public void Connect()
        {
            // register a callback-function (we have to implement, see below) which is called by the library when a message was received 
            this._client.MqttMsgPublishReceived += OnMessagePublishReceived;

            this._client.Connect(_clientId);

            this._client.Subscribe(new String[] { this._configuration.MeasurementTopic}, new byte[] { 2 });
        }

        public void Disconnect()
        {
            this._client.MqttMsgPublishReceived -= OnMessagePublishReceived;

            this._client.Disconnect();
        }

        public void Dispose()
        {
            this.Disconnect();
        }

        private void OnMessagePublishReceived(Object sender, MqttMsgPublishEventArgs e)
        {
            String metric = Encoding.UTF8.GetString(e.Message);

            Measurement measurement = GetMeasurement(metric);

            this._measurementRepository.Add(measurement);
        }

        public Measurement GetMeasurement(String metric)
        {
            Measurement measurement = JsonConvert.DeserializeObject<Measurement>(metric);
            measurement.CreationDate = DateTime.Now;
            return measurement;
        }
        #endregion
    }
}
