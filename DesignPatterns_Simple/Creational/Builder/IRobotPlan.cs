using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Builder
{
    public interface IRobotPlan
    {
        void BuildRobotHead(string head);
        void BuildRobotTorso(string torso);
        void BuildRobotArms(string arms);
        void BuildRobotLegs(string legs);
        //void GetRobot();
    }
}
