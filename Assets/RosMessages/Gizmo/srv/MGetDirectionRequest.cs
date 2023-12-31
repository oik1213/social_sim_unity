//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Gizmo
{
    public class MGetDirectionRequest : Message
    {
        public const string RosMessageName = "gizmo_msgs/GetDirection";

        public byte threshold;
        public ushort ms_duration;
        public ushort ms_delay;

        public MGetDirectionRequest()
        {
            this.threshold = 0;
            this.ms_duration = 0;
            this.ms_delay = 0;
        }

        public MGetDirectionRequest(byte threshold, ushort ms_duration, ushort ms_delay)
        {
            this.threshold = threshold;
            this.ms_duration = ms_duration;
            this.ms_delay = ms_delay;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(new[] { this.threshold });
            listOfSerializations.Add(BitConverter.GetBytes(this.ms_duration));
            listOfSerializations.Add(BitConverter.GetBytes(this.ms_delay));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            this.threshold = data[offset]; ;
            offset += 1;
            this.ms_duration = BitConverter.ToUInt16(data, offset);
            offset += 2;
            this.ms_delay = BitConverter.ToUInt16(data, offset);
            offset += 2;

            return offset;
        }

        public override string ToString()
        {
            return "MGetDirectionRequest: " +
            "\nthreshold: " + threshold.ToString() +
            "\nms_duration: " + ms_duration.ToString() +
            "\nms_delay: " + ms_delay.ToString();
        }
    }
}
