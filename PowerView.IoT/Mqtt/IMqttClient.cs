using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using static uPLibrary.Networking.M2Mqtt.MqttClient;

namespace PowerView.IoT.Ingestion.Mqtt
{
    public interface IMqttClient
    {

        #region Events

        event ConnectionClosedEventHandler ConnectionClosed;

        event MqttMsgPublishedEventHandler MqttMsgPublished;

        event MqttMsgPublishEventHandler MqttMsgPublishReceived;

        event MqttMsgSubscribedEventHandler MqttMsgSubscribed;

        event MqttMsgUnsubscribedEventHandler MqttMsgUnsubscribed;

        #endregion

        #region Properties

        Boolean CleanSession { get; }

        String ClientId { get; }

        Boolean IsConnected { get; }

        MqttProtocolVersion ProtocolVersion { get; set; }

        MqttSettings Settings { get; }

        Boolean WillFlag { get; }

        String WillMessage { get; }

        Byte WillQosLevel { get; }

        String WillTopic { get; }

        #endregion

        #region Methods

        Byte Connect(String clientId);

        Byte Connect(String clientId, String username, String password);

        Byte Connect(String clientId, String username, String password, Boolean cleanSession, UInt16 keepAlivePeriod);

        Byte Connect(String clientId, String username, String password, Boolean willRetain, Byte willQosLevel, Boolean willFlag, String willTopic, String willMessage, Boolean cleanSession, UInt16 keepAlivePeriod);
        
        UInt16 Publish(String topic, Byte[] message);

        UInt16 Publish(String topic, Byte[] message, Byte qosLevel, Boolean retain);

        UInt16 Subscribe(String[] topics, Byte[] qosLevels);

        UInt16 Unsubscribe(String[] topics);

        void Disconnect();

        #endregion
       
    }
}
