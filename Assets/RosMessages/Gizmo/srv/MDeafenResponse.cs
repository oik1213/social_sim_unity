//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Gizmo
{
    public class MDeafenResponse : Message
    {
        public const string RosMessageName = "gizmo_msgs/Deafen";

        public string state;

        public MDeafenResponse()
        {
            this.state = "";
        }

        public MDeafenResponse(string state)
        {
            this.state = state;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(SerializeString(this.state));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            var stateStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.state = DeserializeString(data, offset, stateStringBytesLength);
            offset += stateStringBytesLength;

            return offset;
        }

        public override string ToString()
        {
            return "MDeafenResponse: " +
            "\nstate: " + state.ToString();
        }
    }
}
