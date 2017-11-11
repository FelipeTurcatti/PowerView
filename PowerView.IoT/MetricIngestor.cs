using Newtonsoft.Json;
using PowerView.DataAccess;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain;
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

        private readonly MqttClient _client;

        private readonly String _clientId;

        private const String BrokerAddress = "127.0.0.1";

        private readonly String _topic;

        private readonly IMeasurementRepository _measurementRepository;

        #endregion

        #region Constructor

        public MetricIngestor(IMeasurementRepository measurementRepository)
        {

            this._measurementRepository = measurementRepository;

            this._topic = "/test";

            // use a unique id as client id, each time we start the application 
            this._clientId = Guid.NewGuid().ToString();

            this._client = new MqttClient(BrokerAddress);

        }

        #endregion

        #region Methods

        public void Connect()
        {
            // register a callback-function (we have to implement, see below) which is called by the library when a message was received 
            this._client.MqttMsgPublishReceived += OnMessagePublishReceived;

            this._client.Connect(_clientId);

            this._client.Subscribe(new String[] { this._topic }, new byte[] { 2 });
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

            Measurement measurement = JsonConvert.DeserializeObject<Measurement>(metric);

            this._measurementRepository.Add(measurement);
        }

        #endregion
    }
}
