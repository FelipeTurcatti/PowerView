using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.IoT.Ingestion.Mqtt
{
    public class MqttClient: uPLibrary.Networking.M2Mqtt.MqttClient, IMqttClient
    {

        #region Constructor

        public MqttClient(String brokerHostName): base(brokerHostName)
        {

        }

        #endregion
    }
}
