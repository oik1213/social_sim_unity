//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Gizmo
{
    public class MMqttSubscribeResponse : Message
    {
        public const string RosMessageName = "gizmo_msgs/MqttSubscribe";

        public bool success;

        public MMqttSubscribeResponse()
        {
            this.success = false;
        }

        public MMqttSubscribeResponse(bool success)
        {
            this.success = success;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(BitConverter.GetBytes(this.success));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            this.success = BitConverter.ToBoolean(data, offset);
            offset += 1;

            return offset;
        }

        public override string ToString()
        {
            return "MMqttSubscribeResponse: " +
            "\nsuccess: " + success.ToString();
        }
    }
}
