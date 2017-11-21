using Newtonsoft.Json;
using NUnit.Framework;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain;
using PowerView.Infrastructure;
using PowerView.IoT.Ingestion;
using PowerView.IoT.Ingestion.Mqtt;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt.Messages;
using static uPLibrary.Networking.M2Mqtt.MqttClient;

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

        [Test]
        public void Should_connect_to_the_underling_mqtt_server()
        {
            //Arrange.-

            //Act.-
            this._target.Connect();

            //Assert.-
            this._mqttClient.AssertWasCalled(e => e.Connect(Arg<String>.Is.Anything), opt => opt.Repeat.Once());
        }

        [Test]
        public void Should_subscribe_to_the_topic()
        {
            //Arrange.-

            //Act.-
            this._target.Connect();

            //Assert.-
            this._mqttClient.AssertWasCalled(e => e.Subscribe(Arg<String[]>.Is.Anything, Arg<Byte[]>.Is.Anything), opt => opt.Repeat.Once());
        }

        [Test]
        public void Should_disconnect_from_the_underling_mqtt_server()
        {
            //Arrange.-

            //Act.-
            this._target.Disconnect();

            //Assert.-
            this._mqttClient.AssertWasCalled(e => e.Disconnect(), opt => opt.Repeat.Once());
        }

        [Test]
        public void Should_disconnect_from_the_underling_mqtt_server_when_it_is_disposed()
        {
            //Arrange.-

            //Act.-
            this._target.Dispose();

            //Assert.-
            this._mqttClient.AssertWasCalled(e => e.Disconnect(), opt => opt.Repeat.Once());
        }

        [Test]
        public void Should_handle_an_mqtt_publication()
        {
            //Arrange.-
            this._target.Connect();

            //Act.-
            this._mqttClient.Raise(e => e.MqttMsgPublishReceived += null, this._mqttClient, new MqttMsgPublishEventArgs("/test",
                Encoding.UTF8.GetBytes("{\"sensorId\": \"1\",\"measurementUnitId\": 1,\"value\": 12.5,\"creationDate\": \"2017/11/10\"}"),
                false,
                2,
                true)
            );

            //Assert.-
            this._measurementRepository.AssertWasCalled(e => e.Add(Arg<Measurement>.Is.TypeOf), e => e.Repeat.Once());
        }

        [Test]
        public void Should_convert_MetricDTO_to_Measurement()
        {
            //Arrange.-
            Measurement measurement = new Measurement() { SensorId = "1", MeasurementUnitId = 1, Value = new Random(DateTime.Now.Millisecond).NextDouble() };          
            String valmeasure = JsonConvert.SerializeObject(measurement);

            //Act.-
            Measurement metric = this._target.GetMeasurement(valmeasure);

            //Assert.-
            Assert.AreEqual("1", metric.SensorId);
        }

        #endregion

    }
}
   
