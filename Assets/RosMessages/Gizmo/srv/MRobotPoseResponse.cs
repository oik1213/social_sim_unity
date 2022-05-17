//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Gizmo
{
    public class MRobotPoseResponse : Message
    {
        public const string RosMessageName = "gizmo_msgs/RobotPose";

        public Geometry.MPose pose;

        public MRobotPoseResponse()
        {
            this.pose = new Geometry.MPose();
        }

        public MRobotPoseResponse(Geometry.MPose pose)
        {
            this.pose = pose;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(pose.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.pose.Deserialize(data, offset);

            return offset;
        }

        public override string ToString()
        {
            return "MRobotPoseResponse: " +
            "\npose: " + pose.ToString();
        }
    }
}