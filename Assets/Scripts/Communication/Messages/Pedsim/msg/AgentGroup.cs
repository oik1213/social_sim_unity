/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Pedsim
{
    public class AgentGroup : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "pedsim_msgs/AgentGroup";

        public Header header;
        public ushort group_id;
        public double age;
        public ulong[] members;
        public Pose center_of_mass;

        public AgentGroup()
        {
            this.header = new Header();
            this.group_id = 0;
            this.age = 0.0;
            this.members = new ulong[0];
            this.center_of_mass = new Pose();
        }

        public AgentGroup(Header header, ushort group_id, double age, ulong[] members, Pose center_of_mass)
        {
            this.header = header;
            this.group_id = group_id;
            this.age = age;
            this.members = members;
            this.center_of_mass = center_of_mass;
        }
    }
}