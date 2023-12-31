//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.SocialSimRos
{
    public class MRealDepthImage : Message
    {
        public const string RosMessageName = "social_sim_ros/RealDepthImage";

        //  Message defining an array of real depth image
        public MHeader header;
        //  Header
        public float[] data;
        //  Array float32 data of real depth image

        public MRealDepthImage()
        {
            this.header = new MHeader();
            this.data = new float[0];
        }

        public MRealDepthImage(MHeader header, float[] data)
        {
            this.header = header;
            this.data = data;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            
            listOfSerializations.Add(BitConverter.GetBytes(data.Length));
            foreach(var entry in data)
                listOfSerializations.Add(BitConverter.GetBytes(entry));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            
            var dataArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.data= new float[dataArrayLength];
            for(var i = 0; i < dataArrayLength; i++)
            {
                this.data[i] = BitConverter.ToSingle(data, offset);
                offset += 4;
            }

            return offset;
        }

        public override string ToString()
        {
            return "MRealDepthImage: " +
            "\nheader: " + header.ToString() +
            "\ndata: " + System.String.Join(", ", data.ToList());
        }
    }
}
