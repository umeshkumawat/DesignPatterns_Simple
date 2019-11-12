using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Builder
{
    public class Robot : IRobotPlan
    {
        public string RobotArms { get; set; }
        public string RobotHead { get; set; }
        public string RobotLegs { get; set; }
        public string RobotTorso { get; set; }

        public void BuildRobotArms(string arms)
        {
            RobotArms = arms;
        }

        public void BuildRobotHead(string head)
        {
            RobotHead = head;
        }

        public void BuildRobotLegs(string legs)
        {
            RobotLegs = legs;
        }

        public void BuildRobotTorso(string torso)
        {
            RobotTorso = torso;
        }
    }
}
