//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Gizmo
{
    public class MAction : Message
    {
        public const string RosMessageName = "gizmo_msgs/Action";

        //  ROS message to broadcast the robot's current task and/or reaction
        public string task;
        public string reaction;

        public MAction()
        {
            this.task = "";
            this.reaction = "";
        }

        public MAction(string task, string reaction)
        {
            this.task = task;
            this.reaction = reaction;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(SerializeString(this.task));
            listOfSerializations.Add(SerializeString(this.reaction));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            var taskStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.task = DeserializeString(data, offset, taskStringBytesLength);
            offset += taskStringBytesLength;
            var reactionStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.reaction = DeserializeString(data, offset, reactionStringBytesLength);
            offset += reactionStringBytesLength;

            return offset;
        }

        public override string ToString()
        {
            return "MAction: " +
            "\ntask: " + task.ToString() +
            "\nreaction: " + reaction.ToString();
        }
    }
}
